namespace BrrrBayBay.SpriteCommTester
{
	partial class SpriteCommTesterMainForm
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
			this.startRaceButton = new System.Windows.Forms.Button();
			this.startAckBox = new System.Windows.Forms.CheckBox();
			this.endRaceButton = new System.Windows.Forms.Button();
			this.endRaceAckBox = new System.Windows.Forms.CheckBox();
			this.commandsGroup = new System.Windows.Forms.GroupBox();
			this.getResultsButton = new System.Windows.Forms.Button();
			this.carsRollingBox = new System.Windows.Forms.CheckBox();
			this.miscGroup = new System.Windows.Forms.GroupBox();
			this.resetAckBox = new System.Windows.Forms.CheckBox();
			this.resetButton = new System.Windows.Forms.Button();
			this.finishFlagGroup = new System.Windows.Forms.GroupBox();
			this.f8box = new System.Windows.Forms.CheckBox();
			this.f7box = new System.Windows.Forms.CheckBox();
			this.f6box = new System.Windows.Forms.CheckBox();
			this.f5box = new System.Windows.Forms.CheckBox();
			this.f4box = new System.Windows.Forms.CheckBox();
			this.f3box = new System.Windows.Forms.CheckBox();
			this.f2box = new System.Windows.Forms.CheckBox();
			this.f1box = new System.Windows.Forms.CheckBox();
			this.commandsGroup.SuspendLayout();
			this.miscGroup.SuspendLayout();
			this.finishFlagGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// startRaceButton
			// 
			this.startRaceButton.Location = new System.Drawing.Point(6, 19);
			this.startRaceButton.Name = "startRaceButton";
			this.startRaceButton.Size = new System.Drawing.Size(75, 23);
			this.startRaceButton.TabIndex = 0;
			this.startRaceButton.Text = "Start Race";
			this.startRaceButton.UseVisualStyleBackColor = true;
			this.startRaceButton.Click += new System.EventHandler(this.startRaceButton_Click);
			// 
			// startAckBox
			// 
			this.startAckBox.AutoSize = true;
			this.startAckBox.Enabled = false;
			this.startAckBox.Location = new System.Drawing.Point(6, 48);
			this.startAckBox.Name = "startAckBox";
			this.startAckBox.Size = new System.Drawing.Size(45, 17);
			this.startAckBox.TabIndex = 1;
			this.startAckBox.Text = "Ack";
			this.startAckBox.UseVisualStyleBackColor = true;
			// 
			// endRaceButton
			// 
			this.endRaceButton.Location = new System.Drawing.Point(6, 97);
			this.endRaceButton.Name = "endRaceButton";
			this.endRaceButton.Size = new System.Drawing.Size(75, 23);
			this.endRaceButton.TabIndex = 2;
			this.endRaceButton.Text = "End race";
			this.endRaceButton.UseVisualStyleBackColor = true;
			this.endRaceButton.Click += new System.EventHandler(this.endRaceButton_Click);
			// 
			// endRaceAckBox
			// 
			this.endRaceAckBox.AutoSize = true;
			this.endRaceAckBox.Enabled = false;
			this.endRaceAckBox.Location = new System.Drawing.Point(6, 126);
			this.endRaceAckBox.Name = "endRaceAckBox";
			this.endRaceAckBox.Size = new System.Drawing.Size(44, 17);
			this.endRaceAckBox.TabIndex = 3;
			this.endRaceAckBox.Text = "ack";
			this.endRaceAckBox.UseVisualStyleBackColor = true;
			// 
			// commandsGroup
			// 
			this.commandsGroup.Controls.Add(this.getResultsButton);
			this.commandsGroup.Controls.Add(this.carsRollingBox);
			this.commandsGroup.Controls.Add(this.startRaceButton);
			this.commandsGroup.Controls.Add(this.endRaceAckBox);
			this.commandsGroup.Controls.Add(this.startAckBox);
			this.commandsGroup.Controls.Add(this.endRaceButton);
			this.commandsGroup.Location = new System.Drawing.Point(12, 12);
			this.commandsGroup.Name = "commandsGroup";
			this.commandsGroup.Size = new System.Drawing.Size(193, 209);
			this.commandsGroup.TabIndex = 4;
			this.commandsGroup.TabStop = false;
			this.commandsGroup.Text = "Racing Commands";
			// 
			// getResultsButton
			// 
			this.getResultsButton.Location = new System.Drawing.Point(6, 180);
			this.getResultsButton.Name = "getResultsButton";
			this.getResultsButton.Size = new System.Drawing.Size(75, 23);
			this.getResultsButton.TabIndex = 5;
			this.getResultsButton.Text = "Get Timings";
			this.getResultsButton.UseVisualStyleBackColor = true;
			this.getResultsButton.Click += new System.EventHandler(this.getResultsButton_Click);
			// 
			// carsRollingBox
			// 
			this.carsRollingBox.AutoSize = true;
			this.carsRollingBox.Enabled = false;
			this.carsRollingBox.Location = new System.Drawing.Point(87, 23);
			this.carsRollingBox.Name = "carsRollingBox";
			this.carsRollingBox.Size = new System.Drawing.Size(77, 17);
			this.carsRollingBox.TabIndex = 4;
			this.carsRollingBox.Text = "Cars rolling";
			this.carsRollingBox.UseVisualStyleBackColor = true;
			// 
			// miscGroup
			// 
			this.miscGroup.Controls.Add(this.resetAckBox);
			this.miscGroup.Controls.Add(this.resetButton);
			this.miscGroup.Location = new System.Drawing.Point(12, 227);
			this.miscGroup.Name = "miscGroup";
			this.miscGroup.Size = new System.Drawing.Size(193, 81);
			this.miscGroup.TabIndex = 5;
			this.miscGroup.TabStop = false;
			this.miscGroup.Text = "Miscellaneous";
			// 
			// resetAckBox
			// 
			this.resetAckBox.AutoSize = true;
			this.resetAckBox.Enabled = false;
			this.resetAckBox.Location = new System.Drawing.Point(7, 48);
			this.resetAckBox.Name = "resetAckBox";
			this.resetAckBox.Size = new System.Drawing.Size(44, 17);
			this.resetAckBox.TabIndex = 1;
			this.resetAckBox.Text = "ack";
			this.resetAckBox.UseVisualStyleBackColor = true;
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(6, 19);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 0;
			this.resetButton.Text = "reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// finishFlagGroup
			// 
			this.finishFlagGroup.Controls.Add(this.f8box);
			this.finishFlagGroup.Controls.Add(this.f7box);
			this.finishFlagGroup.Controls.Add(this.f6box);
			this.finishFlagGroup.Controls.Add(this.f5box);
			this.finishFlagGroup.Controls.Add(this.f4box);
			this.finishFlagGroup.Controls.Add(this.f3box);
			this.finishFlagGroup.Controls.Add(this.f2box);
			this.finishFlagGroup.Controls.Add(this.f1box);
			this.finishFlagGroup.Location = new System.Drawing.Point(211, 12);
			this.finishFlagGroup.Name = "finishFlagGroup";
			this.finishFlagGroup.Size = new System.Drawing.Size(81, 209);
			this.finishFlagGroup.TabIndex = 6;
			this.finishFlagGroup.TabStop = false;
			this.finishFlagGroup.Text = "FinishFlags";
			// 
			// f8box
			// 
			this.f8box.AutoSize = true;
			this.f8box.Enabled = false;
			this.f8box.Location = new System.Drawing.Point(6, 180);
			this.f8box.Name = "f8box";
			this.f8box.Size = new System.Drawing.Size(32, 17);
			this.f8box.TabIndex = 7;
			this.f8box.Text = "8";
			this.f8box.UseVisualStyleBackColor = true;
			// 
			// f7box
			// 
			this.f7box.AutoSize = true;
			this.f7box.Enabled = false;
			this.f7box.Location = new System.Drawing.Point(6, 157);
			this.f7box.Name = "f7box";
			this.f7box.Size = new System.Drawing.Size(32, 17);
			this.f7box.TabIndex = 6;
			this.f7box.Text = "7";
			this.f7box.UseVisualStyleBackColor = true;
			// 
			// f6box
			// 
			this.f6box.AutoSize = true;
			this.f6box.Enabled = false;
			this.f6box.Location = new System.Drawing.Point(6, 134);
			this.f6box.Name = "f6box";
			this.f6box.Size = new System.Drawing.Size(32, 17);
			this.f6box.TabIndex = 5;
			this.f6box.Text = "6";
			this.f6box.UseVisualStyleBackColor = true;
			// 
			// f5box
			// 
			this.f5box.AutoSize = true;
			this.f5box.Enabled = false;
			this.f5box.Location = new System.Drawing.Point(6, 111);
			this.f5box.Name = "f5box";
			this.f5box.Size = new System.Drawing.Size(32, 17);
			this.f5box.TabIndex = 4;
			this.f5box.Text = "5";
			this.f5box.UseVisualStyleBackColor = true;
			// 
			// f4box
			// 
			this.f4box.AutoSize = true;
			this.f4box.Enabled = false;
			this.f4box.Location = new System.Drawing.Point(6, 88);
			this.f4box.Name = "f4box";
			this.f4box.Size = new System.Drawing.Size(32, 17);
			this.f4box.TabIndex = 3;
			this.f4box.Text = "4";
			this.f4box.UseVisualStyleBackColor = true;
			// 
			// f3box
			// 
			this.f3box.AutoSize = true;
			this.f3box.Enabled = false;
			this.f3box.Location = new System.Drawing.Point(6, 65);
			this.f3box.Name = "f3box";
			this.f3box.Size = new System.Drawing.Size(32, 17);
			this.f3box.TabIndex = 2;
			this.f3box.Text = "3";
			this.f3box.UseVisualStyleBackColor = true;
			// 
			// f2box
			// 
			this.f2box.AutoSize = true;
			this.f2box.Enabled = false;
			this.f2box.Location = new System.Drawing.Point(6, 42);
			this.f2box.Name = "f2box";
			this.f2box.Size = new System.Drawing.Size(32, 17);
			this.f2box.TabIndex = 1;
			this.f2box.Text = "2";
			this.f2box.UseVisualStyleBackColor = true;
			// 
			// f1box
			// 
			this.f1box.AutoSize = true;
			this.f1box.Enabled = false;
			this.f1box.Location = new System.Drawing.Point(6, 19);
			this.f1box.Name = "f1box";
			this.f1box.Size = new System.Drawing.Size(32, 17);
			this.f1box.TabIndex = 0;
			this.f1box.Text = "1";
			this.f1box.UseVisualStyleBackColor = true;
			// 
			// SpriteCommTesterMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 383);
			this.Controls.Add(this.finishFlagGroup);
			this.Controls.Add(this.miscGroup);
			this.Controls.Add(this.commandsGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SpriteCommTesterMainForm";
			this.Text = "SpriteComm Tester";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpriteCommTesterMainForm_FormClosing);
			this.commandsGroup.ResumeLayout(false);
			this.commandsGroup.PerformLayout();
			this.miscGroup.ResumeLayout(false);
			this.miscGroup.PerformLayout();
			this.finishFlagGroup.ResumeLayout(false);
			this.finishFlagGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button startRaceButton;
		private System.Windows.Forms.CheckBox startAckBox;
		private System.Windows.Forms.Button endRaceButton;
		private System.Windows.Forms.CheckBox endRaceAckBox;
		private System.Windows.Forms.GroupBox commandsGroup;
		private System.Windows.Forms.GroupBox miscGroup;
		private System.Windows.Forms.CheckBox resetAckBox;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.GroupBox finishFlagGroup;
		private System.Windows.Forms.CheckBox f1box;
		private System.Windows.Forms.CheckBox f8box;
		private System.Windows.Forms.CheckBox f7box;
		private System.Windows.Forms.CheckBox f6box;
		private System.Windows.Forms.CheckBox f5box;
		private System.Windows.Forms.CheckBox f4box;
		private System.Windows.Forms.CheckBox f3box;
		private System.Windows.Forms.CheckBox f2box;
		private System.Windows.Forms.CheckBox carsRollingBox;
		private System.Windows.Forms.Button getResultsButton;
	}
}

