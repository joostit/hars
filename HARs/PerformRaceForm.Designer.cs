namespace BrrrBayBay.HARs
{
	partial class PerformRaceForm
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
			this.nextButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.manualTimeEntryButton = new System.Windows.Forms.Button();
			this.endRaceButton = new System.Windows.Forms.Button();
			this.racingLabel = new System.Windows.Forms.Label();
			this.waitingForFinishLabel = new System.Windows.Forms.Label();
			this.requestTimeLabel = new System.Windows.Forms.Label();
			this.raceEndingLabel = new System.Windows.Forms.Label();
			this.raceSetupControl = new BrrrBayBay.HARs.RaceSetupControl();
			this.requestTimesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nextButton
			// 
			this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextButton.Location = new System.Drawing.Point(873, 230);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(75, 23);
			this.nextButton.TabIndex = 1;
			this.nextButton.Text = "&Ok";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(792, 230);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "&Annuleren";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// manualTimeEntryButton
			// 
			this.manualTimeEntryButton.Location = new System.Drawing.Point(682, 230);
			this.manualTimeEntryButton.Name = "manualTimeEntryButton";
			this.manualTimeEntryButton.Size = new System.Drawing.Size(104, 23);
			this.manualTimeEntryButton.TabIndex = 4;
			this.manualTimeEntryButton.Text = "&Tijden aanpassen";
			this.manualTimeEntryButton.UseVisualStyleBackColor = true;
			this.manualTimeEntryButton.Visible = false;
			this.manualTimeEntryButton.Click += new System.EventHandler(this.manualTimeEntryButton_Click);
			// 
			// endRaceButton
			// 
			this.endRaceButton.Location = new System.Drawing.Point(424, 230);
			this.endRaceButton.Name = "endRaceButton";
			this.endRaceButton.Size = new System.Drawing.Size(123, 23);
			this.endRaceButton.TabIndex = 5;
			this.endRaceButton.Text = "Race beëindigen";
			this.endRaceButton.UseVisualStyleBackColor = true;
			this.endRaceButton.Visible = false;
			this.endRaceButton.Click += new System.EventHandler(this.endRaceButton_Click);
			// 
			// racingLabel
			// 
			this.racingLabel.AutoSize = true;
			this.racingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.racingLabel.Location = new System.Drawing.Point(420, 151);
			this.racingLabel.Name = "racingLabel";
			this.racingLabel.Size = new System.Drawing.Size(127, 20);
			this.racingLabel.TabIndex = 6;
			this.racingLabel.Text = "Bezig met race...";
			this.racingLabel.Visible = false;
			// 
			// waitingForFinishLabel
			// 
			this.waitingForFinishLabel.AutoSize = true;
			this.waitingForFinishLabel.Location = new System.Drawing.Point(393, 171);
			this.waitingForFinishLabel.Name = "waitingForFinishLabel";
			this.waitingForFinishLabel.Size = new System.Drawing.Size(175, 13);
			this.waitingForFinishLabel.TabIndex = 7;
			this.waitingForFinishLabel.Text = "Wachten tot auto\'s zijn gefinished...";
			this.waitingForFinishLabel.Visible = false;
			// 
			// requestTimeLabel
			// 
			this.requestTimeLabel.AutoSize = true;
			this.requestTimeLabel.Location = new System.Drawing.Point(409, 197);
			this.requestTimeLabel.Name = "requestTimeLabel";
			this.requestTimeLabel.Size = new System.Drawing.Size(159, 13);
			this.requestTimeLabel.TabIndex = 8;
			this.requestTimeLabel.Text = "Bezig met opvragen van tijden...";
			this.requestTimeLabel.Visible = false;
			// 
			// raceEndingLabel
			// 
			this.raceEndingLabel.AutoSize = true;
			this.raceEndingLabel.Location = new System.Drawing.Point(430, 184);
			this.raceEndingLabel.Name = "raceEndingLabel";
			this.raceEndingLabel.Size = new System.Drawing.Size(103, 13);
			this.raceEndingLabel.TabIndex = 9;
			this.raceEndingLabel.Text = "Bezig met stoppen...";
			this.raceEndingLabel.Visible = false;
			// 
			// raceSetupControl
			// 
			this.raceSetupControl.Location = new System.Drawing.Point(12, 12);
			this.raceSetupControl.Name = "raceSetupControl";
			this.raceSetupControl.Size = new System.Drawing.Size(943, 146);
			this.raceSetupControl.TabIndex = 0;
			// 
			// requestTimesButton
			// 
			this.requestTimesButton.Location = new System.Drawing.Point(12, 230);
			this.requestTimesButton.Name = "requestTimesButton";
			this.requestTimesButton.Size = new System.Drawing.Size(93, 23);
			this.requestTimesButton.TabIndex = 10;
			this.requestTimesButton.Text = "Tijden opvragen";
			this.requestTimesButton.UseVisualStyleBackColor = true;
			this.requestTimesButton.Visible = false;
			this.requestTimesButton.Click += new System.EventHandler(this.requestTimesButton_Click);
			// 
			// PerformRaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 265);
			this.Controls.Add(this.requestTimesButton);
			this.Controls.Add(this.raceEndingLabel);
			this.Controls.Add(this.requestTimeLabel);
			this.Controls.Add(this.waitingForFinishLabel);
			this.Controls.Add(this.racingLabel);
			this.Controls.Add(this.endRaceButton);
			this.Controls.Add(this.manualTimeEntryButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.raceSetupControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "PerformRaceForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Race";
			this.Load += new System.EventHandler(this.PerformRaceForm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PerformRaceForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RaceSetupControl raceSetupControl;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button manualTimeEntryButton;
		private System.Windows.Forms.Button endRaceButton;
		private System.Windows.Forms.Label racingLabel;
		private System.Windows.Forms.Label waitingForFinishLabel;
		private System.Windows.Forms.Label requestTimeLabel;
		private System.Windows.Forms.Label raceEndingLabel;
		private System.Windows.Forms.Button requestTimesButton;



	}
}