namespace DatabaseProject
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tbp_Loot = new System.Windows.Forms.TabPage();
			this.tbp_Namensgenerator = new System.Windows.Forms.TabPage();
			this.tbp_WuerfelUtility = new System.Windows.Forms.TabPage();
			this.tbc_MainControl = new System.Windows.Forms.TabControl();
			this.tbp_Gegner = new System.Windows.Forms.TabPage();
			this.uc_WuerfelUtility = new DatabaseProject.WuerfelUtility();
			this.uc_Namensgenerator = new DatabaseProject.Namensgenerator();
			this.loot1 = new DatabaseProject.Sources.Forms.Loot();
			this.gegner1 = new DatabaseProject.Sources.Forms.Gegner();
			this.tbp_Loot.SuspendLayout();
			this.tbp_Namensgenerator.SuspendLayout();
			this.tbp_WuerfelUtility.SuspendLayout();
			this.tbc_MainControl.SuspendLayout();
			this.tbp_Gegner.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbp_Loot
			// 
			this.tbp_Loot.Controls.Add(this.loot1);
			this.tbp_Loot.Location = new System.Drawing.Point(28, 4);
			this.tbp_Loot.Name = "tbp_Loot";
			this.tbp_Loot.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Loot.Size = new System.Drawing.Size(762, 541);
			this.tbp_Loot.TabIndex = 2;
			this.tbp_Loot.Text = "Loot";
			this.tbp_Loot.UseVisualStyleBackColor = true;
			// 
			// tbp_Namensgenerator
			// 
			this.tbp_Namensgenerator.Controls.Add(this.uc_Namensgenerator);
			this.tbp_Namensgenerator.Location = new System.Drawing.Point(28, 4);
			this.tbp_Namensgenerator.Name = "tbp_Namensgenerator";
			this.tbp_Namensgenerator.Size = new System.Drawing.Size(762, 541);
			this.tbp_Namensgenerator.TabIndex = 1;
			this.tbp_Namensgenerator.Text = "Namensgenerator";
			this.tbp_Namensgenerator.UseVisualStyleBackColor = true;
			// 
			// tbp_WuerfelUtility
			// 
			this.tbp_WuerfelUtility.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tbp_WuerfelUtility.Controls.Add(this.uc_WuerfelUtility);
			this.tbp_WuerfelUtility.Location = new System.Drawing.Point(28, 4);
			this.tbp_WuerfelUtility.Name = "tbp_WuerfelUtility";
			this.tbp_WuerfelUtility.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_WuerfelUtility.Size = new System.Drawing.Size(762, 541);
			this.tbp_WuerfelUtility.TabIndex = 0;
			this.tbp_WuerfelUtility.Text = "Würfel-Utility";
			// 
			// tbc_MainControl
			// 
			this.tbc_MainControl.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tbc_MainControl.Controls.Add(this.tbp_WuerfelUtility);
			this.tbc_MainControl.Controls.Add(this.tbp_Namensgenerator);
			this.tbc_MainControl.Controls.Add(this.tbp_Loot);
			this.tbc_MainControl.Controls.Add(this.tbp_Gegner);
			this.tbc_MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbc_MainControl.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbc_MainControl.ItemSize = new System.Drawing.Size(24, 24);
			this.tbc_MainControl.Location = new System.Drawing.Point(0, 0);
			this.tbc_MainControl.Multiline = true;
			this.tbc_MainControl.Name = "tbc_MainControl";
			this.tbc_MainControl.SelectedIndex = 0;
			this.tbc_MainControl.Size = new System.Drawing.Size(794, 549);
			this.tbc_MainControl.TabIndex = 0;
			// 
			// tbp_Gegner
			// 
			this.tbp_Gegner.Controls.Add(this.gegner1);
			this.tbp_Gegner.Location = new System.Drawing.Point(28, 4);
			this.tbp_Gegner.Name = "tbp_Gegner";
			this.tbp_Gegner.Size = new System.Drawing.Size(762, 541);
			this.tbp_Gegner.TabIndex = 3;
			this.tbp_Gegner.Text = "Gegner";
			this.tbp_Gegner.UseVisualStyleBackColor = true;
			// 
			// uc_WuerfelUtility
			// 
			this.uc_WuerfelUtility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_WuerfelUtility.BackgroundImage")));
			this.uc_WuerfelUtility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.uc_WuerfelUtility.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uc_WuerfelUtility.Location = new System.Drawing.Point(3, 3);
			this.uc_WuerfelUtility.Name = "uc_WuerfelUtility";
			this.uc_WuerfelUtility.Size = new System.Drawing.Size(756, 535);
			this.uc_WuerfelUtility.TabIndex = 0;
			// 
			// uc_Namensgenerator
			// 
			this.uc_Namensgenerator.BackColor = System.Drawing.Color.Maroon;
			this.uc_Namensgenerator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_Namensgenerator.BackgroundImage")));
			this.uc_Namensgenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.uc_Namensgenerator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uc_Namensgenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uc_Namensgenerator.ForeColor = System.Drawing.Color.Maroon;
			this.uc_Namensgenerator.Location = new System.Drawing.Point(0, 0);
			this.uc_Namensgenerator.Name = "uc_Namensgenerator";
			this.uc_Namensgenerator.Size = new System.Drawing.Size(762, 541);
			this.uc_Namensgenerator.TabIndex = 0;
			// 
			// loot1
			// 
			this.loot1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loot1.Location = new System.Drawing.Point(3, 3);
			this.loot1.Margin = new System.Windows.Forms.Padding(5);
			this.loot1.Name = "loot1";
			this.loot1.Size = new System.Drawing.Size(756, 535);
			this.loot1.TabIndex = 0;
			// 
			// gegner1
			// 
			this.gegner1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gegner1.Location = new System.Drawing.Point(0, 0);
			this.gegner1.Margin = new System.Windows.Forms.Padding(5);
			this.gegner1.Name = "gegner1";
			this.gegner1.Size = new System.Drawing.Size(762, 541);
			this.gegner1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(794, 549);
			this.Controls.Add(this.tbc_MainControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.tbp_Loot.ResumeLayout(false);
			this.tbp_Namensgenerator.ResumeLayout(false);
			this.tbp_WuerfelUtility.ResumeLayout(false);
			this.tbc_MainControl.ResumeLayout(false);
			this.tbp_Gegner.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tbp_Loot;
		private Sources.Forms.Loot loot1;
		private System.Windows.Forms.TabPage tbp_Namensgenerator;
		private Namensgenerator uc_Namensgenerator;
		private System.Windows.Forms.TabPage tbp_WuerfelUtility;
		private WuerfelUtility uc_WuerfelUtility;
		public System.Windows.Forms.TabControl tbc_MainControl;
		private System.Windows.Forms.TabPage tbp_Gegner;
		private Sources.Forms.Gegner gegner1;
	}
}

