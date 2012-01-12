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
	public partial class EditUserForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public EditUserForm()
		{
			InitializeComponent();
		}


		User retVal;
		List<Group> groupsList = new List<Group>();


		/// <summary>
		/// Opens the form. 
		/// </summary>
		/// <param name="user">a User object to be edited, or null if a new user is created. May be null if a new user is created</param>
		/// <param name="availableGroups">a list of available groups</param>
		/// <returns>null if the action was cancelled, or a user object</returns>
		public User OpenForm(User user, List<Group> availableGroups)
		{
			if (user != null)
			{
				this.Text = "Deelnemersgegevens wijzigen";
				retVal = user;
			}
			else
			{
				retVal = new User();
				this.Text = "Nieuwe deelnemer";
			}

			groupsList = availableGroups;

			this.ShowDialog();

			return retVal;

		}


		private void EditUserForm_Load(object sender, EventArgs e)
		{
			startNumberBox.Text = retVal.startNumber.ToString();
			firstNameBox.Text = retVal.firstName;
			lastNameBox.Text = retVal.lastName;
			carWeightBox.Text = retVal.carWeight.ToString();

			Group selGrp = null;

			foreach (Group gr in groupsList)
			{
				if (gr.ID == retVal.grp) selGrp = gr;
				groupsBox.Items.Add(gr.Name);
			}

			if (selGrp != null)
			{
				groupsBox.SelectedItem = selGrp.Name;
			}

			
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			retVal = null;
			this.Close();
		}
		



		private void okButton_Click(object sender, EventArgs e)
		{

			Boolean ok = true;

			if (retVal.grp == 0)	ok = false;

			if (retVal.firstName.Trim() == "") ok = false;

			if (retVal.lastName.Trim() == "") ok = false;

			if (retVal.startNumber == 0) ok = false;

			if(retVal.carWeight == 0) ok = false;

			
			if(ok)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("Een van de velden is niet goed ingevuld!", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		private void validateTexboxInt(object sender, CancelEventArgs e)
		{
			TextBox tb = (TextBox) sender;
			try
			{
				Convert.ToInt32(tb.Text);
				tb.BackColor = Color.Empty;
			}
			catch
			{
				tb.BackColor = Color.Orange;
				e.Cancel = true;			
			}
		}

		private void startNumberBox_Validated(object sender, EventArgs e)
		{
			retVal.startNumber = Convert.ToInt32( startNumberBox.Text );
		}

		private void carWeightBox_Validated(object sender, EventArgs e)
		{
			retVal.carWeight = Convert.ToInt32(carWeightBox.Text);
		}

		private void firstNameBox_Validated(object sender, EventArgs e)
		{
			retVal.firstName = firstNameBox.Text;
		}

		private void lastNameBox_Validated(object sender, EventArgs e)
		{
			retVal.lastName = lastNameBox.Text;
		}

		private void checkTextNotEmpty(object sender, CancelEventArgs e)
		{
			TextBox tb = (TextBox) sender;

			if(tb.Text.Trim() == "")
			{
				tb.BackColor = Color.Orange;
				e.Cancel= true;
			} 
			else
			{
				tb.BackColor = Color.Empty;
			}
		}

		private void groupsBox_Validated(object sender, EventArgs e)
		{
			int grpId =0;

			if (groupsBox.SelectedItem != null)
			{

				foreach (Group gr in groupsList)
				{
					if (gr.Name.Trim() == ((String)groupsBox.SelectedItem).Trim())
					{
						grpId = gr.ID;
					}

				}
			}
			retVal.grp = grpId;
		}

	}
}
