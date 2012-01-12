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
using System.Threading;

namespace BrrrBayBay.HARs
{
    public partial class HARsMainForm : Form
    {

		SerialSpriteCommHandler commHandler = null;

		/// <summary>
		/// Constructor
		/// </summary>
        public HARsMainForm()
        {
            InitializeComponent();
        }

		GameControl ctrl = null;

        private void HARsMainForm_Load(object sender, EventArgs e)
        {

        }

		private void testButton_Click(object sender, EventArgs e)
		{
			
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UsersForm frm = new UsersForm();
			frm.ShowDialog();
			frm.Dispose();
		}

		private void HARsMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult diagRes = MessageBox.Show("Weet je zeker dat je HARs wil afsluiten", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (diagRes == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			abouHARsForm frm = new abouHARsForm();
			frm.ShowDialog();
			frm.Dispose();
		}

		private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			loadGameForm frm = new loadGameForm();

			HARGame loaded = frm.loadGame();
			frm.Dispose();

			if (loaded != null)
			{
				openGame(loaded);
			}

		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewGameForm frm = new NewGameForm();
			HARGame gm = frm.createNewGame();
			List<User> uList = null;

			frm.Dispose();

			if (gm != null)
			{
				if (gm.GameType == GameTypes.ChampionsLeague)
				{
					MessageBox.Show("Selecteer in het volgende scherm de deelnemers voor deze wedstrijd. Er moeten minimaals acht deelnemers meedoen.\n\nLet op: Nadat de wedstrijd is aangemaakt kunnen er geen deelnemers meer worden toegevoegd of verwijderd!", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				SelectUsersForm usrFrm = new SelectUsersForm();
				uList = usrFrm.getUsers();
				usrFrm.Dispose();

				if (uList != null)
				{
					if ((gm.GameType == GameTypes.ChampionsLeague) && (uList.Count < 8))
					{
						MessageBox.Show("Er zijn te weinig deelnemers geselecteerd. De wedstrijd is niet aangemaakt.", "Geen wedstrijd aangemaakt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						gm = dbComm.addGame(gm);
						dbComm.addUsersToGame(gm, uList);
						GameScheduler.createGameSchedule(gm);

						openGame(gm);
					}
				}
				else
				{
					MessageBox.Show("Er zijn geen deelnemers geselecteerd. De wedstrijd is niet aangemaakt.", "Geen wedstrijd aangemaakt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

			}

		}


		private void openGame(HARGame game)
		{
			stopGameToolStripMenuItem.Enabled = true;
			newGameToolStripMenuItem.Enabled = false;
			openGameToolStripMenuItem.Enabled = false;

			if (Properties.Settings.Default.spriteCommEnabled)
			{
				commHandler = new SerialSpriteCommHandler();
				commHandler.PortName = Properties.Settings.Default.com_port;
				commHandler.Parity = Properties.Settings.Default.com_parity;
				commHandler.BaudRate = Properties.Settings.Default.com_baud;
				commHandler.DataBits = Properties.Settings.Default.com_dataBits;
				commHandler.StopBits = Properties.Settings.Default.com_stopBits;

				commHandler.connect();
				Thread.Sleep(200);
				commHandler.resetController();
				Thread.Sleep(500);
				commHandler.setDisplayString(commHandler.DefaultDisplayString);
				Thread.Sleep(50);
			}

			switch (game.GameType)
			{
				case GameTypes.TimeTrial:
					ctrl = new TimeTrialControl(game, commHandler);
					break;

				case GameTypes.ChampionsLeague:
					ctrl = new LeagueControl(game, commHandler);
					break;
			}
			mainContentPanel.Controls.Add(ctrl);

		}


		private void stopGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult diagRes = MessageBox.Show("Weet je zeker dat je deze wedstrijd wil stoppen?\n\n(Deze kan op een later tijdstip worden voortgezet)", "Stoppen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (diagRes == DialogResult.Yes)
			{
				newGameToolStripMenuItem.Enabled = true;
				openGameToolStripMenuItem.Enabled = true;
				stopGameToolStripMenuItem.Enabled = false;
				mainContentPanel.Controls.Remove(ctrl);
				try
				{
					ctrl.Dispose();
				}
				catch { }

				if (Properties.Settings.Default.spriteCommEnabled)
				{
					if (commHandler != null)
					{
						commHandler.disconnect();
						commHandler = null;
					}
				}

			}
			else
			{

			}
		}

		private void mainContentPanel_Paint(object sender, PaintEventArgs e)
		{

		}

    }
}
