using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BrrrBayBay.SpriteCommHandler;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrrrBayBay.SpriteCommTester
{
	public partial class SpriteCommTesterMainForm : Form
	{

		SerialSpriteCommHandler commHandler;

		private delegate void voidDelegate();
		private delegate void ErrorDelegate(ErrorReceivedEventArs args);
		private delegate void RaceResultDelegate(RaceResultsReceivedEventArgs args);
		private delegate void TrackFinishedDelegate(TrackFinishedEventArgs args);

		private Dictionary<int, CheckBox> finishFlags = new Dictionary<int, CheckBox>();

		public SpriteCommTesterMainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			initFinishFlags();
			initConnection();
			subscribeEventHandlers();
		}


		private void subscribeEventHandlers()
		{
			commHandler.RaceStartedAck += new EventHandler(commHandler_RaceStartedAck);
			commHandler.ControllerResetAck += new EventHandler(commHandler_ControllerResetAcked);
			commHandler.ErrorReceived += new ErrorReceivedEventHandler(commHandler_ErrorReceived);
			commHandler.RaceEndedAck += new EventHandler(commHandler_RaceEndedAck);
			commHandler.RaceResultsReceived += new RaceResultsReceivedEventHandler(commHandler_RaceResultsReceived);
			commHandler.SpriteControllerReady += new EventHandler(commHandler_SpriteControllerReady);
			commHandler.TrackFinished += new TrackFinishedEventHandler(commHandler_TrackFinished);
			commHandler.RaceStarted += new EventHandler(commHandler_RaceStarted);

		}

		void commHandler_RaceStarted(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invokedRaceStarted);
			this.Invoke(del);
		}

		void invokedRaceStarted()
		{
			carsRollingBox.Checked = true;
		}


		private void initFinishFlags()
		{
			finishFlags.Add(1, f1box);
			finishFlags.Add(2, f2box);
			finishFlags.Add(3, f3box);
			finishFlags.Add(4, f4box);
			finishFlags.Add(5, f5box);
			finishFlags.Add(6, f6box);
			finishFlags.Add(7, f7box);
			finishFlags.Add(8, f8box);

			foreach (CheckBox cb in finishFlags.Values)
			{
				cb.Checked = false;
			}
		}

		void commHandler_TrackFinished(object sender, TrackFinishedEventArgs args)
		{
			TrackFinishedDelegate del = new TrackFinishedDelegate(invokedTrackFinished);
			this.Invoke(del, args);
		}

		private void invokedTrackFinished(TrackFinishedEventArgs args)
		{
			finishFlags[args.TrackNumber].Checked = true;
		}

		void commHandler_SpriteControllerReady(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invokedSpriteControllerReady);
			this.Invoke(del);
		}


		private void invokedSpriteControllerReady()
		{
			MessageBox.Show("SpriteController Ready!");
		}


		void commHandler_RaceResultsReceived(object sender, RaceResultsReceivedEventArgs args)
		{
			RaceResultDelegate del = new RaceResultDelegate(invokedRaceResultsReceived);
			this.Invoke(del, args);
		}

		private void invokedRaceResultsReceived(RaceResultsReceivedEventArgs args)
		{
			String msg = "Results:\n";
			for(int i = 1; i < 9; i++)
			{
				msg = msg + i.ToString() + ": " + args.Results[i] + "\n";
			}
			MessageBox.Show(msg);
		}

		void commHandler_RaceEndedAck(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invokedRaceEndedAck);
			this.Invoke(del);
		}

		private void invokedRaceEndedAck()
		{
			endRaceAckBox.Checked = true;
		}

		void commHandler_ErrorReceived(object sender, ErrorReceivedEventArs args)
		{
			ErrorDelegate del = new ErrorDelegate(invokedErrorReceived);
			this.Invoke(del, args);
		}

		private void invokedErrorReceived(ErrorReceivedEventArs args)
		{
			MessageBox.Show("Error received for track: " + args.TrackNumber.ToString() + "\n" + args.Description);
		}

		void commHandler_ControllerResetAcked(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invokedControllerResetAck);
			this.Invoke(del);
		}

		private void invokedControllerResetAck()
		{
			resetAckBox.Checked = true ;
		}

		private void invokedStartAck()
		{
			startAckBox.Checked = true;
		}

		void commHandler_RaceStartedAck(object sender, EventArgs e)
		{
			voidDelegate del = new voidDelegate(invokedStartAck);
			this.Invoke(del);
		}


		private void initConnection()
		{
			commHandler = new SerialSpriteCommHandler();
			commHandler.PortName = "COM4";
			commHandler.BaudRate = 9600;
			commHandler.StopBits = System.IO.Ports.StopBits.One;
			commHandler.DataBits = 8;
			commHandler.Parity = System.IO.Ports.Parity.None;
			commHandler.connect();
		}


		private void startRaceButton_Click(object sender, EventArgs e)
		{
			startAckBox.Checked = false;
			carsRollingBox.Checked = false;

			foreach (CheckBox cb in finishFlags.Values)
			{
				cb.Checked = false;
			}
			commHandler.startRace();
		}


		private void SpriteCommTesterMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (commHandler != null)
			{
				commHandler.disconnect();
			}
		}


		private void endRaceButton_Click(object sender, EventArgs e)
		{
			endRaceAckBox.Checked = false;
			commHandler.endRace();
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			resetAckBox.Checked = false;
			commHandler.resetController();
		}

		private void getResultsButton_Click(object sender, EventArgs e)
		{
			commHandler.requestRaceResults();
		}

	}
}
