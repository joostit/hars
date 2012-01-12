namespace BrrrBayBay.HARs
{
	partial class NewGameForm
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
			this.gameTypeGroup = new System.Windows.Forms.GroupBox();
			this.leagueButton = new System.Windows.Forms.RadioButton();
			this.timeLapsButton = new System.Windows.Forms.RadioButton();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.gameTypeGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// gameTypeGroup
			// 
			this.gameTypeGroup.Controls.Add(this.leagueButton);
			this.gameTypeGroup.Controls.Add(this.timeLapsButton);
			this.gameTypeGroup.Location = new System.Drawing.Point(19, 38);
			this.gameTypeGroup.Name = "gameTypeGroup";
			this.gameTypeGroup.Size = new System.Drawing.Size(200, 69);
			this.gameTypeGroup.TabIndex = 0;
			this.gameTypeGroup.TabStop = false;
			this.gameTypeGroup.Text = "Speltype";
			// 
			// leagueButton
			// 
			this.leagueButton.AutoSize = true;
			this.leagueButton.Location = new System.Drawing.Point(6, 42);
			this.leagueButton.Name = "leagueButton";
			this.leagueButton.Size = new System.Drawing.Size(112, 17);
			this.leagueButton.TabIndex = 2;
			this.leagueButton.TabStop = true;
			this.leagueButton.Text = "Champions league";
			this.leagueButton.UseVisualStyleBackColor = true;
			this.leagueButton.CheckedChanged += new System.EventHandler(this.typeButton_CheckedChanged);
			// 
			// timeLapsButton
			// 
			this.timeLapsButton.AutoSize = true;
			this.timeLapsButton.Location = new System.Drawing.Point(6, 19);
			this.timeLapsButton.Name = "timeLapsButton";
			this.timeLapsButton.Size = new System.Drawing.Size(70, 17);
			this.timeLapsButton.TabIndex = 1;
			this.timeLapsButton.TabStop = true;
			this.timeLapsButton.Text = "Tijdsritten";
			this.timeLapsButton.UseVisualStyleBackColor = true;
			this.timeLapsButton.CheckedChanged += new System.EventHandler(this.typeButton_CheckedChanged);
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(65, 12);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(153, 20);
			this.nameBox.TabIndex = 0;
			this.nameBox.Validated += new System.EventHandler(this.nameBox_Validated);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(21, 15);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(38, 13);
			this.nameLabel.TabIndex = 2;
			this.nameLabel.Text = "Naam:";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(19, 113);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "&Annuleren";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(143, 113);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "&Ok";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// NewGameForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(240, 151);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.gameTypeGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "NewGameForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nieuwe wedstrijd";
			this.Load += new System.EventHandler(this.NewGameForm_Load);
			this.gameTypeGroup.ResumeLayout(false);
			this.gameTypeGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gameTypeGroup;
		private System.Windows.Forms.RadioButton leagueButton;
		private System.Windows.Forms.RadioButton timeLapsButton;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
	}
}