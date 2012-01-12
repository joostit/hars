using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrrrBayBay.HARs.dataModel;
using System.Collections;

namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Allows the operator to select users for the game
	/// </summary>
	public partial class SelectUsersForm : Form
	{
		Dictionary<int, User> excludeList = new Dictionary<int, User>();
		List<User> retVal = null;

		/// <summary>
		/// Constructor
		/// </summary>
		public SelectUsersForm()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Allows the operator to select users
		/// </summary>
		/// <returns>a list with users, or null if the action was cancelled</returns>
		public List<User> getUsers()
		{

			this.ShowDialog();


			return retVal;
		}


		/// <summary>
		/// Allows the operator to select users
		/// </summary>
		/// <param name="excludeList">a List with users that should be exluded from the search</param>
		/// <returns>a list with users, or null if the action was cancelled</returns>
		public List<User> getUsers(List<User> excludeList)
		{
			foreach (User us in excludeList)
			{
				this.excludeList.Add(us.ID, us);
			}

			return getUsers();
		}


		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SelectUsersForm_Load(object sender, EventArgs e)
		{
			loadGroups();
		}


		private void loadGroups()
		{
			List<Group> grps = dbComm.getGroups();
			ListViewItem lvi = null;
			groupsListView.Items.Clear();
			int userCount = 0;

			List<User> uList;

			foreach (Group gr in grps)
			{
				uList = dbComm.getUsersByGroup(gr.ID);
				userCount = uList.Count;
				foreach (User us in uList)
				{
					if (excludeList.ContainsKey(us.ID))
					{
						userCount--;
					}
				}

				if (userCount > 0)
				{
					lvi = new ListViewItem();
					lvi.Name = gr.Name;
					lvi.Text = gr.Name;
					lvi.Tag = gr;
					groupsListView.Items.Add(lvi);
				}
			}
		}

		private void groupsListView_SelectedIndexChanged(object sender, EventArgs e)
		{

			usersListView.Items.Clear();
			ListViewItem lvi = null;
			List<User> uList;

			if (groupsListView.SelectedItems.Count == 0)
			{
				addGroupButton.Enabled = false;
			}
			else
			{
				addGroupButton.Enabled = true;
			}


			foreach (ListViewItem ulvi in groupsListView.SelectedItems)
			{
				uList = dbComm.getUsersByGroup(((Group)ulvi.Tag).ID);

				foreach (User us in uList)
				{
					if (!excludeList.ContainsKey(us.ID))
					{
						lvi = new ListViewItem();
						lvi.Name = us.firstName + " " + us.lastName;
						lvi.Text = us.firstName + " " + us.lastName;
						lvi.SubItems.Add(us.startNumber.ToString());
						lvi.SubItems.Add(us.grpName);
						lvi.Tag = us;
						usersListView.Items.Add(lvi);
					}
				}


			}
		}


		private void addGroupButton_Click(object sender, EventArgs e)
		{
			List<User> uList;


			foreach (ListViewItem ulvi in groupsListView.SelectedItems)
			{
				uList = dbComm.getUsersByGroup(((Group)ulvi.Tag).ID);

				foreach (User us in uList)
				{
					if (!excludeList.ContainsKey(us.ID))
					{
						ListViewItem lvi;
						lvi = new ListViewItem();
						lvi.Name = us.firstName + " " + us.lastName;
						lvi.Text = us.firstName + " " + us.lastName;
						lvi.SubItems.Add(us.startNumber.ToString());
						lvi.SubItems.Add(us.grpName);
						lvi.Tag = us;
						selectionListView.Items.Add(lvi);
						excludeList.Add(us.ID, us);
					}
				}

			}
			loadGroups();
			updateSelectionCount();
			groupsListView_SelectedIndexChanged(this, null);
			usersListView.SelectedItems.Clear();
			usersListView_SelectedIndexChanged(this, null);
		}


		private void updateSelectionCount()
		{
			numUsersLabel.Text = selectionListView.Items.Count.ToString();
		}

		private void addUserButton_Click(object sender, EventArgs e)
		{
			User tUsr = null;
			ListViewItem newLvi = null;
			List<ListViewItem> remove = new List<ListViewItem>();


			if (usersListView.SelectedItems.Count == 0)
			{
				addUserButton.Enabled = false;
			}
			else
			{
				addUserButton.Enabled = true;
			}


			foreach (ListViewItem lvi in usersListView.SelectedItems)
			{
				tUsr = (User)lvi.Tag;
				newLvi = new ListViewItem();
				newLvi.Text = tUsr.firstName + " " + tUsr.lastName;
				newLvi.Name = tUsr.firstName + " " + tUsr.lastName;
				newLvi.Tag = tUsr;
				newLvi.SubItems.Add(tUsr.startNumber.ToString());
				newLvi.SubItems.Add(tUsr.grpName);

				selectionListView.Items.Add(newLvi);
				excludeList.Add(tUsr.ID, tUsr);
				remove.Add(lvi);
			}

			foreach (ListViewItem lvi in remove)
			{
				usersListView.Items.Remove(lvi);
			}

			updateSelectionCount();
			usersListView.SelectedItems.Clear();

			if (usersListView.Items.Count == 0)
			{
				loadGroups();
				groupsListView_SelectedIndexChanged(this, null);
				usersListView_SelectedIndexChanged(this, null);
			}

		}

		private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (usersListView.SelectedItems.Count == 0)
			{
				addUserButton.Enabled = false;
			}
			else
			{
				addUserButton.Enabled = true;
			}
		}

		private void removeUserButton_Click(object sender, EventArgs e)
		{
			List<ListViewItem> remove = new List<ListViewItem>();
			foreach (ListViewItem lvi in selectionListView.SelectedItems)
			{
				remove.Add(lvi);
			}

			foreach (ListViewItem lvi in remove)
			{
				selectionListView.Items.Remove(lvi);
				excludeList.Remove(((User)lvi.Tag).ID);
			}

			loadGroups();
			selectionListView.SelectedItems.Clear();
			selectionListView_SelectedIndexChanged(this, null);
			groupsListView_SelectedIndexChanged(this, null);
			updateSelectionCount();
		}

		private void selectionListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (selectionListView.SelectedItems.Count == 0)
			{
				removeUserButton.Enabled = false;
			}
			else
			{
				removeUserButton.Enabled = true;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (selectionListView.Items.Count == 0)
			{
				MessageBox.Show("Er zijn geen gebruikers geselecteerd.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				// Check for duplicate startNumbers
				List<int> sn = new List<int>();
				foreach (ListViewItem lvi in selectionListView.Items)
				{
					User tmp = (User)lvi.Tag;
					if (sn.Contains(tmp.startNumber))
					{
						MessageBox.Show("Het startnummer " + tmp.startNumber.ToString() + " komt meerdere keren voor binnen deze wedstrijd.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						sn.Add(tmp.startNumber);
					}
				}


				retVal = new List<User>();
				foreach (ListViewItem lvi in selectionListView.Items)
				{
					User tmp = (User)lvi.Tag;
					retVal.Add(tmp);
				}
				this.Close();
			}
		}

		private void usersListView_DoubleClick(object sender, EventArgs e)
		{
			addUserButton_Click(this, null);
		}

		private void groupsListView_DoubleClick(object sender, EventArgs e)
		{
			addGroupButton_Click(this, null);
		}

		private void selectionListView_DoubleClick(object sender, EventArgs e)
		{
			removeUserButton_Click(this, null);
		}

		private void usersListView_Enter(object sender, EventArgs e)
		{

			addGroupButton.Enabled = false;
			addUserButton.Enabled = true;
			removeUserButton.Enabled = false;
		}

		private void groupsListView_Enter(object sender, EventArgs e)
		{
			addGroupButton.Enabled = true;
			addUserButton.Enabled = false;
			removeUserButton.Enabled = false;
		}

		private void selectionListView_Enter(object sender, EventArgs e)
		{
			removeUserButton.Enabled = true;
			addGroupButton.Enabled = false;
			addUserButton.Enabled = false;

		}


	}
}
