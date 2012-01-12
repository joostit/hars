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
	/// <summary>
	/// Creates a new HARgame
	/// </summary>
	public partial class NewGameForm : Form
	{

		/// <summary>
		/// Return value
		/// </summary>
		private HARGame retVal = new HARGame();


		/// <summary>
		/// Constructor
		/// </summary>
		public NewGameForm()
		{
			retVal.GameState = GameStates.Playing;

			InitializeComponent();
		}


		/// <summary>
		/// Gets a new game from user input
		/// </summary>
		/// <returns>a new HAR game, or null if the action was cancelled</returns>
		public HARGame createNewGame()
		{

			this.ShowDialog();


			return retVal;
		}


		private void NewGameForm_Load(object sender, EventArgs e)
		{
			timeLapsButton.Checked = true;
			retVal.GameType = GameTypes.TimeTrial;
		}

		private void nameBox_Validated(object sender, EventArgs e)
		{
			retVal.GameName = nameBox.Text.Trim();
			nameBox.Text = retVal.GameName;
		}

		private void typeButton_CheckedChanged(object sender, EventArgs e)
		{
			if (timeLapsButton.Checked)
			{
				retVal.GameType = GameTypes.TimeTrial;
			}
			if(leagueButton.Checked)
			{
				retVal.GameType = GameTypes.ChampionsLeague;
			}
		}


		private void okButton_Click(object sender, EventArgs e)
		{

			List<HARGame> tmpList;
			Boolean gameExists = false;

			if (retVal.GameName.Trim() == "")
			{
				MessageBox.Show("Voer een geldige wedstrijdnaam in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				tmpList = dbComm.getGames();

				foreach (HARGame hg in tmpList)
				{
					if (hg.GameName == retVal.GameName)
					{
						gameExists = true;
					}
				}

				if (gameExists)
				{
					MessageBox.Show("Er bestaat al een wedstrijd met deze naam.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					this.Close();
				}
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			retVal = null;
			this.Close();
		}

	}
}
