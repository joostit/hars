using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrrrBayBay.HARs.dataModel;
using BrrrBayBay.SpriteCommHandler;

namespace BrrrBayBay.HARs
{

	public partial class PerformRaceForm : Form
	{

		public event TrackFinishedEventHandler TrackFinished;

		private delegate void voidDelegate();
		private delegate void ErrorDelegate(ErrorReceivedEventArs args);
		private delegate void RaceResultDelegate(RaceResultsReceivedEventArgs args);
		private delegate void TrackFinishedDelegate(TrackFinishedEventArgs args);

		private EventHandler startAck;
		private EventHandler endedAck;
		private EventHandler started;
		private TrackFinishedEventHandler trackFinished;
		private RaceResultsReceivedEventHandler resultsReceived;

		private Boolean allowClose = false;
		private Boolean racePerformed = false;

		private List<User> availableUsers;
		private Dictionary<User, int> timings = null;
		private Dictionary<int, User> raceSetup = null;
		private Boolean spriteCommEnabled = false;
		private Boolean raceInterrupted = false;

		private SerialSpriteCommHandler commHandler = null;

		/// <summary>
		/// Holds the tracks (tracknumber as key) that need to finish and their status (as value)
		/// </summary>
		private Dictionary<int, Boolean> tracksFinished;
		

		/// <summary>
		/// Constructor
		/// </summary>
		public PerformRaceForm()
		{
			InitializeComponent();
			spriteCommEnabled = Properties.Settings.Default.spriteCommEnabled;
		}

		
		/// <summary>
		/// Raises the trackFinishedEvent
		/// </summary>
		/// <param name="args">EventArgs</param>
		private void raiseTrackFinishedEvent(TrackFinishedEventArgs args)
		{
			if (TrackFinished != null)
			{
				TrackFinished(this, args);
			}
		}


		/// <summary>
		/// Shows this Form to perform a race
		/// </summary>
		/// <param name="availableUsers">Tyhe users available for the race</param>
		/// <param name="autoSetup">Tells the form to automatically select which user uses a track</param>
		/// <returns>a dictionary with userID's as key, and the raceTime as value</returns>
		public Dictionary<User, int> performRace(List<User> availableUsers, AutoTrackPlacementModes placementMode, Boolean allowPlacementEdit, SerialSpriteCommHandler commHandler)
		{
			this.availableUsers = availableUsers;
			raceSetupControl.init(availableUsers, placementMode, allowPlacementEdit);
			this.commHandler = commHandler;

			if (spriteCommEnabled && (commHandler != null))
			{
				initSpriteComm();
			}

			this.ShowDialog();

			if (spriteCommEnabled && (commHandler != null))
			{
				deInitSpriteComm();
			}

			return timings;
		}


		/// <summary>
		/// Inititializes the event handlers for the spriteControl
		/// </summary>
		private void initSpriteComm()
		{
			startAck = new EventHandler(commHandler_RaceStartedAck);
			endedAck = new EventHandler(commHandler_RaceEndedAck);
			started = new EventHandler(commHandler_RaceStarted);
			trackFinished = new TrackFinishedEventHandler(commHandler_TrackFinished);
			resultsReceived = new RaceResultsReceivedEventHandler(commHandler_RaceResultsReceived);

			commHandler.RaceStartedAck += startAck;
			commHandler.RaceEndedAck += endedAck;
			commHandler.RaceStarted += started;
			commHandler.TrackFinished += trackFinished;
			commHandler.RaceResultsReceived += resultsReceived;
		}

		/// <summary>
		/// DeInitializes the event handlers  for the spriteControl
		/// </summary>
		private void deInitSpriteComm()
		{
			commHandler.RaceStartedAck -= startAck;
			commHandler.RaceEndedAck -= endedAck;
			commHandler.RaceStarted -= started;
			commHandler.TrackFinished -= trackFinished;
			commHandler.RaceResultsReceived -= resultsReceived;
		}

		void invoked_commHandler_RaceResultsReceived(RaceResultsReceivedEventArgs args)
		{
			//if (!raceInterrupted)
			//{
				foreach (KeyValuePair<int, int> kvp in args.Results)
				{
					raceSetupControl.setTime(kvp.Key, kvp.Value);
				}
				requestTimeLabel.Visible = false;
				raceFinished();
			//}
		}


		void invoked_commHandler_TrackFinished(TrackFinishedEventArgs args)
		{
			if (!raceInterrupted)
			{
				Boolean allDone = true;
				// Register the finished track
				try
				{
					tracksFinished[args.TrackNumber] = true;
					raceSetupControl.setTrackFinished(args.TrackNumber);
				}
				catch { }

				// Check if all tracks are finished
				foreach (Boolean fini in tracksFinished.Values)
				{
					if (fini == false)
					{
						allDone = false;
					}
				}

				if (allDone)
				{
					raceEndingLabel.Visible = true;
					commHandler.endRace();
				}
			}
		}

