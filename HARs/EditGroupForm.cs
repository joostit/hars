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
	public partial class EditGroupForm : Form
	{

		Group retVal = null;
		List<Group> grpList;

		/// <summary>
		/// Constructor
		/// </summary>
		public EditGroupForm()
		{
			InitializeComponent();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			retVal = null;
			this.Close();
		}


		/// <summary>
		/// Opens the edit group form
		/// </summary>
		/// <param name="grp">the group to be edited, or null if a new group is required</param>
		/// <param name="availableGroups">The available groups</param>
		/// <returns>The group, or null if cancelled</returns>
		public Group openForm(Group grp, List<Group> availableGroups)
		{
			retVal = grp;
			grpList = availableGroups;
			int? inx = null;

			if (grp != null)
			{
				this.Text = "Groepsnaam wijzigen";
				foreach (Group gr in grpList)
				{
					if (gr.Name == grp.Name)
					{
						inx = grpList.IndexOf(gr);
					}
				}

				if (inx != null)
				{
					grpList.RemoveAt(inx.Value);
				}
			}
			else
			{
				this.Text = "Nieuwe groep";
				retVal = new Group();
			}

			this.ShowDialog();

			return retVal;
		}


		private void okButton_Click(object sender, EventArgs e)
		{
			if (retVal.Name.Trim() == "")
			{
				MessageBox.Show("Vul een groepsnaam in", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Boolean unique = true;

				foreach (Group gr in grpList)
				{
					if (gr.Name.Trim() == retVal.Name.Trim())
					{
						unique = false;
					}
				}

				if (unique == true)
				{
					this.Close();
				}
				else
				{
					MessageBox.Show("De opgegeven groepsnaam bestaat al!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


				
			}
			
		}

		private void textBox1_Validated(object sender, EventArgs e)
		{
			retVal.Name = nameBox.Text;
		}

		private void EditGroupForm_Load(object sender, EventArgs e)
		{
			if (retVal != null)
			{
				nameBox.Text = retVal.Name;
			}
			nameBox.Focus();
		}
	}
}
