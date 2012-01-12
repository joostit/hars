using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrrrBayBay.HARs.dataModel;
using System.Windows.Forms;
using BrrrBayBay.SpriteCommHandler;

namespace BrrrBayBay.HARs
{
	/// <summary>
	///  represents a timetrial game panel
	/// </summary>
	public class TimeTrialControl : GameControl
	{
		private System.Windows.Forms.GroupBox resultsGroupBox;
		private System.Windows.Forms.ListView resultsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.GroupBox unracedGroup;
		private System.Windows.Forms.ListView todoListView;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private GroupBox controlGroup;
		private Button startHeatButton;
		private Button removeUserButton;
		private Button clearResultButton;
		private Button saveScoresButton;
		private Button addUserButton;
		/// <summary>
		/// Designer code
		/// </summary>
		private void InitializeComponent()
		{
			this.resultsGroupBox = new System.Windows.Forms.GroupBox();
			this.resultsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.unracedGroup = new System.Windows.Forms.GroupBox();
			this.todoListView = new System.Windows.Forms.ListView();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.controlGroup = new System.Windows.Forms.GroupBox();
			this.saveScoresButton = new System.Windows.Forms.Button();
			this.clearResultButton = new System.Windows.Forms.Button();
			this.removeUserButton = new System.Windows.Forms.Button();
			this.startHeatButton = new System.Windows.Forms.Button();
			this.addUserButton = new System.Windows.Forms.Button();
			this.resultsGroupBox.SuspendLayout();
			this.unracedGroup.SuspendLayout();
			this.controlGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// resultsGroupBox
			// 
			this.resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.resultsGroupBox.Controls.Add(this.resultsListView);
			this.resultsGroupBox.Location = new System.Drawing.Point(558, 3);
			this.resultsGroupBox.Name = "resultsGroupBox";
			this.resultsGroupBox.Size = new System.Drawing.Size(343, 798);
			this.resultsGroupBox.TabIndex = 2;
			this.resultsGroupBox.TabStop = false;
			this.resultsGroupBox.Text = "Klassement";
			// 
			// resultsListView
			// 
			this.resultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.resultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.resultsListView.FullRowSelect = true;
			this.resultsListView.HideSelection = false;
			this.resultsListView.Location = new System.Drawing.Point(6, 19);
			this.resultsListView.Name = "resultsListView";
			this.resultsListView.Size = new System.Drawing.Size(331, 773);
			this.resultsListView.TabIndex = 0;
			this.resultsListView.UseCompatibleStateImageBehavior = false;
			this.resultsListView.View = System.Windows.Forms.View.Details;
			this.resultsListView.SelectedIndexChanged += new System.EventHandler(this.resultsListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 33;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Naam";
			this.columnHeader2.Width = 138;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Nr.";
			this.columnHeader3.Width = 37;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tijd";
			this.columnHeader4.Width = 82;
			// 
			// unracedGroup
			// 
			this.unracedGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.unracedGroup.Controls.Add(this.todoListView);
			this.unracedGroup.Location = new System.Drawing.Point(209, 3);
			this.unracedGroup.Name = "unracedGroup";
			this.unracedGroup.Size = new System.Drawing.Size(343, 798);
			this.unracedGroup.TabIndex = 3;
			this.unracedGroup.TabStop = false;
			this.unracedGroup.Text = "Nog te racen deelnemers";
			// 
			// todoListView
			// 
			this.todoListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.todoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
			this.todoListView.FullRowSelect = true;
			this.todoListView.HideSelection = false;
			this.todoListView.Location = new System.Drawing.Point(6, 19);
			this.todoListView.Name = "todoListView";
			this.todoListView.Size = new System.Drawing.Size(331, 773);
			this.todoListView.TabIndex = 0;
			this.todoListView.UseCompatibleStateImageBehavior = false;
			this.todoListView.View = System.Windows.Forms.View.Details;
			this.todoListView.SelectedIndexChanged += new System.EventHandler(this.todoListView_SelectedIndexChanged);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Naam";
			this.columnHeader6.Width = 178;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Nr.";
			this.columnHeader7.Width = 80;
			// 
			// controlGroup
			// 
			this.controlGroup.Controls.Add(this.saveScoresButton);
			this.controlGroup.Controls.Add(this.clearResultButton);
			this.controlGroup.Controls.Add(this.removeUserButton);
			this.controlGroup.Controls.Add(this.startHeatButton);
			this.controlGroup.Controls.Add(this.addUserButton);
			this.controlGroup.Location = new System.Drawing.Point(3, 3);
			this.controlGroup.Name = "controlGroup";
			this.controlGroup.Size = new System.Drawing.Size(200, 229);
			this.controlGroup.TabIndex = 4;
			this.controlGroup.TabStop = false;
			this.controlGroup.Text = "Besturing";
			// 
			// saveScoresButton
			// 
			this.saveScoresButton.Location = new System.Drawing.Point(6, 198);
			this.saveScoresButton.Name = "saveScoresButton";
			this.saveScoresButton.Size = new System.Drawing.Size(188, 23);
			this.saveScoresButton.TabIndex = 6;
			this.saveScoresButton.Text = "Klassement opslaan";
			this.saveScoresButton.UseVisualStyleBackColor = true;
			this.saveScoresButton.Click += new System.EventHandler(this.saveScoresButton_Click);
			// 
			// clearResultButton
			// 
			this.clearResultButton.Enabled = false;
			this.clearResultButton.Location = new System.Drawing.Point(6, 169);
			this.clearResultButton.Name = "clearResultButton";
			this.clearResultButton.Size = new System.Drawing.Size(188, 23);
			this.clearResultButton.TabIndex = 5;
			this.clearResultButton.Text = "Resultaten &Wissen";
			this.clearResultButton.UseVisualStyleBackColor = true;
			this.clearResultButton.Click += new System.EventHandler(this.clearResultButton_Click);
			// 
			// removeUserButton
			// 
			this.removeUserButton.Location = new System.Drawing.Point(6, 122);
			this.removeUserButton.Name = "removeUserButton";
			this.removeUserButton.Size = new System.Drawing.Size(188, 23);
			this.removeUserButton.TabIndex = 4;
			this.removeUserButton.Text = "Deelnemer(s) &Verwijderen";
			this.removeUserButton.UseVisualStyleBackColor = true;
			this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
			// 
			// startHeatButton
			// 
			this.startHeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startHeatButton.Location = new System.Drawing.Point(6, 19);
			this.startHeatButton.Name = "startHeatButton";
			this.startHeatButton.Size = new System.Drawing.Size(188, 42);
			this.startHeatButton.TabIndex = 3;
			this.startHeatButton.Text = "&Start race";
			this.startHeatButton.UseVisualStyleBackColor = true;
			this.startHeatButton.Click += new System.EventHandler(this.startHeatButton_Click);
			// 
			// addUserButton
			// 
			this.addUserButton.Location = new System.Drawing.Point(6, 93);
			this.addUserButton.Name = "addUserButton";
			this.addUserButton.Size = new System.Drawing.Size(188, 23);
			this.addUserButton.TabIndex = 2;
			this.addUserButton.Text = "Deelnemer(s) &toevoegen";
			this.addUserButton.UseVisualStyleBackColor = true;
			this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
			// 
			// TimeTrialControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.controlGroup);
			this.Controls.Add(this.unracedGroup);
			this.Controls.Add(this.resultsGroupBox);
			this.Name = "TimeTrialControl";
			this.Size = new System.Drawing.Size(1408, 804);
			this.Load += new System.EventHandler(this.TimeTrialControl_Load);
			this.resultsGroupBox.ResumeLayout(false);
			this.unracedGroup.ResumeLayout(false);
			this.controlGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private int finishCount = 0;
		char[] displayString = new char[8];

		volatile Boolean AllowDisplayChange = true;
		volatile Boolean DisplayChangePending = false;



		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="game">The game object</param>
		public TimeTrialControl(HARGame game, SerialSpriteCommHandler commHandler)
		{
			base.CommHandler = commHandler;
			base.Game = game;
			this.InitializeComponent();
			if (Properties.Settings.Default.spriteCommEnabled)
			{
				commHandler.DisplayAckReceived += new EventHandler(commHandler_DisplayAckReceived);
			}
		}

		void commHandler_DisplayAckReceived(object sender, EventArgs e)
		{
			AllowDisplayChange = true;
			if (DisplayChangePending)
			{
				CommHandler.setDisplayString(new String(displayString));
				AllowDisplayChange = false;
				DisplayChangePending = false;
			}
		}


		private void TimeTrialControl_Load(object sender, EventArgs e)
		{
			fillUserLists();
		}


		/// <summary>
		/// Fills the lists with data from the database
		/// </summary>
		private void fillUserLists()
		{
			User tmpUsr = null;
			ListViewItem lvi = null;
			List<int> usersWithResult = new List<int>();

			todoListView.Items.Clear();
			resultsListView.Items.Clear();

			// First fill the list with results
			List<RaceResult> results = dbComm.getRaceResults(base.Game);
			List<RaceResult> sortedResults = sortResults(results);

			for (int i = 0; i < sortedResults.Count; i++)
			{
				tmpUsr = dbComm.getUser(sortedResults[i].UserId);

				lvi = new ListViewItem();
				lvi.Text = (i + 1).ToString();
				lvi.Name = (i + 1).ToString();
				lvi.Tag = tmpUsr;
				lvi.SubItems.Add(tmpUsr.firstName + " " + tmpUsr.lastName);
				lvi.SubItems.Add(tmpUsr.startNumber.ToString());
				lvi.SubItems.Add(sortedResults[i].TimeMs.ToString("0,000"));
				resultsListView.Items.Add(lvi);
				usersWithResult.Add(tmpUsr.ID);
			}


			//Now get all users for this game and check if they already have results. if not, put them in the todoList
			List<User> allUsers = dbComm.getUsersByGame(base.Game);

			foreach (User us in allUsers)
			{
				if (!usersWithResult.Contains(us.ID))
				{
					lvi = new ListViewItem();
					lvi.Text = us.firstName + " " + us.lastName;
					lvi.Name = us.firstName + " " + us.lastName;
					lvi.SubItems.Add(us.startNumber.ToString());
					lvi.Tag = us;
					todoListView.Items.Add(lvi);
				}

			}

			// Disable the Startbutton when there are no users to race
			startHeatButton.Enabled = (todoListView.Items.Count != 0);

		}



		

		private void startHeatButton_Click(object sender, EventArgs e)
		{
			finishCount = 1;
			for (int i = 0; i < displayString.Length; i++)
			{
				displayString[i] = '-';
			}

			List<User> usersToRace = new List<User>();
			RaceResult tempRes;

			if (todoListView.SelectedItems.Count != 0)
			{
				foreach (ListViewItem lvi in todoListView.SelectedItems)
				{
					usersToRace.Add((User)lvi.Tag);
				}
			}
			else
			{
				foreach (ListViewItem lvi in todoListView.Items)
				{
					usersToRace.Add((User)lvi.Tag);
				}
			}

			PerformRaceForm frm = new PerformRaceForm();

			frm.TrackFinished += new TrackFinishedEventHandler(frm_TrackFinished);

			Dictionary<User, int> raceresult = frm.performRace(usersToRace, AutoTrackPlacementModes.Sequential, true, base.CommHandler);
			frm.Dispose();
			if (raceresult != null)
			{

				List<GameRound> rnds = dbComm.getGameRoundsForGame(base.Game);

				foreach (KeyValuePair<User, int> kvp in raceresult)
				{
					tempRes = new RaceResult(0, kvp.Key.ID, rnds[0].ID, base.Game.ID, kvp.Value);
					dbComm.addRaceResult(tempRes);
				}

				fillUserLists();
			}		
		}

		void frm_TrackFinished(object sender, TrackFinishedEventArgs args)
		{
			displayString[8 - args.TrackNumber] = finishCount.ToString()[0];
			if (AllowDisplayChange)
			{
				CommHandler.setDisplayString(new String(displayString));
				AllowDisplayChange = false;
			}
			else
			{
				DisplayChangePending = true;
			}
			
			finishCount++;
		}



		private void addUserButton_Click(object sender, EventArgs e)
		{
			List<User> currentUsers = dbComm.getUsersByGame(base.Game);
			SelectUsersForm frm = new SelectUsersForm();
			List<User> newUsers = frm.getUsers(currentUsers);

			if (newUsers != null)
			{
				dbComm.addUsersToGame(base.Game, newUsers);
				fillUserLists();
			}

			frm.Dispose();
		}

		private void removeUserButton_Click(object sender, EventArgs e)
		{
			DialogResult diagRes = DialogResult.No;
			List<User> toBeRemoved = new List<User>();

			if ((todoListView.SelectedItems.Count != 0) || (resultsListView.SelectedItems.Count != 0))
			{
				diagRes = MessageBox.Show("Dit verwijdert de deelnemer(s) uit deze wedstrijd, waarbij de behaalde resultaten verloren gaan.\n\nWeet je zeker dat je dit wil?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			}

			if (diagRes == DialogResult.Yes)
			{
				foreach (ListViewItem lvi in todoListView.SelectedItems)
				{
					toBeRemoved.Add((User) lvi.Tag);
				}
				foreach (ListViewItem lvi in resultsListView.SelectedItems)
				{
					toBeRemoved.Add((User)lvi.Tag);
				}

				foreach (User us in toBeRemoved)
				{
					dbComm.removeUserFromGame(base.Game, us);
					dbComm.removeRaceResults(base.Game, us);
				}

				fillUserLists();
			}
		}

		private void resultsListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			todoListView.SelectedItems.Clear();
			if ((todoListView.SelectedItems.Count != 0) || (resultsListView.SelectedItems.Count != 0))
			{
				removeUserButton.Enabled = true;
			}
			else
			{
				removeUserButton.Enabled = false;
			}

			if (resultsListView.SelectedItems.Count != 0)
			{
				clearResultButton.Enabled = true;
			}
			else
			{
				clearResultButton.Enabled = false;
			}
		}

		private void todoListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			resultsListView.SelectedItems.Clear();

			if ((todoListView.SelectedItems.Count != 0) || (resultsListView.SelectedItems.Count != 0))
			{
				removeUserButton.Enabled = true;
			}
			else
			{
				removeUserButton.Enabled = false;
			}

			if (resultsListView.SelectedItems.Count != 0)
			{
				clearResultButton.Enabled = true;
			}
			else
			{
				clearResultButton.Enabled = false;
			}
		}

		private void clearResultButton_Click(object sender, EventArgs e)
		{
			if (resultsListView.SelectedItems.Count != 0)
			{

				DialogResult diagRes = DialogResult.No;

				diagRes = MessageBox.Show("Hierdoor wordt de tijdsmeting van de geselecteerde deelnemer(s) definitief verwijderd.\n\nWeet je zeker dat je dit wil?", "Resultaat wissen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

				if (diagRes == DialogResult.Yes)
				{
					foreach (ListViewItem lvi in resultsListView.SelectedItems)
					{
						dbComm.removeRaceResults(base.Game, (User)lvi.Tag);
					}

					fillUserLists();

				}

			}
		}

		private void saveScoresButton_Click(object sender, EventArgs e)
		{
			List<RaceResult> sortedResults = sortResults(dbComm.getRaceResults(base.Game));
			List<User> allUsers = dbComm.getUsersByGame(base.Game);
			Dictionary<int, User> usersById = new Dictionary<int, User>();

			foreach(User us in allUsers)
			{
				usersById.Add(us.ID, us);
			}

			String path = FileWriter.saveTimeTrialResults(base.Game, usersById, sortedResults);

			if (path != "")
			{

				DialogResult res = MessageBox.Show("Resultaat opgeslagen in:\n" + path + "\n\nNu openen?", "Opgeslagen", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (res == DialogResult.Yes)
				{
					System.Diagnostics.Process.Start(path);
				}
			}
			else
			{
				MessageBox.Show("Fout tijdens opslaan", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

	}

}

