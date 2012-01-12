using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using BrrrBayBay.HARs.dataModel;

namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Form that shows all users and groups
	/// </summary>
	public partial class UsersForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public UsersForm()
		{
			InitializeComponent();
		}

		private void UsersForm_Load(object sender, EventArgs e)
		{
			loadGroupData();
			editUserButton.Enabled = false;
			deleteUserButton.Enabled = false;

			deleteGroupButton.Enabled = false;
			editGroupButton.Enabled = false;
		}


		private void loadGroupData()
		{
			groupsListView.Items.Clear();

			List<Group> groups = dbComm.getGroups();
			List<User> tempUserList;

			foreach (Group gp in groups)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Name = gp.Name;
				lvi.Text = gp.Name;
				lvi.Tag = gp;
				tempUserList = dbComm.getUsersByGroup(gp.ID);
				lvi.SubItems.Add(tempUserList.Count.ToString());
				groupsListView.Items.Add(lvi);
			}

			groupsListView.SelectedItems.Clear();
			groupsListView_SelectedIndexChanged(null, null);
			

		}


		private void reloadUserList()
		{
			List<User> ul;

			usersListView.Items.Clear();
			foreach (ListViewItem lvi in groupsListView.SelectedItems)
			{
				ul = dbComm.getUsersByGroup(((Group)lvi.Tag).ID);


				foreach (User us in ul)
				{
					ListViewItem ulvi = new ListViewItem();
					ulvi.Name = us.ID.ToString();
					ulvi.Text = us.firstName + " " + us.lastName;
					ulvi.SubItems.Add(us.startNumber.ToString());
					ulvi.SubItems.Add(us.carWeight.ToString());
					ulvi.Tag = us;
					usersListView.Items.Add(ulvi);
				}
			}
		}


		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void groupsListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			reloadUserList();
			usersListView.SelectedItems.Clear();
			usersListView_SelectedIndexChanged(null, null);

			if (groupsListView.SelectedItems.Count == 0)
			{
				editGroupButton.Enabled = false;
				deleteGroupButton.Enabled = false;
			}
			else
			{
				deleteGroupButton.Enabled = true;
				if (groupsListView.SelectedItems.Count == 1)
				{
					editGroupButton.Enabled = true;
				}
				else
				{
					editGroupButton.Enabled = false;
				}

			}


		}


		private void groupsListView_DoubleClick(object sender, EventArgs e)
		{
			if (groupsListView.SelectedItems.Count == 1)
			{
				editSelectedGroup();
			}
		}

		private void usersListView_DoubleClick(object sender, EventArgs e)
		{
			editSelectedUser();
		}

		private void editSelectedUser()
		{
			User us = null;
			if (usersListView.SelectedItems.Count == 1)
			{
				EditUserForm frm = new EditUserForm();
				us = frm.OpenForm((User)usersListView.SelectedItems[0].Tag, dbComm.getGroups());
				frm.Dispose();
				if (us != null)
				{
					dbComm.editUser(us);
					loadGroupData();
					reloadUserList();
				}


			}
		}

		private void addUserButton_Click(object sender, EventArgs e)
		{
			EditUserForm frm = new EditUserForm();
			User us = frm.OpenForm(null, dbComm.getGroups());
			frm.Dispose();

			if (us != null)
			{

				dbComm.addNewUserToDb(us);
				loadGroupData();
				reloadUserList();
			}
		}

		private void editUserButton_Click(object sender, EventArgs e)
		{
			editSelectedUser();
		}

		private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (usersListView.SelectedItems.Count == 0)
			{
				editUserButton.Enabled = false;
				deleteUserButton.Enabled = false;
			}
			else
			{
				deleteUserButton.Enabled = true;
				if (usersListView.SelectedItems.Count == 1)
				{
					editUserButton.Enabled = true;
				}
				else
				{
					editUserButton.Enabled = false;
				}
				
			}
		}

		private void deleteUserButton_Click(object sender, EventArgs e)
		{
			DialogResult diagRes = MessageBox.Show("De geselecteerde gebruiker(s) word(en) verwijderd.\n\nWeet je zeker dat je dit wilt?", "Geselecteerde gebruikers verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (diagRes == DialogResult.Yes)
			{
				foreach (ListViewItem lvi in usersListView.SelectedItems)
				{
					dbComm.deleteUser((User)lvi.Tag);
				}
				loadGroupData();
				reloadUserList();
			}
		}

		private void printUserButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dit werkt nog niet...\n\n\n(Deze knop zit er alleen voor de sier)", "Under construction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void deleteGroupButton_Click(object sender, EventArgs e)
		{
			List<User> tempUserList;
			Group tempGroup;
			int nSel = groupsListView.SelectedItems.Count;

			if (nSel != 0)
			{

				DialogResult diagRes = MessageBox.Show("De " + nSel.ToString() + " groep(en) worden hierdoor verwijderd.\n\nWeet je zeker dat je dit wilt?", "Geselecteerde groepen verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (diagRes == DialogResult.Yes)
				{
					foreach (ListViewItem lvi in groupsListView.SelectedItems)
					{
						tempGroup = (Group)lvi.Tag;
						tempUserList = dbComm.getUsersByGroup(tempGroup.ID);

						if (tempUserList.Count != 0)
						{
							MessageBox.Show("De groep '" + tempGroup.Name + "' bevat deelnemers en kan daarom niet worden verwijderd.", "Kan groep niet verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else
						{
							dbComm.deleteGroup(tempGroup);
						}
					}

					loadGroupData();
					reloadUserList();

				}
			}
		}


		private void editSelectedGroup()
		{
			Group gr = null;
			if (groupsListView.SelectedItems.Count == 1)
			{
				EditGroupForm frm = new EditGroupForm();
				gr = frm.openForm((Group)groupsListView.SelectedItems[0].Tag, dbComm.getGroups());
				frm.Dispose();
				if (gr != null)
				{
					dbComm.editGroup(gr);
					loadGroupData();
					reloadUserList();
				}


			}
		}


		private void editGroupButton_Click(object sender, EventArgs e)
		{
			editSelectedGroup();
		}

		private void newGroupButton_Click(object sender, EventArgs e)
		{
			Group gr = null;
			EditGroupForm frm = new EditGroupForm();
			gr = frm.openForm(null, dbComm.getGroups());
			frm.Dispose();

			if (gr != null)
			{
				dbComm.addGroup(gr);
				loadGroupData();
				reloadUserList();
			}


		}

		private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}


		
	}
}
