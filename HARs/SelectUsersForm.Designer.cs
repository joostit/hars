namespace BrrrBayBay.HARs
{
	partial class SelectUsersForm
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
			this.selectedGroup = new System.Windows.Forms.GroupBox();
			this.selectionListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.availableUsersGroup = new System.Windows.Forms.GroupBox();
			this.removeUserButton = new System.Windows.Forms.Button();
			this.usersListView = new System.Windows.Forms.ListView();
			this.nameColumn = new System.Windows.Forms.ColumnHeader();
			this.startNumberColumn = new System.Windows.Forms.ColumnHeader();
			this.groupColumn = new System.Windows.Forms.ColumnHeader();
			this.addUserButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numUsersLabel = new System.Windows.Forms.Label();
			this.groupsGroup = new System.Windows.Forms.GroupBox();
			this.addGroupButton = new System.Windows.Forms.Button();
			this.groupsListView = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.selectedGroup.SuspendLayout();
			this.availableUsersGroup.SuspendLayout();
			this.groupsGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectedGroup
			// 
			this.selectedGroup.BackColor = System.Drawing.SystemColors.Control;
			this.selectedGroup.Controls.Add(this.selectionListView);
			this.selectedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedGroup.Location = new System.Drawing.Point(506, 12);
			this.selectedGroup.Name = "selectedGroup";
			this.selectedGroup.Size = new System.Drawing.Size(322, 397);
			this.selectedGroup.TabIndex = 0;
			this.selectedGroup.TabStop = false;
			this.selectedGroup.Text = "Geselecteerde deelnemers";
			// 
			// selectionListView
			// 
			this.selectionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.selectionListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectionListView.FullRowSelect = true;
			this.selectionListView.HideSelection = false;
			this.selectionListView.Location = new System.Drawing.Point(6, 19);
			this.selectionListView.Name = "selectionListView";
			this.selectionListView.Size = new System.Drawing.Size(310, 372);
			this.selectionListView.TabIndex = 1;
			this.selectionListView.UseCompatibleStateImageBehavior = false;
			this.selectionListView.View = System.Windows.Forms.View.Details;
			this.selectionListView.SelectedIndexChanged += new System.EventHandler(this.selectionListView_SelectedIndexChanged);
			this.selectionListView.DoubleClick += new System.EventHandler(this.selectionListView_DoubleClick);
			this.selectionListView.Enter += new System.EventHandler(this.selectionListView_Enter);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Naam";
			this.columnHeader1.Width = 162;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nr.";
			this.columnHeader2.Width = 41;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Groep";
			this.columnHeader3.Width = 84;
			// 
			// availableUsersGroup
			// 
			this.availableUsersGroup.Controls.Add(this.removeUserButton);
			this.availableUsersGroup.Controls.Add(this.usersListView);
			this.availableUsersGroup.Controls.Add(this.addUserButton);
			this.availableUsersGroup.Location = new System.Drawing.Point(12, 162);
			this.availableUsersGroup.Name = "availableUsersGroup";
			this.availableUsersGroup.Size = new System.Drawing.Size(488, 247);
			this.availableUsersGroup.TabIndex = 1;
			this.availableUsersGroup.TabStop = false;
			this.availableUsersGroup.Text = "Beschikbare deelnemers";
			// 
			// removeUserButton
			// 
			this.removeUserButton.Enabled = false;
			this.removeUserButton.Location = new System.Drawing.Point(377, 189);
			this.removeUserButton.Name = "removeUserButton";
			this.removeUserButton.Size = new System.Drawing.Size(105, 23);
			this.removeUserButton.TabIndex = 3;
			this.removeUserButton.Text = "<<< &Verwijderen";
			this.removeUserButton.UseVisualStyleBackColor = true;
			this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
			// 
			// usersListView
			// 
			this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.startNumberColumn,
            this.groupColumn});
			this.usersListView.FullRowSelect = true;
			this.usersListView.HideSelection = false;
			this.usersListView.Location = new System.Drawing.Point(6, 19);
			this.usersListView.Name = "usersListView";
			this.usersListView.Size = new System.Drawing.Size(365, 222);
			this.usersListView.TabIndex = 0;
			this.usersListView.UseCompatibleStateImageBehavior = false;
			this.usersListView.View = System.Windows.Forms.View.Details;
			this.usersListView.SelectedIndexChanged += new System.EventHandler(this.usersListView_SelectedIndexChanged);
			this.usersListView.DoubleClick += new System.EventHandler(this.usersListView_DoubleClick);
			this.usersListView.Enter += new System.EventHandler(this.usersListView_Enter);
			// 
			// nameColumn
			// 
			this.nameColumn.Text = "Naam";
			this.nameColumn.Width = 158;
			// 
			// startNumberColumn
			// 
			this.startNumberColumn.Text = "Startnummer";
			this.startNumberColumn.Width = 78;
			// 
			// groupColumn
			// 
			this.groupColumn.Text = "Groep";
			this.groupColumn.Width = 96;
			// 
			// addUserButton
			// 
			this.addUserButton.Enabled = false;
			this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addUserButton.Location = new System.Drawing.Point(377, 218);
			this.addUserButton.Name = "addUserButton";
			this.addUserButton.Size = new System.Drawing.Size(105, 23);
			this.addUserButton.TabIndex = 2;
			this.addUserButton.Text = "&Toevoegen >>>";
			this.addUserButton.UseVisualStyleBackColor = true;
			this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(753, 415);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "&Ok";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(672, 415);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "&Annuleren";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(509, 420);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Aantal deelnemers:";
			// 
			// numUsersLabel
			// 
			this.numUsersLabel.AutoSize = true;
			this.numUsersLabel.Location = new System.Drawing.Point(612, 420);
			this.numUsersLabel.Name = "numUsersLabel";
			this.numUsersLabel.Size = new System.Drawing.Size(13, 13);
			this.numUsersLabel.TabIndex = 7;
			this.numUsersLabel.Text = "0";
			// 
			// groupsGroup
			// 
			this.groupsGroup.Controls.Add(this.addGroupButton);
			this.groupsGroup.Controls.Add(this.groupsListView);
			this.groupsGroup.Location = new System.Drawing.Point(12, 12);
			this.groupsGroup.Name = "groupsGroup";
			this.groupsGroup.Size = new System.Drawing.Size(488, 144);
			this.groupsGroup.TabIndex = 8;
			this.groupsGroup.TabStop = false;
			this.groupsGroup.Text = "Groepen";
			// 
			// addGroupButton
			// 
			this.addGroupButton.Enabled = false;
			this.addGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addGroupButton.Location = new System.Drawing.Point(377, 115);
			this.addGroupButton.Name = "addGroupButton";
			this.addGroupButton.Size = new System.Drawing.Size(105, 23);
			this.addGroupButton.TabIndex = 9;
			this.addGroupButton.Text = "&Toevoegen >>>";
			this.addGroupButton.UseVisualStyleBackColor = true;
			this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
			// 
			// groupsListView
			// 
			this.groupsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
			this.groupsListView.FullRowSelect = true;
			this.groupsListView.HideSelection = false;
			this.groupsListView.Location = new System.Drawing.Point(6, 19);
			this.groupsListView.Name = "groupsListView";
			this.groupsListView.Size = new System.Drawing.Size(365, 119);
			this.groupsListView.TabIndex = 0;
			this.groupsListView.UseCompatibleStateImageBehavior = false;
			this.groupsListView.View = System.Windows.Forms.View.Details;
			this.groupsListView.SelectedIndexChanged += new System.EventHandler(this.groupsListView_SelectedIndexChanged);
			this.groupsListView.DoubleClick += new System.EventHandler(this.groupsListView_DoubleClick);
			this.groupsListView.Enter += new System.EventHandler(this.groupsListView_Enter);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Groepsnaam";
			this.columnHeader4.Width = 336;
			// 
			// SelectUsersForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(840, 450);
			this.Controls.Add(this.groupsGroup);
			this.Controls.Add(this.numUsersLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.availableUsersGroup);
			this.Controls.Add(this.selectedGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "SelectUsersForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Deelnemers";
			this.Load += new System.EventHandler(this.SelectUsersForm_Load);
			this.selectedGroup.ResumeLayout(false);
			this.availableUsersGroup.ResumeLayout(false);
			this.groupsGroup.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox selectedGroup;
		private System.Windows.Forms.GroupBox availableUsersGroup;
		private System.Windows.Forms.Button addUserButton;
		private System.Windows.Forms.Button removeUserButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label numUsersLabel;
		private System.Windows.Forms.ListView usersListView;
		private System.Windows.Forms.ColumnHeader nameColumn;
		private System.Windows.Forms.ColumnHeader startNumberColumn;
		private System.Windows.Forms.GroupBox groupsGroup;
		private System.Windows.Forms.ColumnHeader groupColumn;
		private System.Windows.Forms.ListView selectionListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListView groupsListView;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button addGroupButton;
	}
}