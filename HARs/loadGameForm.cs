using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrrrBayBay.HARs.dataModel;

namespace BrrrBayBay.HARs
{
	public partial class loadGameForm : Form
	{

		HARGame retVal = null;

		/// <summary>
		/// Constructor
		/// </summary>
		public loadGameForm()
		{
			InitializeComponent();
		}



		private void loadGameForm_Load(object sender, EventArgs e)
		{
			List<HARGame> availableGames = dbComm.getGames();
			ListViewItem lvi;

			foreach (HARGame gm in availableGames)
			{
				lvi = new ListViewItem();
				lvi.Name = gm.GameName;
				lvi.Text = gm.GameName;
				lvi.Tag = gm;

				switch (gm.GameState)
				{
					case GameStates.NotStarted:
						lvi.SubItems.Add("Niet begonnen");
						break;
					case GameStates.Playing:
						lvi.SubItems.Add("Begonnen");
						break;
					case GameStates.Finished:
						lvi.SubItems.Add("Klaar");
						break;
					default:
						break;
				}


				gamesListView.Items.Add(lvi);
			}

		}



		private void okButton_Click(object sender, EventArgs e)
		{
			if (gamesListView.SelectedItems.Count == 1)
			{
				retVal = (HARGame)gamesListView.SelectedItems[0].Tag;
				this.Close();
			}
			else
			{
				MessageBox.Show("Selecteer een wedstrijd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Shows the form and returns the game that was selected by the user
		/// </summary>
		/// <returns>The selected game, or null if the action was cancelled</returns>
		public HARGame loadGame()
		{


			this.ShowDialog();


			return retVal;
		}



		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gamesListView.SelectedItems.Count == 1)
			{
				okButton.Enabled = true;
			}
			else
			{
				okButton.Enabled = false;
			}
		}



		private void gamesListView_DoubleClick(object sender, EventArgs e)
		{

			if (gamesListView.SelectedItems.Count == 1)
			{
				retVal = (HARGame)gamesListView.SelectedItems[0].Tag;
				this.Close();
			}
		}
	}
}
