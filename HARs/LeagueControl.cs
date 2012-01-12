using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrrrBayBay.SpriteCommHandler;
using System.Windows.Forms;
using BrrrBayBay.HARs.dataModel;

namespace BrrrBayBay.HARs
{
	class LeagueControl : GameControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView poule0ListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListView poule3ListView;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ListView poule2ListView;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ListView poule1ListView;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox quarterFinalGroup;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListView quarter3ListView;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ListView quarter2ListView;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ListView quarter1ListView;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListView quarter0ListView;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ColumnHeader columnHeader23;
		private System.Windows.Forms.ColumnHeader columnHeader24;
		private System.Windows.Forms.GroupBox semiFinalsGroup;
		private System.Windows.Forms.ListView semi1ListView;
		private System.Windows.Forms.ColumnHeader columnHeader25;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ListView semi0ListView;
		private System.Windows.Forms.ColumnHeader columnHeader28;
		private System.Windows.Forms.ColumnHeader columnHeader29;
		private System.Windows.Forms.ColumnHeader columnHeader30;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox finalGroup;
		private System.Windows.Forms.ListView finalListView;
		private System.Windows.Forms.ColumnHeader columnHeader34;
		private System.Windows.Forms.ColumnHeader columnHeader35;
		private System.Windows.Forms.ColumnHeader columnHeader36;
		private System.Windows.Forms.GroupBox controlGroup;
		private System.Windows.Forms.Button startRaceButton;
		private System.Windows.Forms.GroupBox pouleGroup;
	