		void invoked_commHandler_RaceStarted()
		{
			waitingForFinishLabel.Visible = true;
		}

		void invoked_commHandler_RaceEndedAck()
		{
			raceEndingLabel.Visible = false;

			if (!raceInterrupted)
			{
				waitingForFinishLabel.Visible = false;
				requestTimeLabel.Visible = true;
				requestTrackTimes();
			}
		}

		void invoked_commHandler_RaceStartedAck()
		{
			if (!raceInterrupted)
			{
				performRace();
			}
		}



		void commHandler_RaceResultsReceived(object sender, RaceResultsReceivedEventArgs args)
		{
			RaceResultDelegate del = new RaceResultDelegate(invoked_commHandler_RaceResultsReceived);
			this.Invoke(del, args);
		}

		void commHandler_TrackFinished(object sender, TrackFinishedEventArgs args)
		{
			// First pass the event to any listeners
			raiseTrackFinishedEvent(args);

			TrackFinishedDelegate del = new TrackFinishedDelegate(invoked_commHandler_TrackFinished);
			this.Invoke(del, args);
		}

		void commHandler_RaceStarted(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invoked_commHandler_RaceStarted);
			this.Invoke(del);
		}

		void commHandler_RaceEndedAck(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invoked_commHandler_RaceEndedAck);
			this.Invoke(del);
		}

		void commHandler_RaceStartedAck(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invoked_commHandler_RaceStartedAck);
			this.Invoke(del);
		}

		


		private void PerformRaceForm_Load(object sender, EventArgs e)
		{
			
			// Nothing to do here!

		}



		private void nextButton_Click(object sender, EventArgs e)
		{
			if (racePerformed == false)
			{
				raceSetup = raceSetupControl.getRaceSetup();

				if (raceSetup != null)
				{

					nextButton.Enabled = false;
					cancelButton.Enabled = false;
					MessageBox.Show("Zet de auto's klaar en druk op OK om de race te starten.", "Start race", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					// Create the table which holds the finished state for each car
					if (spriteCommEnabled)
					{
						commHandler.setDisplayString("--------");

						tracksFinished = new Dictionary<int, bool>();
						foreach (KeyValuePair<int, User> kvp in raceSetup)
						{
							if (kvp.Value != null)
							{
								tracksFinished.Add(kvp.Key, false);
							}
						}
						endRaceButton.Visible = true;
						commHandler.startRace();
					}
					else
					{
						endRaceButton.Visible = true;
						performRace();
					}
				}
			}
			else
			{
				Dictionary<int,int> trackResults = raceSetupControl.getTimings();
				if (trackResults == null)
				{
					MessageBox.Show("Niet alle tijden zijn ingevult.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					timings = new Dictionary<User, int>();

					foreach (int trackId in trackResults.Keys)
					{
						timings.Add(raceSetup[trackId], trackResults[trackId]);
					}
					this.allowClose = true;
					this.Close();
				}
			}
		}


		private void performRace()
		{
			racingLabel.Visible = true;
			requestTimesButton.Visible = true;
		}


		private void requestTrackTimes()
		{
			commHandler.requestRaceResults();
		}



		private void raceFinished()
		{
			racePerformed = true;
			racingLabel.Visible = false;
			manualTimeEntryButton.Visible = true;
			endRaceButton.Visible = false;
			cancelButton.Enabled = true;
			nextButton.Enabled = true;
		}


		private void PerformRaceForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!allowClose)
			{
				e.Cancel = true;
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			if (racePerformed)
			{
				DialogResult diagRes = MessageBox.Show("Hierdoor gaan de resultaten van deze race verloren. Weet je zeker dat je wit wil?", "Annuleren", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (diagRes == DialogResult.Yes)
				{
					allowClose = true;
					this.Close();
				}

			}
			else
			{
				timings = null;
				allowClose = true;
				this.Close();
			}
		}

		private void manualTimeEntryButton_Click(object sender, EventArgs e)
		{
			manualTimeEntryButton.Visible = false;
			raceSetupControl.allowManualTimeEdit();
		}

		private void endRaceButton_Click(object sender, EventArgs e)
		{
			DialogResult diagRes = MessageBox.Show("Niet alle deelnemers zijn gefinished. Weet je zeker dat je de race wil beëindigen?", "Race beëindigen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (diagRes == DialogResult.Yes)
			{
				raceInterrupted = true;
				raceFinished();
			}
		}

		private void requestTimesButton_Click(object sender, EventArgs e)
		{
			raceInterrupted = true;
			commHandler.requestRaceResults();
		}
	}
}
