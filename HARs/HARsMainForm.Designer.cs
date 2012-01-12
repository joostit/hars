namespace BrrrBayBay.HARs
{
	/// <summary>
	/// HARs mainForm
	/// </summary>
    partial class HARsMainForm
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.harsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gameMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trackSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.mainContentPanel = new System.Windows.Forms.Panel();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harsToolStripMenuItem,
            this.gameMenuStripItem,
            this.settingsToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(1019, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// harsToolStripMenuItem
			// 
			this.harsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
			this.harsToolStripMenuItem.Name = "harsToolStripMenuItem";
			this.harsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.harsToolStripMenuItem.Text = "HARs";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.aboutToolStripMenuItem.Text = "&Info";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// afsluitenToolStripMenuItem
			// 
			this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
			this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.afsluitenToolStripMenuItem.Text = "&Afsluiten";
			this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
			// 
			// gameMenuStripItem
			// 
			this.gameMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.stopGameToolStripMenuItem});
			this.gameMenuStripItem.Name = "gameMenuStripItem";
			this.gameMenuStripItem.Size = new System.Drawing.Size(69, 20);
			this.gameMenuStripItem.Text = "Wedstrijd";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newGameToolStripMenuItem.Text = "&Nieuw";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// openGameToolStripMenuItem
			// 
			this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
			this.openGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openGameToolStripMenuItem.Text = "&Openen";
			this.openGameToolStripMenuItem.Click += new System.EventHandler(this.openGameToolStripMenuItem_Click);
			// 
			// stopGameToolStripMenuItem
			// 
			this.stopGameToolStripMenuItem.Enabled = false;
			this.stopGameToolStripMenuItem.Name = "stopGameToolStripMenuItem";
			this.stopGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.stopGameToolStripMenuItem.Text = "&Stoppen";
			this.stopGameToolStripMenuItem.Click += new System.EventHandler(this.stopGameToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageGamesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.trackSettingsToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.settingsToolStripMenuItem.Text = "Instellingen";
			// 
			// manageGamesToolStripMenuItem
			// 
			this.manageGamesToolStripMenuItem.Name = "manageGamesToolStripMenuItem";
			this.manageGamesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.manageGamesToolStripMenuItem.Text = "&Wedstrijden";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.usersToolStripMenuItem.Text = "&Deelnemers";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// trackSettingsToolStripMenuItem
			// 
			this.trackSettingsToolStripMenuItem.Name = "trackSettingsToolStripMenuItem";
			this.trackSettingsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.trackSettingsToolStripMenuItem.Text = "Ra&cebaan";
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 629);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(1019, 22);
			this.mainStatusStrip.TabIndex = 1;
			this.mainStatusStrip.Text = "statusStrip1";
			// 
			// mainContentPanel
			// 
			this.mainContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.mainContentPanel.Location = new System.Drawing.Point(0, 27);
			this.mainContentPanel.Name = "mainContentPanel";
			this.mainContentPanel.Size = new System.Drawing.Size(1019, 599);
			this.mainContentPanel.TabIndex = 2;
			this.mainContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContentPanel_Paint);
			// 
			// HARsMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 651);
			this.Controls.Add(this.mainContentPanel);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "HARsMainForm";
			this.Text = "HARs";
			this.Load += new System.EventHandler(this.HARsMainForm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HARsMainForm_FormClosing);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem gameMenuStripItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem harsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trackSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageGamesToolStripMenuItem;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.Panel mainContentPanel;
    }
}