		private void InitializeComponent()
		{
			this.pouleGroup = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.poule3ListView = new System.Windows.Forms.ListView();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.poule2ListView = new System.Windows.Forms.ListView();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.poule1ListView = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.poule0ListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.quarterFinalGroup = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.quarter3ListView = new System.Windows.Forms.ListView();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.quarter2ListView = new System.Windows.Forms.ListView();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
			this.quarter1ListView = new System.Windows.Forms.ListView();
			this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
			this.label8 = new System.Windows.Forms.Label();
			this.quarter0ListView = new System.Windows.Forms.ListView();
			this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
			this.semiFinalsGroup = new System.Windows.Forms.GroupBox();
			this.semi1ListView = new System.Windows.Forms.ListView();
			this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
			this.label11 = new System.Windows.Forms.Label();
			this.semi0ListView = new System.Windows.Forms.ListView();
			this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader29 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader30 = new System.Windows.Forms.ColumnHeader();
			this.label12 = new System.Windows.Forms.Label();
			this.finalGroup = new System.Windows.Forms.GroupBox();
			this.finalListView = new System.Windows.Forms.ListView();
			this.columnHeader34 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader35 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader36 = new System.Windows.Forms.ColumnHeader();
			this.controlGroup = new System.Windows.Forms.GroupBox();
			this.startRaceButton = new System.Windows.Forms.Button();
			this.pouleGroup.SuspendLayout();
			this.quarterFinalGroup.SuspendLayout();
			this.semiFinalsGroup.SuspendLayout();
			this.finalGroup.SuspendLayout();
			this.controlGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// pouleGroup
			// 
			this.pouleGroup.Controls.Add(this.label4);
			this.pouleGroup.Controls.Add(this.label3);
			this.pouleGroup.Controls.Add(this.label2);
			this.pouleGroup.Controls.Add(this.poule3ListView);
			this.pouleGroup.Controls.Add(this.poule2ListView);
			this.pouleGroup.Controls.Add(this.poule1ListView);
			this.pouleGroup.Controls.Add(this.label1);
			this.pouleGroup.Controls.Add(this.poule0ListView);
			this.pouleGroup.Location = new System.Drawing.Point(3, 393);
			this.pouleGroup.Name = "pouleGroup";
			this.pouleGroup.Size = new System.Drawing.Size(1008, 202);
			this.pouleGroup.TabIndex = 0;
			this.pouleGroup.TabStop = false;
			this.pouleGroup.Text = "Poules";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(858, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Poule D";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(609, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Poule C";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(346, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Poule B";
			// 
			// poule3ListView
			// 
			this.poule3ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
			this.poule3ListView.FullRowSelect = true;
			this.poule3ListView.HideSelection = false;
			this.poule3ListView.Location = new System.Drawing.Point(756, 32);
			this.poule3ListView.Name = "poule3ListView";
			this.poule3ListView.Size = new System.Drawing.Size(244, 164);
			this.poule3ListView.TabIndex = 4;
			this.poule3ListView.UseCompatibleStateImageBehavior = false;
			this.poule3ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "#";
			this.columnHeader10.Width = 25;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Num.";
			this.columnHeader11.Width = 40;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Naam";
			this.columnHeader12.Width = 153;
			// 
			// poule2ListView
			// 
			this.poule2ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.poule2ListView.FullRowSelect = true;
			this.poule2ListView.HideSelection = false;
			this.poule2ListView.Location = new System.Drawing.Point(506, 32);
			this.poule2ListView.Name = "poule2ListView";
			this.poule2ListView.Size = new System.Drawing.Size(244, 164);
			this.poule2ListView.TabIndex = 3;
			this.poule2ListView.UseCompatibleStateImageBehavior = false;
			this.poule2ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "#";
			this.columnHeader7.Width = 25;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Num.";
			this.columnHeader8.Width = 40;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Naam";
			this.columnHeader9.Width = 153;
			// 
			// poule1ListView
			// 
			this.poule1ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.poule1ListView.FullRowSelect = true;
			this.poule1ListView.HideSelection = false;
			this.poule1ListView.Location = new System.Drawing.Point(256, 32);
			this.poule1ListView.Name = "poule1ListView";
			this.poule1ListView.Size = new System.Drawing.Size(244, 164);
			this.poule1ListView.TabIndex = 2;
			this.poule1ListView.UseCompatibleStateImageBehavior = false;
			this.poule1ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "#";
			this.columnHeader4.Width = 25;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Num.";
			this.columnHeader5.Width = 40;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Naam";
			this.columnHeader6.Width = 153;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(102, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Poule A";
			// 
			// poule0ListView
			// 
			this.poule0ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.poule0ListView.FullRowSelect = true;
			this.poule0ListView.HideSelection = false;
			this.poule0ListView.Location = new System.Drawing.Point(6, 32);
			this.poule0ListView.Name = "poule0ListView";
			this.poule0ListView.Size = new System.Drawing.Size(244, 164);
			this.poule0ListView.TabIndex = 0;
			this.poule0ListView.UseCompatibleStateImageBehavior = false;
			this.poule0ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#";
			this.columnHeader1.Width = 25;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Num.";
			this.columnHeader2.Width = 40;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Naam";
			this.columnHeader3.Width = 153;
			// 
			// quarterFinalGroup
			// 
			this.quarterFinalGroup.Controls.Add(this.label5);
			this.quarterFinalGroup.Controls.Add(this.label6);
			this.quarterFinalGroup.Controls.Add(this.label7);
			this.quarterFinalGroup.Controls.Add(this.quarter3ListView);
			this.quarterFinalGroup.Controls.Add(this.quarter2ListView);
			this.quarterFinalGroup.Controls.Add(this.quarter1ListView);
			this.quarterFinalGroup.Controls.Add(this.label8);
			this.quarterFinalGroup.Controls.Add(this.quarter0ListView);
			this.quarterFinalGroup.Enabled = false;
			this.quarterFinalGroup.Location = new System.Drawing.Point(3, 259);
			this.quarterFinalGroup.Name = "quarterFinalGroup";
			this.quarterFinalGroup.Size = new System.Drawing.Size(1008, 128);
			this.quarterFinalGroup.TabIndex = 1;
			this.quarterFinalGroup.TabStop = false;
			this.quarterFinalGroup.Text = "KwartFinales";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(846, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "KwartFinale D";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(590, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "KwartFinale C";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(333, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "KwartFinale B";
			// 
			// quarter3ListView
			// 
			this.quarter3ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
			this.quarter3ListView.FullRowSelect = true;
			this.quarter3ListView.HideSelection = false;
			this.quarter3ListView.Location = new System.Drawing.Point(756, 32);
			this.quarter3ListView.Name = "quarter3ListView";
			this.quarter3ListView.Size = new System.Drawing.Size(244, 90);
			this.quarter3ListView.TabIndex = 4;
			this.quarter3ListView.UseCompatibleStateImageBehavior = false;
			this.quarter3ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "#";
			this.columnHeader13.Width = 25;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Num.";
			this.columnHeader14.Width = 40;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Naam";
			this.columnHeader15.Width = 153;
			// 
			// quarter2ListView
			// 
			this.quarter2ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
			this.quarter2ListView.FullRowSelect = true;
			this.quarter2ListView.HideSelection = false;
			this.quarter2ListView.Location = new System.Drawing.Point(506, 32);
			this.quarter2ListView.Name = "quarter2ListView";
			this.quarter2ListView.Size = new System.Drawing.Size(244, 90);
			this.quarter2ListView.TabIndex = 3;
			this.quarter2ListView.UseCompatibleStateImageBehavior = false;
			this.quarter2ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "#";
			this.columnHeader16.Width = 25;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Num.";
			this.columnHeader17.Width = 40;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Naam";
			this.columnHeader18.Width = 153;
			// 
			// quarter1ListView
			// 
			this.quarter1ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
			this.quarter1ListView.FullRowSelect = true;
			this.quarter1ListView.HideSelection = false;
			this.quarter1ListView.Location = new System.Drawing.Point(256, 32);
			this.quarter1ListView.Name = "quarter1ListView";
			this.quarter1ListView.Size = new System.Drawing.Size(244, 90);
			this.quarter1ListView.TabIndex = 2;
			this.quarter1ListView.UseCompatibleStateImageBehavior = false;
			this.quarter1ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "#";
			this.columnHeader19.Width = 25;
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "Num.";
			this.columnHeader20.Width = 40;
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Naam";
			this.columnHeader21.Width = 153;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(92, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "KwartFinale A";
			// 
			// quarter0ListView
			// 
			this.quarter0ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
			this.quarter0ListView.FullRowSelect = true;
			this.quarter0ListView.HideSelection = false;
			this.quarter0ListView.Location = new System.Drawing.Point(6, 32);
			this.quarter0ListView.Name = "quarter0ListView";
			this.quarter0ListView.Size = new System.Drawing.Size(244, 90);
			this.quarter0ListView.TabIndex = 0;
			this.quarter0ListView.UseCompatibleStateImageBehavior = false;
			this.quarter0ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "#";
			this.columnHeader22.Width = 25;
			// 
			// columnHeader23
			// 
			this.columnHeader23.Text = "Num.";
			this.columnHeader23.Width = 40;
			// 
			// columnHeader24
			// 
			this.columnHeader24.Text = "Naam";
			this.columnHeader24.Width = 153;
			// 
			// semiFinalsGroup
			// 
			this.semiFinalsGroup.Controls.Add(this.semi1ListView);
			this.semiFinalsGroup.Controls.Add(this.label11);
			this.semiFinalsGroup.Controls.Add(this.semi0ListView);
			this.semiFinalsGroup.Controls.Add(this.label12);
			this.semiFinalsGroup.Enabled = false;
			this.semiFinalsGroup.Location = new System.Drawing.Point(3, 125);
			this.semiFinalsGroup.Name = "semiFinalsGroup";
			this.semiFinalsGroup.Size = new System.Drawing.Size(1008, 128);
			this.semiFinalsGroup.TabIndex = 2;
			this.semiFinalsGroup.TabStop = false;
			this.semiFinalsGroup.Text = "Halve finales";
			// 
			// semi1ListView
			// 
			this.semi1ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
			this.semi1ListView.FullRowSelect = true;
			this.semi1ListView.HideSelection = false;
			this.semi1ListView.Location = new System.Drawing.Point(625, 32);
			this.semi1ListView.Name = "semi1ListView";
			this.semi1ListView.Size = new System.Drawing.Size(244, 90);
			this.semi1ListView.TabIndex = 7;
			this.semi1ListView.UseCompatibleStateImageBehavior = false;
			this.semi1ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader25
			// 
			this.columnHeader25.Text = "#";
			this.columnHeader25.Width = 25;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "Num.";
			this.columnHeader26.Width = 40;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "Naam";
			this.columnHeader27.Width = 153;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(705, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "Halve Finale B";
			// 
			// semi0ListView
			// 
			this.semi0ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30});
			this.semi0ListView.FullRowSelect = true;
			this.semi0ListView.HideSelection = false;
			this.semi0ListView.Location = new System.Drawing.Point(125, 32);
			this.semi0ListView.Name = "semi0ListView";
			this.semi0ListView.Size = new System.Drawing.Size(244, 90);
			this.semi0ListView.TabIndex = 3;
			this.semi0ListView.UseCompatibleStateImageBehavior = false;
			this.semi0ListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader28
			// 
			this.columnHeader28.Text = "#";
			this.columnHeader28.Width = 25;
			// 
			// columnHeader29
			// 
			this.columnHeader29.Text = "Num.";
			this.columnHeader29.Width = 40;
			// 
			// columnHeader30
			// 
			this.columnHeader30.Text = "Naam";
			this.columnHeader30.Width = 153;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(204, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "Halve Finale A";
			// 
			// finalGroup
			// 
			this.finalGroup.Controls.Add(this.finalListView);
			this.finalGroup.Enabled = false;
			this.finalGroup.Location = new System.Drawing.Point(373, 3);
			this.finalGroup.Name = "finalGroup";
			this.finalGroup.Size = new System.Drawing.Size(258, 116);
			this.finalGroup.TabIndex = 3;
			this.finalGroup.TabStop = false;
			this.finalGroup.Text = "Finale";
			// 
			// finalListView
			// 
			this.finalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36});
			this.finalListView.FullRowSelect = true;
			this.finalListView.HideSelection = false;
			this.finalListView.Location = new System.Drawing.Point(6, 19);
			this.finalListView.Name = "finalListView";
			this.finalListView.Size = new System.Drawing.Size(244, 91);
			this.finalListView.TabIndex = 3;
			this.finalListView.UseCompatibleStateImageBehavior = false;
			this.finalListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader34
			// 
			this.columnHeader34.Text = "#";
			this.columnHeader34.Width = 25;
			// 
			// columnHeader35
			// 
			this.columnHeader35.Text = "Num.";
			this.columnHeader35.Width = 40;
			// 
			// columnHeader36
			// 
			this.columnHeader36.Text = "Naam";
			this.columnHeader36.Width = 153;
			// 
			// controlGroup
			// 
			this.controlGroup.Controls.Add(this.startRaceButton);
			this.controlGroup.Location = new System.Drawing.Point(3, 3);
			this.controlGroup.Name = "controlGroup";
			this.controlGroup.Size = new System.Drawing.Size(153, 71);
			this.controlGroup.TabIndex = 4;
			this.controlGroup.TabStop = false;
			this.controlGroup.Text = "Besturing";
			// 
			// startRaceButton
			// 
			this.startRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startRaceButton.Location = new System.Drawing.Point(6, 19);
			this.startRaceButton.Name = "startRaceButton";
			this.startRaceButton.Size = new System.Drawing.Size(141, 44);
			this.startRaceButton.TabIndex = 0;
			this.startRaceButton.Text = "&Start race";
			this.startRaceButton.UseVisualStyleBackColor = true;
			this.startRaceButton.Click += new System.EventHandler(this.startRaceButton_Click);
			// 
			// LeagueControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.controlGroup);
			this.Controls.Add(this.finalGroup);
			this.Controls.Add(this.semiFinalsGroup);
			this.Controls.Add(this.quarterFinalGroup);
			this.Controls.Add(this.pouleGroup);
			this.Name = "LeagueControl";
			this.Size = new System.Drawing.Size(1408, 804);
			this.Load += new System.EventHandler(this.LeagueControl_Load);
			this.pouleGroup.ResumeLayout(false);
			this.pouleGroup.PerformLayout();
			this.quarterFinalGroup.ResumeLayout(false);
			this.quarterFinalGroup.PerformLayout();
			this.semiFinalsGroup.ResumeLayout(false);
			this.semiFinalsGroup.PerformLayout();
			this.finalGroup.ResumeLayout(false);
			this.controlGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		private int lowerFinishCount = 0;
		private int upperFinishCount = 0;


		private int finishCount = 0;
		char[] displayString = new char[8];

		volatile Boolean AllowDisplayChange = true;
		volatile Boolean DisplayChangePending = false;


		/// <summary>
		/// a dictionary which holds dictionarys with listviews for each game phase
		/// </summary>
		private Dictionary<int, Dictionary<int, ListView>> gamePhaseLists;
		private Dictionary<int, ListView> pouleLists;
		private Dictionary<int, ListView> quarterFinalLists;
		private Dictionary<int, ListView> semiFinalList;
		private Dictionary<int, ListView> finalList;

		/// <summary>
		/// Defines the different game phases
		/// </summary>
		private enum GamePhases
		{
			Poules = 3,
			QuarterFinals = 2,
			SemiFinals = 1,
			Final = 0,
			Done = -1
		}

		GamePhases currentPhase = GamePhases.Poules;

		/// <summary>
		/// Constructor. Don't use this overload in your code. It's only for the visual studio designer.
		/// </summary>
		public LeagueControl()
		{

		}

		/// <summary>
		/// Adds all listviews to dictionarys
		/// </summary>
		private void createControlArrays()
		{
			pouleLists = new Dictionary<int,ListView>();
			quarterFinalLists = new Dictionary<int, ListView>();
			semiFinalList = new Dictionary<int, ListView>();
			finalList = new Dictionary<int, ListView>();
			gamePhaseLists = new Dictionary<int, Dictionary<int, ListView>>();

			pouleLists.Add(0, poule0ListView);
			pouleLists.Add(1, poule1ListView);
			pouleLists.Add(2, poule2ListView);
			pouleLists.Add(3, poule3ListView);

			quarterFinalLists.Add(0, quarter0ListView);
			quarterFinalLists.Add(1, quarter1ListView);
			quarterFinalLists.Add(2, quarter2ListView);
			quarterFinalLists.Add(3, quarter3ListView);

			semiFinalList.Add(0, semi0ListView);
			semiFinalList.Add(1, semi1ListView);

			finalList.Add(0, finalListView);

			gamePhaseLists.Add(0, finalList);
			gamePhaseLists.Add(1, semiFinalList);
			gamePhaseLists.Add(2, quarterFinalLists);
			gamePhaseLists.Add(3, pouleLists);
 

		}


		public LeagueControl(HARGame game, SerialSpriteCommHandler commHandler)
		{
			base.Game = game;
			base.CommHandler = commHandler;
			InitializeComponent();
			commHandler.DisplayAckReceived += new EventHandler(commHandler_DisplayAckReceived);
		}


		void commHandler_DisplayAckReceived(object sender, EventArgs e)
		{
			AllowDisplayChange = true;
			if (DisplayChangePending)
			{
				CommHandler.setDisplayString(new String(displayString));
				AllowDisplayChange = false;
				DisplayChangePending = false;
			}
		}


		private void startRaceButton_Click(object sender, EventArgs e)
		{
			lowerFinishCount = 1;
			upperFinishCount = 1;
			finishCount = 1;

			for (int i = 0; i < displayString.Length; i++)
			{
				displayString[i] = '-';
			}

			Boolean phaseDone = false;
			RaceResult tempRes;
			LeagueRaceSetup setup = createRaceUserList();

			PerformRaceForm frm = new PerformRaceForm();
			frm.TrackFinished += new TrackFinishedEventHandler(frm_TrackFinished);
			Dictionary<User, int> raceResults = frm.performRace(setup.UserList, AutoTrackPlacementModes.Sequential, false, CommHandler);
			frm.Dispose();

			// Save the results
			if (raceResults != null)
			{

				List<GameRound> rnds = dbComm.getGameRoundsForGame(base.Game);

				foreach (KeyValuePair<User, int> kvp in raceResults)
				{
					tempRes = new RaceResult(0, kvp.Key.ID, setup.RoundsByUserId[kvp.Key.ID].ID, base.Game.ID, kvp.Value);
					dbComm.addRaceResult(tempRes);
				}
			}
			else
			{
				return;
			}

			// Refresh the views and check if this round is done:
			phaseDone = fillPhaseLists((int)currentPhase);


			if (phaseDone)
			{
				// First switch to get the users
				switch (currentPhase)
				{
					case GamePhases.Poules:
						currentPhase = GamePhases.QuarterFinals;
						calculateQuarterFinalPhase();
						fillPhaseLists((int)currentPhase);
						pouleGroup.Enabled = false;
						quarterFinalGroup.Enabled = true;
						break;
					case GamePhases.QuarterFinals:
						currentPhase = GamePhases.SemiFinals;
						calculateSemiFinalPhase();
						fillPhaseLists((int)currentPhase);
						quarterFinalGroup.Enabled = false;
						semiFinalsGroup.Enabled = true;
						break;
					case GamePhases.SemiFinals:
						currentPhase = GamePhases.Final;
						calculateFinalPhase();
						fillPhaseLists((int)currentPhase);
						semiFinalsGroup.Enabled = false;
						finalGroup.Enabled = true;
						break;
					case GamePhases.Final:
						currentPhase = GamePhases.Done;
						dbComm.setGameState(base.Game, GameStates.Finished);
						finalGroup.Enabled = false;
						startRaceButton.Enabled = false;
						MessageBox.Show("Einde wedstrijd.\n\n" + ((User)gamePhaseLists[3][0].Items[0].Tag).firstName + " " + ((User)gamePhaseLists[3][0].Items[0].Tag).lastName + " heeft gewonnen!", "Einde wedstrijd!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						break;
					case GamePhases.Done:
						break;
				}
			}
		}


		void frm_TrackFinished(object sender, TrackFinishedEventArgs args)
		{
			// If there only one race
			if ((currentPhase == GamePhases.Poules) || (currentPhase == GamePhases.Final))
			{
				displayString[8 - args.TrackNumber] = finishCount.ToString()[0];
				finishCount++;
			}

			// If there are two races going on
			if((currentPhase == GamePhases.QuarterFinals) || (currentPhase == GamePhases.SemiFinals))
			{
				if ((args.TrackNumber == 1) || (args.TrackNumber == 2))
				{
					displayString[8 - args.TrackNumber] = lowerFinishCount.ToString()[0];
					lowerFinishCount++;
				}
				if ((args.TrackNumber == 7) || (args.TrackNumber == 8))
				{
					displayString[8 - args.TrackNumber] = upperFinishCount.ToString()[0];
					upperFinishCount++;
				}
			}

			if (AllowDisplayChange)
			{
				CommHandler.setDisplayString(new String(displayString));
				AllowDisplayChange = false;
			}
			else
			{
				DisplayChangePending = true;
			}

			
		}


		/// <summary>
		/// Creates a setup with users for the next race
		/// </summary>
		/// <returns>The setup for the next race</returns>
		LeagueRaceSetup createRaceUserList()
		{
			LeagueRaceSetup retVal = new LeagueRaceSetup();
			Dictionary<int, GameRound> rounds = getSubRounds((int) currentPhase);
			Boolean checkResult = false;
			List<User> usersFromRound;
			
			for(int i = 0; i < rounds.Count; i++)
			{
				// If this is the final, the two finalists should race in the middle of the track.
				if (currentPhase == GamePhases.Final)
				{
					retVal.UserList.Add(null);
					retVal.UserList.Add(null);
					retVal.UserList.Add(null);
				}


				checkResult = checkSubRoundDone(rounds[i]);
				if (checkResult == false)
				{
					usersFromRound = getUsersWithoutResults(rounds[i]);
					foreach (User us in usersFromRound)
					{
						retVal.UserList.Add(us);
						retVal.RoundsByUserId.Add(us.ID, rounds[i]);
					}

					// If this is tthe quarter or semi finals, allow two races to take place at once
					if ((currentPhase == GamePhases.QuarterFinals) || (currentPhase == GamePhases.SemiFinals))
					{
						if (retVal.UserList.Count < 3)
						{
							retVal.UserList.Add(null);		// Leave some free space between the two racing teams
							retVal.UserList.Add(null);
							retVal.UserList.Add(null);
							retVal.UserList.Add(null);
						}
						else
						{
							break;
						}

					}
					else
					{
						break;
					}
				}
			}

			
			return retVal;
		}

		/// <summary>
		/// Checks if all users in a subround have raceResults
		/// </summary>
		/// <param name="round">The round</param>
		/// <returns>true if all users have a result</returns>
		private Boolean checkSubRoundDone(GameRound round)
		{
			Boolean retVal = false;

			List<User> usersInRound = dbComm.getUsersByRound(round);
			List<RaceResult> results = dbComm.getRaceResults(round);

			retVal = (usersInRound.Count == results.Count);

			return retVal;
		}


		/// <summary>
		/// Gets all users without results in a specific round
		/// </summary>
		/// <param name="round">The round</param>
		/// <returns>a List with users</returns>
		private List<User> getUsersWithoutResults(GameRound round)
		{
			List<User> usersInRound = dbComm.getUsersByRound(round);
			List<RaceResult> results = dbComm.getRaceResults(round);

			// Iterate through the results and remove the user for each one from the userList
			foreach (RaceResult rr in results)
			{
				for (int i = 0; i < usersInRound.Count; i++)
				{
					if (rr.UserId == usersInRound[i].ID)
					{
						usersInRound.RemoveAt(i);
						break;
					}
				}
			}


			return usersInRound;
		}


		private void LeagueControl_Load(object sender, EventArgs e)
		{
			
			this.Parent.UseWaitCursor = true;
			this.SuspendLayout();
			createControlArrays();

			currentPhase = GamePhases.Poules;

			if (fillPhaseLists(3))		// Fill the poule Lists
			{
				currentPhase = GamePhases.QuarterFinals;
				pouleGroup.Enabled = false;
				quarterFinalGroup.Enabled = true;
			}

			if (fillPhaseLists(2))		// Fill the quarter finals
			{
				currentPhase = GamePhases.SemiFinals;
				quarterFinalGroup.Enabled = false;
				semiFinalsGroup.Enabled = true;
			}

			if(fillPhaseLists(1))		// Fill the semi finals Lists
			{
				currentPhase = GamePhases.Final;
				semiFinalsGroup.Enabled = false;
				finalGroup.Enabled = true;
			}

			if(fillPhaseLists(0))		// Fill the final list
			{
				currentPhase = GamePhases.Done;
				finalGroup.Enabled = false;
				startRaceButton.Enabled = false;
				MessageBox.Show("Wedstrijd is voltooid.\n\n" + ((User)gamePhaseLists[3][0].Items[0].Tag).firstName + " " + ((User)gamePhaseLists[3][0].Items[0].Tag).lastName + " heeft gewonnen!", "Einde wedstrijd!", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}

			this.ResumeLayout(true);
			this.Parent.UseWaitCursor = false;
		}


		/// <summary>
		/// Calculates the users for the quarter final phase, using the entries in the poule phase
		/// </summary>
		private void calculateQuarterFinalPhase()
		{
			Dictionary<int, GameRound> quarterFinalRounds = getSubRounds(2);
			// Add the number one and number two users from the poules to the quarter finals:
			dbComm.addUserToRound((User)gamePhaseLists[3][0].Items[0].Tag, quarterFinalRounds[0]);
			dbComm.addUserToRound((User)gamePhaseLists[3][1].Items[1].Tag, quarterFinalRounds[0]);

			dbComm.addUserToRound((User)gamePhaseLists[3][0].Items[1].Tag, quarterFinalRounds[1]);
			dbComm.addUserToRound((User)gamePhaseLists[3][1].Items[0].Tag, quarterFinalRounds[1]);

			dbComm.addUserToRound((User)gamePhaseLists[3][2].Items[0].Tag, quarterFinalRounds[2]);
			dbComm.addUserToRound((User)gamePhaseLists[3][3].Items[1].Tag, quarterFinalRounds[2]);

			dbComm.addUserToRound((User)gamePhaseLists[3][2].Items[1].Tag, quarterFinalRounds[3]);
			dbComm.addUserToRound((User)gamePhaseLists[3][3].Items[0].Tag, quarterFinalRounds[3]);
		}


		/// <summary>
		/// Calculates the users for the semi final phase, using the entries in the quarter final phase
		/// </summary>
		private void calculateSemiFinalPhase()
		{
			Dictionary<int, GameRound> semiFinalRounds = getSubRounds(1);
			// Add the number one users from the quarter finals to the semi finals:
			dbComm.addUserToRound((User)gamePhaseLists[2][0].Items[0].Tag, semiFinalRounds[0]);
			dbComm.addUserToRound((User)gamePhaseLists[2][1].Items[0].Tag, semiFinalRounds[0]);

			dbComm.addUserToRound((User)gamePhaseLists[2][2].Items[0].Tag, semiFinalRounds[1]);
			dbComm.addUserToRound((User)gamePhaseLists[2][3].Items[0].Tag, semiFinalRounds[1]);
		}


		/// <summary>
		/// Calculates the users for the semi final phase, using the entries in the quarter final phase
		/// </summary>
		private void calculateFinalPhase()
		{
			Dictionary<int, GameRound> finalRounds = getSubRounds(0);
			// Add the number one users from the quarter finals to the final:
			dbComm.addUserToRound((User)gamePhaseLists[1][0].Items[0].Tag, finalRounds[0]);
			dbComm.addUserToRound((User)gamePhaseLists[1][1].Items[0].Tag, finalRounds[0]);
		}



		/// <summary>
		/// Gets subRounds with the given round ID for this game
		/// </summary>
		/// <param name="subRoundNumber">The roundNumber</param>
		/// <returns>a dictionary with the suboundID's as key and the subround object as value</returns>
		private Dictionary<int, GameRound> getSubRounds(int RoundNumber)
		{
			Dictionary<int, GameRound> pouleRounds = new Dictionary<int, GameRound>();
			List<GameRound> allRounds = dbComm.getGameRoundsForGame(base.Game);

			// Sort out the poule rounds
			foreach (GameRound gr in allRounds)
			{
				if (gr.RoundNumber == RoundNumber)
				{
					pouleRounds.Add(gr.SubRoundNumber, gr);
				}
			}
			return pouleRounds;
		}



		/// <summary>
		/// Get all poule data from the database and fills the lists
		/// </summary>
		/// <param name="gamePhase">The game phase to be filled</param>
		/// <param name="nSubRounds">The number of subrounds in this game phase</param>
		/// <returns>true if all races for this game phase allready have been done</returns>
		private Boolean fillPhaseLists(int gamePhase)
		{
			//clear the listViews in this gamephase:
			foreach (ListView lv in gamePhaseLists[gamePhase].Values) lv.Items.Clear();

			Boolean allDone = false;

			Dictionary<int, GameRound> subRounds = getSubRounds(gamePhase);

			// a dictionary that holds the userLists sorted per subroundNumber (As key)
			Dictionary<int, Dictionary<int, User>> subRoundUsers = new Dictionary<int, Dictionary<int, User>>();

			List<User> singleSubRoundUserList;

			foreach (KeyValuePair<int, GameRound> kvp in subRounds)
			{
				subRoundUsers.Add(kvp.Key, new Dictionary<int, User>());
				singleSubRoundUserList = dbComm.getUsersByRound(kvp.Value);
				foreach (User us in singleSubRoundUserList)
				{
					subRoundUsers[kvp.Key].Add(us.ID, us);
				}
			}

			// Now we have a dictionary (subroundID as key) with dictionary's (userID as key) for each subRound
			// Now we create the same type of Dictionary for the results:
			Dictionary<int, List<RaceResult>> subRoundRaceResults = new Dictionary<int,List<RaceResult>>();

			foreach (GameRound gr in subRounds.Values)
			{
				subRoundRaceResults.Add(gr.SubRoundNumber, dbComm.getRaceResults(gr));
			}

			// Now sort the lists with raceResults for each subRound
			for (int i = 0; i < subRounds.Count; i++)
			{
				subRoundRaceResults[i] = base.sortResults(subRoundRaceResults[i]);
			}

			
			// First fill the Listviews with users who have results
			foreach (KeyValuePair<int, List<RaceResult>> kvp in subRoundRaceResults)
			{
				for (int i = 0; i < kvp.Value.Count; i++)
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = (i + 1).ToString();
					
					lvi.SubItems.Add(subRoundUsers[kvp.Key][kvp.Value[i].UserId].startNumber.ToString());
					lvi.SubItems.Add(subRoundUsers[kvp.Key][kvp.Value[i].UserId].firstName + " " + subRoundUsers[kvp.Key][kvp.Value[i].UserId].lastName);
					lvi.Tag = subRoundUsers[kvp.Key][kvp.Value[i].UserId];
					gamePhaseLists[gamePhase][kvp.Key].Items.Add(lvi);

					// Also delete this user for the other list, so it won't be added twice when we add he rest of the users later on
					subRoundUsers[kvp.Key].Remove(kvp.Value[i].UserId);
					allDone = true;
				}
			}

			// Now add the rest of the users to the lists
			foreach (KeyValuePair<int, Dictionary<int, User>> kvp in subRoundUsers)
			{
				foreach(User us in kvp.Value.Values)
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = "";		// No text, since there's no score
					lvi.SubItems.Add(us.startNumber.ToString());
					lvi.SubItems.Add(us.firstName + " " + us.lastName);
					lvi.Tag = us;
					gamePhaseLists[gamePhase][kvp.Key].Items.Add(lvi);
					allDone = false;		// If there's just a single user who hasn't got a result, we're not done with this round.
				}

			}

			return allDone;
		}


	}
}
