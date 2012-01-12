namespace BrrrBayBay.HARs
{
	/// <summary>
	/// Form used to edit user data
	/// </summary>
	partial class EditUserForm
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
			this.startNumberBox = new System.Windows.Forms.TextBox();
			this.firstNameBox = new System.Windows.Forms.TextBox();
			this.lastNameBox = new System.Windows.Forms.TextBox();
			this.carWeightBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupsBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(208, 164);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 6;
			this.okButton.Text = "&Ok";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(127, 164);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "&Annuleren";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// startNumberBox
			// 
			this.startNumberBox.Location = new System.Drawing.Point(94, 12);
			this.startNumberBox.Name = "startNumberBox";
			this.startNumberBox.Size = new System.Drawing.Size(45, 20);
			this.startNumberBox.TabIndex = 0;
			this.startNumberBox.Text = "1234";
			this.startNumberBox.Validated += new System.EventHandler(this.startNumberBox_Validated);
			this.startNumberBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateTexboxInt);
			// 
			// firstNameBox
			// 
			this.firstNameBox.Location = new System.Drawing.Point(94, 38);
			this.firstNameBox.Name = "firstNameBox";
			this.firstNameBox.Size = new System.Drawing.Size(189, 20);
			this.firstNameBox.TabIndex = 1;
			this.firstNameBox.Text = "Jan-Willen zebedeus";
			this.firstNameBox.Validated += new System.EventHandler(this.firstNameBox_Validated);
			// 
			// lastNameBox
			// 
			this.lastNameBox.Location = new System.Drawing.Point(94, 64);
			this.lastNameBox.Name = "lastNameBox";
			this.lastNameBox.Size = new System.Drawing.Size(189, 20);
			this.lastNameBox.TabIndex = 2;
			this.lastNameBox.Text = "Gravesande van kerstens";
			this.lastNameBox.Validated += new System.EventHandler(this.lastNameBox_Validated);
			// 
			// carWeightBox
			// 
			this.carWeightBox.Location = new System.Drawing.Point(94, 90);
			this.carWeightBox.Name = "carWeightBox";
			this.carWeightBox.Size = new System.Drawing.Size(45, 20);
			this.carWeightBox.TabIndex = 3;
			this.carWeightBox.Text = "1725";
			this.carWeightBox.Validated += new System.EventHandler(this.carWeightBox_Validated);
			this.carWeightBox.Validating += new System.ComponentModel.CancelEventHandler(this.validateTexboxInt);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(145, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "gram";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Startnummer:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Voornaam:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Achternaam:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Gewicht auto:";
			// 
			// groupsBox
			// 
			this.groupsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.groupsBox.FormattingEnabled = true;
			this.groupsBox.Location = new System.Drawing.Point(94, 116);
			this.groupsBox.MaxDropDownItems = 10;
			this.groupsBox.Name = "groupsBox";
			this.groupsBox.Size = new System.Drawing.Size(189, 21);
			this.groupsBox.TabIndex = 4;
			this.groupsBox.Validated += new System.EventHandler(this.groupsBox_Validated);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(49, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Groep:";
			// 
			// EditUserForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(295, 199);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupsBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.carWeightBox);
			this.Controls.Add(this.lastNameBox);
			this.Controls.Add(this.firstNameBox);
			this.Controls.Add(this.startNumberBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "EditUserForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Deelnemer";
			this.Load += new System.EventHandler(this.EditUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TextBox startNumberBox;
		private System.Windows.Forms.TextBox firstNameBox;
		private System.Windows.Forms.TextBox lastNameBox;
		private System.Windows.Forms.TextBox carWeightBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox groupsBox;
		private System.Windows.Forms.Label label6;
	}
}