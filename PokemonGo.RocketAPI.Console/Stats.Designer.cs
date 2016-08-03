﻿namespace PokemonGo.RocketAPI.Console
{
	partial class Stats
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.levelbar = new System.Windows.Forms.ProgressBar();
			this.label9 = new System.Windows.Forms.Label();
			this.progress = new System.Windows.Forms.Label();
			this.items = new System.Windows.Forms.Label();
			this.pokemon = new System.Windows.Forms.Label();
			this.evolvecount = new System.Windows.Forms.Label();
			this.catchrate = new System.Windows.Forms.Label();
			this.xprate = new System.Windows.Forms.Label();
			this.stardust = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.Label();
			this.toggleconsole = new System.Windows.Forms.Button();
			this.togglelist = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.levelbar);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.progress);
			this.groupBox1.Controls.Add(this.items);
			this.groupBox1.Controls.Add(this.pokemon);
			this.groupBox1.Controls.Add(this.evolvecount);
			this.groupBox1.Controls.Add(this.catchrate);
			this.groupBox1.Controls.Add(this.xprate);
			this.groupBox1.Controls.Add(this.stardust);
			this.groupBox1.Controls.Add(this.username);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 267);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stats";
			// 
			// levelbar
			// 
			this.levelbar.Location = new System.Drawing.Point(126, 238);
			this.levelbar.Name = "levelbar";
			this.levelbar.Size = new System.Drawing.Size(128, 23);
			this.levelbar.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 242);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Progress to next Level";
			// 
			// progress
			// 
			this.progress.AutoSize = true;
			this.progress.Location = new System.Drawing.Point(7, 222);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(53, 13);
			this.progress.TabIndex = 7;
			this.progress.Text = "Unknown";
			// 
			// items
			// 
			this.items.AutoSize = true;
			this.items.Location = new System.Drawing.Point(7, 124);
			this.items.Name = "items";
			this.items.Size = new System.Drawing.Size(35, 13);
			this.items.TabIndex = 6;
			this.items.Text = "Items:";
			// 
			// pokemon
			// 
			this.pokemon.AutoSize = true;
			this.pokemon.Location = new System.Drawing.Point(7, 111);
			this.pokemon.Name = "pokemon";
			this.pokemon.Size = new System.Drawing.Size(55, 13);
			this.pokemon.TabIndex = 5;
			this.pokemon.Text = "Pokemon:";
			// 
			// evolvecount
			// 
			this.evolvecount.AutoSize = true;
			this.evolvecount.Location = new System.Drawing.Point(7, 85);
			this.evolvecount.Name = "evolvecount";
			this.evolvecount.Size = new System.Drawing.Size(103, 13);
			this.evolvecount.TabIndex = 4;
			this.evolvecount.Text = "Pokemon to Evolve:";
			// 
			// catchrate
			// 
			this.catchrate.AutoSize = true;
			this.catchrate.Location = new System.Drawing.Point(7, 59);
			this.catchrate.Name = "catchrate";
			this.catchrate.Size = new System.Drawing.Size(83, 13);
			this.catchrate.TabIndex = 3;
			this.catchrate.Text = "Pokemon/Hour:";
			// 
			// xprate
			// 
			this.xprate.AutoSize = true;
			this.xprate.Location = new System.Drawing.Point(7, 46);
			this.xprate.Name = "xprate";
			this.xprate.Size = new System.Drawing.Size(52, 13);
			this.xprate.TabIndex = 2;
			this.xprate.Text = "XP/Hour:";
			// 
			// stardust
			// 
			this.stardust.AutoSize = true;
			this.stardust.Location = new System.Drawing.Point(7, 137);
			this.stardust.Name = "stardust";
			this.stardust.Size = new System.Drawing.Size(49, 13);
			this.stardust.TabIndex = 1;
			this.stardust.Text = "Stardust:";
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Location = new System.Drawing.Point(7, 20);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(32, 13);
			this.username.TabIndex = 0;
			this.username.Text = "User:";
			// 
			// toggleconsole
			// 
			this.toggleconsole.Location = new System.Drawing.Point(8, 285);
			this.toggleconsole.Name = "toggleconsole";
			this.toggleconsole.Size = new System.Drawing.Size(110, 23);
			this.toggleconsole.TabIndex = 2;
			this.toggleconsole.Text = "Show/Hide Console";
			this.toggleconsole.UseVisualStyleBackColor = true;
			this.toggleconsole.Click += new System.EventHandler(this.toggleconsole_Click);
			// 
			// togglelist
			// 
			this.togglelist.Location = new System.Drawing.Point(158, 285);
			this.togglelist.Name = "togglelist";
			this.togglelist.Size = new System.Drawing.Size(114, 23);
			this.togglelist.TabIndex = 3;
			this.togglelist.Text = "Show/Hide PokeList";
			this.togglelist.UseVisualStyleBackColor = true;
			this.togglelist.Click += new System.EventHandler(this.togglelist_Click);
			// 
			// Stats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 316);
			this.Controls.Add(this.togglelist);
			this.Controls.Add(this.toggleconsole);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "Stats";
			this.Text = "Stats";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stats_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ProgressBar levelbar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label progress;
		private System.Windows.Forms.Label items;
		private System.Windows.Forms.Label pokemon;
		private System.Windows.Forms.Label evolvecount;
		private System.Windows.Forms.Label catchrate;
		private System.Windows.Forms.Label xprate;
		private System.Windows.Forms.Label stardust;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.Button toggleconsole;
		private System.Windows.Forms.Button togglelist;
	}
}