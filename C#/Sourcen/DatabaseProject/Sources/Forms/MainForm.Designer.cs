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
			this.uc_WuerfelUtility = new DatabaseProject.WuerfelUtility();
			this.tbc_MainControl = new System.Windows.Forms.TabControl();
			this.tbp_Namensgenerator = new System.Windows.Forms.TabPage();
			this.uc_Namensgenerator = new DatabaseProject.Namensgenerator();
			this.tbp_WuerfelUtility.SuspendLayout();
			this.tbc_MainControl.SuspendLayout();
			this.tbp_Namensgenerator.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbp_WuerfelUtility
			// 
			this.tbp_WuerfelUtility.Controls.Add(this.uc_WuerfelUtility);
			this.tbp_WuerfelUtility.Location = new System.Drawing.Point(4, 22);
			this.tbp_WuerfelUtility.Name = "tbp_WuerfelUtility";
			this.tbp_WuerfelUtility.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_WuerfelUtility.Size = new System.Drawing.Size(993, 578);
			this.tbp_WuerfelUtility.TabIndex = 0;
			this.tbp_WuerfelUtility.Text = "Würfel-Utility";
			this.tbp_WuerfelUtility.UseVisualStyleBackColor = true;
			// 
			// uc_WuerfelUtility
			// 
			this.uc_WuerfelUtility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uc_WuerfelUtility.BackgroundImage")));
			this.uc_WuerfelUtility.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uc_WuerfelUtility.Location = new System.Drawing.Point(3, 3);
			this.uc_WuerfelUtility.Name = "uc_WuerfelUtility";
			this.uc_WuerfelUtility.Size = new System.Drawing.Size(987, 572);
			this.uc_WuerfelUtility.TabIndex = 0;
			// 
			// tbc_MainControl
			// 
			this.tbc_MainControl.Controls.Add(this.tbp_WuerfelUtility);
			this.tbc_MainControl.Controls.Add(this.tbp_Namensgenerator);
			this.tbc_MainControl.Location = new System.Drawing.Point(12, 12);
			this.tbc_MainControl.Name = "tbc_MainControl";
			this.tbc_MainControl.SelectedIndex = 0;
			this.tbc_MainControl.Size = new System.Drawing.Size(1001, 604);
			this.tbc_MainControl.TabIndex = 0;
			// 
			// tbp_Namensgenerator
			// 
			this.tbp_Namensgenerator.Controls.Add(this.uc_Namensgenerator);
			this.tbp_Namensgenerator.Location = new System.Drawing.Point(4, 22);
			this.tbp_Namensgenerator.Name = "tbp_Namensgenerator";
			this.tbp_Namensgenerator.Size = new System.Drawing.Size(993, 578);
			this.tbp_Namensgenerator.TabIndex = 1;
			this.tbp_Namensgenerator.Text = "Namensgenerator";
			this.tbp_Namensgenerator.UseVisualStyleBackColor = true;
			// 
			// uc_Namensgenerator
			// 
			this.uc_Namensgenerator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uc_Namensgenerator.Location = new System.Drawing.Point(0, 0);
			this.uc_Namensgenerator.Name = "uc_Namensgenerator";
			this.uc_Namensgenerator.Size = new System.Drawing.Size(993, 578);
			this.uc_Namensgenerator.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 628);
			this.Controls.Add(this.tbc_MainControl);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.tbp_WuerfelUtility.ResumeLayout(false);
			this.tbc_MainControl.ResumeLayout(false);
			this.tbp_Namensgenerator.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Namensgenerator namensgenerator1;
		private System.Windows.Forms.TabPage tbp_WuerfelUtility;
		private WuerfelUtility uc_WuerfelUtility;
		private System.Windows.Forms.TabControl tbc_MainControl;
		private System.Windows.Forms.TabPage tbp_Namensgenerator;
		private Namensgenerator uc_Namensgenerator;
	}
}

