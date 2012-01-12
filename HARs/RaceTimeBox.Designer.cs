namespace BrrrBayBay.HARs
{
	partial class RaceTimeBox
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
			this.timeBox = new System.Windows.Forms.TextBox();
			this.finishedBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// timeBox
			// 
			this.timeBox.Location = new System.Drawing.Point(18, 3);
			this.timeBox.Name = "timeBox";
			this.timeBox.Size = new System.Drawing.Size(91, 20);
			this.timeBox.TabIndex = 1;
			this.timeBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// finishedBox
			// 
			this.finishedBox.Enabled = false;
			this.finishedBox.Location = new System.Drawing.Point(4, 3);
			this.finishedBox.Name = "finishedBox";
			this.finishedBox.Size = new System.Drawing.Size(15, 20);
			this.finishedBox.TabIndex = 2;
			this.finishedBox.UseVisualStyleBackColor = true;
			// 
			// RaceTimeBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.finishedBox);
			this.Controls.Add(this.timeBox);
			this.Name = "RaceTimeBox";
			this.Size = new System.Drawing.Size(112, 27);
			this.Load += new System.EventHandler(this.RaceTimeBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox timeBox;
		private System.Windows.Forms.CheckBox finishedBox;
	}
}
