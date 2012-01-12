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
	public partial class TrackLayoutControl : UserControl
	{


		public Boolean TrackEnabled
		{
			get
			{
				return enabledBox.Checked;
			}
			set
			{
				enabledBox.Checked = value;
			}
		}

		/// <summary>
		/// Gets or sets the selectedUser
		/// </summary>
		public User SelectedUser
		{
			get
			{
				try
				{
					return users[Convert.ToInt32(startNumberBox.Text.Trim())];
				}
				catch
				{
					return null;
				}
			}
			set
			{
				if (value != null)
				{
					startNumberBox.Text = value.startNumber.ToString();
				}
			}
		}

		public TrackLayoutControl()
		{
			InitializeComponent();
		}


		private Dictionary<int, User> users = new Dictionary<int,User>();

		public void init(int trackNumber, List<User> availableUsers)
		{
			trackGroup.Text = "Baan " + trackNumber.ToString();

			startNumberBox.Items.Clear();
			foreach (User us in availableUsers)
			{
				if (us != null)
				{
					startNumberBox.Items.Add(us.startNumber);
					users.Add(us.startNumber, us);
				}
			}

		}

		/// <summary>
		/// Checks if a valid selection is made. TrackEnabled will be set to false when not.
		/// </summary>
		public void checkSelection()
		{
			if (SelectedUser == null)
			{
				TrackEnabled = false;
			}
		}

		/// <summary>
		/// Locks this track
		/// </summary>
		public void lockControl()
		{
			enabledBox.Enabled = false;
			startNumberBox.Enabled = false;
			if (enabledBox.Checked == false)
			{
				startNumberBox.Visible = false;
				trackGroup.Text = "";
				enabledBox.Visible = false;

			}
		}


		public void setReadOnly()
		{
			enabledBox.Enabled = false;
			startNumberBox.Enabled = false;
		}



		private void TrackLayoutControl_Load(object sender, EventArgs e)
		{

		}

		private void enabledBox_CheckedChanged(object sender, EventArgs e)
		{
			if (enabledBox.Checked == false)
			{
				firstNameLabel.Text = "";
				lastNameLabel.Text = "";
				startNumberBox.Enabled = false;
			}
			else
			{
				startNumberBox.Enabled = true;
				try
				{
					int id = Convert.ToInt32(startNumberBox.Text.Trim());
					firstNameLabel.Text = users[id].firstName;
					lastNameLabel.Text = users[id].lastName;
				}
				catch
				{
					firstNameLabel.Text = "";
					lastNameLabel.Text = "";
				}
			}
		}

		private void startNumberBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(startNumberBox.Text.Trim());
				firstNameLabel.Text = users[id].firstName;
				lastNameLabel.Text = users[id].lastName;
			}
			catch
			{
				firstNameLabel.Text = "";
				lastNameLabel.Text = "";
				enabledBox.Checked = false;
			}
		}
	}
}
