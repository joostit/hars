namespace BrrrBayBay.HARs
{
	partial class TrackLayoutControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.startNumberBox = new System.Windows.Forms.ComboBox();
			this.trackGroup = new System.Windows.Forms.GroupBox();
			this.enabledBox = new System.Windows.Forms.CheckBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.trackGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// startNumberBox
			// 
			this.startNumberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.startNumberBox.FormattingEnabled = true;
			this.startNumberBox.Location = new System.Drawing.Point(6, 39);
			this.startNumberBox.MaxDropDownItems = 10;
			this.startNumberBox.Name = "startNumberBox";
			this.startNumberBox.Size = new System.Drawing.Size(94, 21);
			this.startNumberBox.Sorted = true;
			this.startNumberBox.TabIndex = 0;
			this.startNumberBox.SelectedIndexChanged += new System.EventHandler(this.startNumberBox_SelectedIndexChanged);
			// 
			// trackGroup
			// 
			this.trackGroup.Controls.Add(this.enabledBox);
			this.trackGroup.Controls.Add(this.lastNameLabel);
			this.trackGroup.Controls.Add(this.firstNameLabel);
			this.trackGroup.Controls.Add(this.startNumberBox);
			this.trackGroup.Location = new System.Drawing.Point(3, 3);
			this.trackGroup.Name = "trackGroup";
			this.trackGroup.Size = new System.Drawing.Size(106, 95);
			this.trackGroup.TabIndex = 1;
			this.trackGroup.TabStop = false;
			this.trackGroup.Text = "Baan n";
			// 
			// enabledBox
			// 
			this.enabledBox.AutoSize = true;
			this.enabledBox.Checked = true;
			this.enabledBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enabledBox.Location = new System.Drawing.Point(6, 19);
			this.enabledBox.Name = "enabledBox";
			this.enabledBox.Size = new System.Drawing.Size(15, 14);
			this.enabledBox.TabIndex = 4;
			this.enabledBox.UseVisualStyleBackColor = true;
			this.enabledBox.CheckedChanged += new System.EventHandler(this.enabledBox_CheckedChanged);
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(6, 76);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(0, 13);
			this.lastNameLabel.TabIndex = 3;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(6, 63);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(0, 13);
			this.firstNameLabel.TabIndex = 1;
			// 
			// TrackLayoutControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.trackGroup);
			this.Name = "TrackLayoutControl";
			this.Size = new System.Drawing.Size(112, 102);
			this.Load += new System.EventHandler(this.TrackLayoutControl_Load);
			this.trackGroup.ResumeLayout(false);
			this.trackGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox startNumberBox;
		private System.Windows.Forms.GroupBox trackGroup;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.CheckBox enabledBox;
	}
}
