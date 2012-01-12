using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrrrBayBay.HARs.dataModel;

namespace BrrrBayBay.HARs
{
	public partial class RaceSetupControl : UserControl
	{
		Dictionary<int, RaceTimeBox> timingBoxes = new Dictionary<int, RaceTimeBox>();
		Dictionary<int, TrackLayoutControl> trackControls = new Dictionary<int, TrackLayoutControl>();
		List<User> Users;
		Boolean allowPlacementEdit;

		public RaceSetupControl()
		{
			InitializeComponent();
		}

		private void RaceSetupControl_Load(object sender, EventArgs e)
		{
			

			timingBoxes.Add(1, raceTimeBox1);
			timingBoxes.Add(2, raceTimeBox2);
			timingBoxes.Add(3, raceTimeBox3);
			timingBoxes.Add(4, raceTimeBox4);
			timingBoxes.Add(5, raceTimeBox5);
			timingBoxes.Add(6, raceTimeBox6);
			timingBoxes.Add(7, raceTimeBox7);
			timingBoxes.Add(8, raceTimeBox8);


			for (int i = 1; i < 9; i++)
			{
				timingBoxes[i].init(i);
				timingBoxes[i].setEnabled(false);
			}
			

		}

		public void init(List<User> availableUsers, AutoTrackPlacementModes placementMode, Boolean allowPalcementEdit)
		{
			Users = availableUsers;
			initControls();
			this.allowPlacementEdit = allowPalcementEdit;
			
			if (placementMode == AutoTrackPlacementModes.Sequential)
			{
				DoAutoPlace();
			}
		}


		/// <summary>
		/// Mark the track as finished
		/// </summary>
		/// <param name="trackId">The track ID</param>
		public void setTrackFinished(int trackId)
		{
			timingBoxes[trackId].setFinished();
		}


		/// <summary>
		/// Gets the race setup.
		/// </summary>
		/// <returns>a dictionary with trackNumer as key and a Userobject (or null) as value. Returns null when an error occured.</returns>
		public Dictionary<int, User> getRaceSetup()
		{
			Dictionary<int, User> setup = null;

			if (doDuplicityCheck() == true)
			{
				setup = new Dictionary<int, User>();

				for (int i = 1; i < 9; i++)
				{
					if (trackControls[i].TrackEnabled)
					{
						setup.Add(i, trackControls[i].SelectedUser);
					}
					else
					{
						setup.Add(i, null);
						timingBoxes[i].setVisible(false);
					}
					trackControls[i].lockControl();
				}
				return setup;
			}
			else
			{
				return null;
			}
			
		}


		private void initControls()
		{
			trackControls.Add(1, trackLayoutControl1);
			trackControls.Add(2, trackLayoutControl2);
			trackControls.Add(3, trackLayoutControl3);
			trackControls.Add(4, trackLayoutControl4);
			trackControls.Add(5, trackLayoutControl5);
			trackControls.Add(6, trackLayoutControl6);
			trackControls.Add(7, trackLayoutControl7);
			trackControls.Add(8, trackLayoutControl8);

			for (int i = 1; i <= 8; i++)
			{
					trackControls[i].init(i, Users);
			}
		}

		private void DoAutoPlace()
		{
			foreach (TrackLayoutControl tlc in trackControls.Values)
			{
				tlc.TrackEnabled = false;
			}

			for (int i = 0; ((i < Users.Count) && (i < 8)); i++)
			{
				if (Users[i] != null)
				{
					trackControls[i + 1].TrackEnabled = true;
					trackControls[i + 1].SelectedUser = Users[i];
				}
			}

			if (!allowPlacementEdit)
			{
				foreach (TrackLayoutControl tlc in trackControls.Values)
				{
					tlc.setReadOnly();
				}
			}
		}


		/// <summary>
		/// Allows manual editing of the time boxes
		/// </summary>
		public void allowManualTimeEdit()
		{
			for (int i = 1; i < 9; i++)
			{
				if (trackControls[i].TrackEnabled)
				{
					timingBoxes[i].setEnabled(true);
				}
			}
		}



		/// <summary>
		/// Sets the time for a specific timing box
		/// </summary>
		/// <param name="trackId">The track number</param>
		/// <param name="timeMs">The time in milliseconds</param>
		public void setTime(int trackId, int timeMs)
		{
			if (trackControls[trackId].TrackEnabled)
			{
				timingBoxes[trackId].setTime(timeMs);
			}
		}


		/// <summary>
		/// Gets all timings
		/// </summary>
		/// <returns>a dictionary with track ID as key, and the time as value</returns>
		public Dictionary<int, int> getTimings()
		{
			int val;
			Dictionary<int, int> retVal = new Dictionary<int, int>();

			for (int i = 1; i < 9; i++)
			{
				if (trackControls[i].TrackEnabled)
				{
					val = timingBoxes[i].getTime();
					if (val == 0)
					{
						return null;
					}
					else
					{
						retVal.Add(i, val);
					}
				}
			}
			return retVal;
		}


		/// <summary>
		/// Checks if one user isn't placed one two or more tracks
		/// </summary>
		/// <returns>true if no duplicates were found</returns>
		private Boolean doDuplicityCheck()
		{
			int currId;
			Boolean success = true;

			// First make sure if all control have a valid selection
			foreach (TrackLayoutControl tlc in trackControls.Values)
			{
				tlc.checkSelection();
			}

			for (int outerI = 1; outerI < 9; outerI++)
			{
				if (trackControls[outerI].TrackEnabled)
				{
					currId = trackControls[outerI].SelectedUser.ID;
					for (int innerI = outerI + 1; innerI < 9; innerI++)
					{
						if (trackControls[innerI].TrackEnabled)
						{
							if (trackControls[innerI].SelectedUser.ID == currId)
							{
								MessageBox.Show("Deelnemer met startnummer " + trackControls[innerI].SelectedUser.startNumber.ToString() + " staat op meerdere banen opgesteld. \n(Baan " + outerI.ToString() + " en " + innerI.ToString() + ")", "Ongeldige opstelling", MessageBoxButtons.OK, MessageBoxIcon.Error);
								success = false;
								break;
							}
						}
					}
				}
			}
			return success;

		}


	}
}
