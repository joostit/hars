namespace BrrrBayBay.HARs
{
	partial class UsersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupsGroup = new System.Windows.Forms.GroupBox();
			this.deleteGroupButton = new System.Windows.Forms.Button();
			this.editGroupButton = new System.Windows.Forms.Button();
			this.newGroupButton = new System.Windows.Forms.Button();
			this.groupsListView = new System.Windows.Forms.ListView();
			this.groupColumn = new System.Windows.Forms.ColumnHeader();
			this.nUsersColumn = new System.Windows.Forms.ColumnHeader();
			this.addUserButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.printUserButton = new System.Windows.Forms.Button();
			this.deleteUserButton = new System.Windows.Forms.Button();
			this.editUserButton = new System.Windows.Forms.Button();
			this.usersListView = new System.Windows.Forms.ListView();
			this.fullNameColumn = new System.Windows.Forms.ColumnHeader();
			this.startNumberColumn = new System.Windows.Forms.ColumnHeader();
			this.carWeightCOlumn = new System.Windows.Forms.ColumnHeader();
			this.closeButton = new System.Windows.Forms.Button();
			this.groupsGroup.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupsGroup
			// 
			this.groupsGroup.Controls.Add(this.deleteGroupButton);
			this.groupsGroup.Controls.Add(this.editGroupButton);
			this.groupsGroup.Controls.Add(this.newGroupButton);
			this.groupsGroup.Controls.Add(this.groupsListView);
			this.groupsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupsGroup.Location = new System.Drawing.Point(12, 12);
			this.groupsGroup.Name = "groupsGroup";
			this.groupsGroup.Size = new System.Drawing.Size(259, 454);
			this.groupsGroup.TabIndex = 0;
			this.groupsGroup.TabStop = false;
			this.groupsGroup.Text = "Groepen";
			// 
			// deleteGroupButton
			// 
			this.deleteGroupButton.Location = new System.Drawing.Point(6, 425);
			this.deleteGroupButton.Name = "deleteGroupButton";
			this.deleteGroupButton.Size = new System.Drawing.Size(75, 23);
			this.deleteGroupButton.TabIndex = 3;
			this.deleteGroupButton.Text = "Verwijderen";
			this.deleteGroupButton.UseVisualStyleBackColor = true;
			this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
			// 
			// editGroupButton
			// 
			this.editGroupButton.Location = new System.Drawing.Point(97, 425);
			this.editGroupButton.Name = "editGroupButton";
			this.editGroupButton.Size = new System.Drawing.Size(75, 23);
			this.editGroupButton.TabIndex = 2;
			this.editGroupButton.Text = "Bewerken";
			this.editGroupButton.UseVisualStyleBackColor = true;
			this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
			// 
			// newGroupButton
			// 
			this.newGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newGroupButton.Location = new System.Drawing.Point(178, 425);
			this.newGroupButton.Name = "newGroupButton";
			this.newGroupButton.Size = new System.Drawing.Size(75, 23);
			this.newGroupButton.TabIndex = 1;
			this.newGroupButton.Text = "Nieuw";
			this.newGroupButton.UseVisualStyleBackColor = true;
			this.newGroupButton.Click += new System.EventHandler(this.newGroupButton_Click);
			// 
			// groupsListView
			// 
			this.groupsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.groupColumn,
            this.nUsersColumn});
			this.groupsListView.FullRowSelect = true;
			this.groupsListView.HideSelection = false;
			this.groupsListView.Location = new System.Drawing.Point(6, 19);
			this.groupsListView.Name = "groupsListView";
			this.groupsListView.Size = new System.Drawing.Size(247, 400);
			this.groupsListView.TabIndex = 0;
			this.groupsListView.UseCompatibleStateImageBehavior = false;
			this.groupsListView.View = System.Windows.Forms.View.Details;
			this.groupsListView.SelectedIndexChanged += new System.EventHandler(this.groupsListView_SelectedIndexChanged);
			this.groupsListView.DoubleClick += new System.EventHandler(this.groupsListView_DoubleClick);
			// 
			// groupColumn
			// 
			this.groupColumn.Text = "GroepsNaam";
			this.groupColumn.Width = 164;
			// 
			// nUsersColumn
			// 
			this.nUsersColumn.Text = "Deelnemers";
			this.nUsersColumn.Width = 71;
			// 
			// addUserButton
			// 
			this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addUserButton.Location = new System.Drawing.Point(651, 472);
			this.addUserButton.Name = "addUserButton";
			this.addUserButton.Size = new System.Drawing.Size(129, 23);
			this.addUserButton.TabIndex = 1;
			this.addUserButton.Text = "&Nieuwe deelnemer";
			this.addUserButton.UseVisualStyleBackColor = true;
			this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.printUserButton);
			this.groupBox1.Controls.Add(this.deleteUserButton);
			this.groupBox1.Controls.Add(this.editUserButton);
			this.groupBox1.Controls.Add(this.usersListView);
			this.groupBox1.Location = new System.Drawing.Point(294, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(573, 454);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Deelnemers";
			// 
			// printUserButton
			// 
			this.printUserButton.Location = new System.Drawing.Point(6, 425);
			this.printUserButton.Name = "printUserButton";
			this.printUserButton.Size = new System.Drawing.Size(75, 23);
			this.printUserButton.TabIndex = 4;
			this.printUserButton.Text = "Afdrukken";
			this.printUserButton.UseVisualStyleBackColor = true;
			this.printUserButton.Click += new System.EventHandler(this.printUserButton_Click);
			// 
			// deleteUserButton
			// 
			this.deleteUserButton.Location = new System.Drawing.Point(411, 425);
			this.deleteUserButton.Name = "deleteUserButton";
			this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
			this.deleteUserButton.TabIndex = 3;
			this.deleteUserButton.Text = "&Verwijderen";
			this.deleteUserButton.UseVisualStyleBackColor = true;
			this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
			// 
			// editUserButton
			// 
			this.editUserButton.Location = new System.Drawing.Point(492, 425);
			this.editUserButton.Name = "editUserButton";
			this.editUserButton.Size = new System.Drawing.Size(75, 23);
			this.editUserButton.TabIndex = 2;
			this.editUserButton.Text = "B&ewerken";
			this.editUserButton.UseVisualStyleBackColor = true;
			this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
			// 
			// usersListView
			// 
			this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullNameColumn,
            this.startNumberColumn,
            this.carWeightCOlumn});
			this.usersListView.FullRowSelect = true;
			this.usersListView.Location = new System.Drawing.Point(6, 19);
			this.usersListView.Name = "usersListView";
			this.usersListView.Size = new System.Drawing.Size(561, 400);
			this.usersListView.TabIndex = 0;
			this.usersListView.UseCompatibleStateImageBehavior = false;
			this.usersListView.View = System.Windows.Forms.View.Details;
			this.usersListView.SelectedIndexChanged += new System.EventHandler(this.usersListView_SelectedIndexChanged);
			this.usersListView.DoubleClick += new System.EventHandler(this.usersListView_DoubleClick);
			// 
			// fullNameColumn
			// 
			this.fullNameColumn.Text = "Naam";
			this.fullNameColumn.Width = 221;
			// 
			// startNumberColumn
			// 
			this.startNumberColumn.Text = "StartNummer";
			this.startNumberColumn.Width = 109;
			// 
			// carWeightCOlumn
			// 
			this.carWeightCOlumn.Text = "Gewicht";
			this.carWeightCOlumn.Width = 59;
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(792, 472);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "&Sluiten";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// UsersForm
			// 
			this.AcceptButton = this.closeButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(879, 506);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupsGroup);
			this.Controls.Add(this.addUserButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "UsersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Deelnemers";
			this.Load += new System.EventHandler(this.UsersForm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersForm_FormClosing);
			this.groupsGroup.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupsGroup;
		private System.Windows.Forms.Button addUserButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView groupsListView;
		private System.Windows.Forms.ColumnHeader groupColumn;
		private System.Windows.Forms.ColumnHeader nUsersColumn;
		private System.Windows.Forms.ListView usersListView;
		private System.Windows.Forms.ColumnHeader startNumberColumn;
		private System.Windows.Forms.ColumnHeader fullNameColumn;
		private System.Windows.Forms.ColumnHeader carWeightCOlumn;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button deleteGroupButton;
		private System.Windows.Forms.Button editGroupButton;
		private System.Windows.Forms.Button newGroupButton;
		private System.Windows.Forms.Button deleteUserButton;
		private System.Windows.Forms.Button editUserButton;
		private System.Windows.Forms.Button printUserButton;
	}
}