namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Form used to load a game
	/// </summary>
	partial class loadGameForm
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
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.gamesListGroup = new System.Windows.Forms.GroupBox();
			this.gamesListView = new System.Windows.Forms.ListView();
			this.gameColumn = new System.Windows.Forms.ColumnHeader();
			this.stateColumn = new System.Windows.Forms.ColumnHeader();
			this.gamesListGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(252, 236);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 2;
			this.okButton.Text = "&Openen";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(171, 236);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "&Annuleren";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// gamesListGroup
			// 
			this.gamesListGroup.Controls.Add(this.gamesListView);
			this.gamesListGroup.Location = new System.Drawing.Point(12, 12);
			this.gamesListGroup.Name = "gamesListGroup";
			this.gamesListGroup.Size = new System.Drawing.Size(315, 218);
			this.gamesListGroup.TabIndex = 3;
			this.gamesListGroup.TabStop = false;
			this.gamesListGroup.Text = "Beschikbare wedstrijden";
			// 
			// gamesListView
			// 
			this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameColumn,
            this.stateColumn});
			this.gamesListView.FullRowSelect = true;
			this.gamesListView.HideSelection = false;
			this.gamesListView.Location = new System.Drawing.Point(6, 19);
			this.gamesListView.MultiSelect = false;
			this.gamesListView.Name = "gamesListView";
			this.gamesListView.Size = new System.Drawing.Size(303, 193);
			this.gamesListView.TabIndex = 0;
			this.gamesListView.UseCompatibleStateImageBehavior = false;
			this.gamesListView.View = System.Windows.Forms.View.Details;
			this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
			this.gamesListView.DoubleClick += new System.EventHandler(this.gamesListView_DoubleClick);
			// 
			// gameColumn
			// 
			this.gameColumn.Text = "WedstrijdNaam";
			this.gameColumn.Width = 184;
			// 
			// stateColumn
			// 
			this.stateColumn.Text = "Status";
			this.stateColumn.Width = 99;
			// 
			// loadGameForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(334, 266);
			this.Controls.Add(this.gamesListGroup);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "loadGameForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Wedstrijd openen";
			this.Load += new System.EventHandler(this.loadGameForm_Load);
			this.gamesListGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.GroupBox gamesListGroup;
		private System.Windows.Forms.ListView gamesListView;
		private System.Windows.Forms.ColumnHeader gameColumn;
		private System.Windows.Forms.ColumnHeader stateColumn;
	}
}