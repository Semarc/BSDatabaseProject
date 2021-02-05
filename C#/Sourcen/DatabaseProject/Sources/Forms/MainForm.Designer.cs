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
            this.tbp_WuerfelUtility = new System.Windows.Forms.TabPage();
            this.tbc_MainControl = new System.Windows.Forms.TabControl();
            this.tbp_Namensgenerator = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uc_WuerfelUtility = new DatabaseProject.WuerfelUtility();
            this.uc_Namensgenerator = new DatabaseProject.Namensgenerator();
            this.loot1 = new DatabaseProject.Sources.Forms.Loot();
            this.tbp_WuerfelUtility.SuspendLayout();
            this.tbc_MainControl.SuspendLayout();
            this.tbp_Namensgenerator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbp_WuerfelUtility
            // 
            this.tbp_WuerfelUtility.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbp_WuerfelUtility.Controls.Add(this.uc_WuerfelUtility);
            this.tbp_WuerfelUtility.Location = new System.Drawing.Point(28, 4);
            this.tbp_WuerfelUtility.Name = "tbp_WuerfelUtility";
            this.tbp_WuerfelUtility.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_WuerfelUtility.Size = new System.Drawing.Size(630, 458);
            this.tbp_WuerfelUtility.TabIndex = 0;
            this.tbp_WuerfelUtility.Text = "Würfel-Utility";
            this.tbp_WuerfelUtility.Click += new System.EventHandler(this.tbp_WuerfelUtility_Click);
            // 
            // tbc_MainControl
            // 
            this.tbc_MainControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbc_MainControl.Controls.Add(this.tbp_WuerfelUtility);
            this.tbc_MainControl.Controls.Add(this.tbp_Namensgenerator);
            this.tbc_MainControl.Controls.Add(this.tabPage1);
            this.tbc_MainControl.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_MainControl.ItemSize = new System.Drawing.Size(24, 24);
            this.tbc_MainControl.Location = new System.Drawing.Point(2, 1);
            this.tbc_MainControl.Multiline = true;
            this.tbc_MainControl.Name = "tbc_MainControl";
            this.tbc_MainControl.SelectedIndex = 0;
            this.tbc_MainControl.Size = new System.Drawing.Size(662, 466);
            this.tbc_MainControl.TabIndex = 0;
            // 
            // tbp_Namensgenerator
            // 
            this.tbp_Namensgenerator.Controls.Add(this.uc_Namensgenerator);
            this.tbp_Namensgenerator.Location = new System.Drawing.Point(28, 4);
            this.tbp_Namensgenerator.Name = "tbp_Namensgenerator";
            this.tbp_Namensgenerator.Size = new System.Drawing.Size(630, 458);
            this.tbp_Namensgenerator.TabIndex = 1;
            this.tbp_Namensgenerator.Text = "Namensgenerator";
            this.tbp_Namensgenerator.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loot1);
            this.tabPage1.Location = new System.Drawing.Point(28, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 458);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uc_WuerfelUtility
            // 
            this.uc_WuerfelUtility.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uc_WuerfelUtility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_WuerfelUtility.BackgroundImage")));
            this.uc_WuerfelUtility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uc_WuerfelUtility.Location = new System.Drawing.Point(0, 1);
            this.uc_WuerfelUtility.Name = "uc_WuerfelUtility";
            this.uc_WuerfelUtility.Size = new System.Drawing.Size(631, 459);
            this.uc_WuerfelUtility.TabIndex = 0;
            this.uc_WuerfelUtility.Load += new System.EventHandler(this.uc_WuerfelUtility_Load);
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
            this.uc_Namensgenerator.Size = new System.Drawing.Size(630, 458);
            this.uc_Namensgenerator.TabIndex = 0;
            this.uc_Namensgenerator.Load += new System.EventHandler(this.uc_Namensgenerator_Load);
            // 
            // loot1
            // 
            this.loot1.Location = new System.Drawing.Point(0, -4);
            this.loot1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loot1.Name = "loot1";
            this.loot1.Size = new System.Drawing.Size(630, 462);
            this.loot1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(663, 467);
            this.Controls.Add(this.tbc_MainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tbp_WuerfelUtility.ResumeLayout(false);
            this.tbc_MainControl.ResumeLayout(false);
            this.tbp_Namensgenerator.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tbp_WuerfelUtility;
		private WuerfelUtility uc_WuerfelUtility;
		private System.Windows.Forms.TabPage tbp_Namensgenerator;
		private Namensgenerator uc_Namensgenerator;
        public System.Windows.Forms.TabControl tbc_MainControl;
        private System.Windows.Forms.TabPage tabPage1;
        private Sources.Forms.Loot loot1;
    }
}

