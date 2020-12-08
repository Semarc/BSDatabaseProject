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
			this.tbc_MainControl = new System.Windows.Forms.TabControl();
			this.tbp_WuerfelUtility = new System.Windows.Forms.TabPage();
			this.uc_WuerfelUtility = new DatabaseProject.WuerfelUtility();
			this.Namensgenerator = new System.Windows.Forms.TabPage();
			this.namensgenerator1 = new DatabaseProject.Sources.Forms.Namensgenerator();
			this.tbc_MainControl.SuspendLayout();
			this.tbp_WuerfelUtility.SuspendLayout();
			this.Namensgenerator.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbc_MainControl
			// 
			this.tbc_MainControl.Controls.Add(this.tbp_WuerfelUtility);
			this.tbc_MainControl.Controls.Add(this.Namensgenerator);
			this.tbc_MainControl.Location = new System.Drawing.Point(12, 12);
			this.tbc_MainControl.Name = "tbc_MainControl";
			this.tbc_MainControl.SelectedIndex = 0;
			this.tbc_MainControl.Size = new System.Drawing.Size(1001, 604);
			this.tbc_MainControl.TabIndex = 0;
			// 
			// tbp_WuerfelUtility
			// 
			this.tbp_WuerfelUtility.Controls.Add(this.uc_WuerfelUtility);
			this.tbp_WuerfelUtility.Location = new System.Drawing.Point(4, 22);
			this.tbp_WuerfelUtility.Name = "tbp_WuerfelUtility";
			this.tbp_WuerfelUtility.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_WuerfelUtility.Size = new System.Drawing.Size(993, 578);
			this.tbp_WuerfelUtility.TabIndex = 0;
			this.tbp_WuerfelUtility.Text = "tabPage1";
			this.tbp_WuerfelUtility.UseVisualStyleBackColor = true;
			// 
			// uc_WuerfelUtility
			// 
			this.uc_WuerfelUtility.Location = new System.Drawing.Point(6, 6);
			this.uc_WuerfelUtility.Name = "uc_WuerfelUtility";
			this.uc_WuerfelUtility.Size = new System.Drawing.Size(675, 459);
			this.uc_WuerfelUtility.TabIndex = 0;
			// 
			// Namensgenerator
			// 
			this.Namensgenerator.Controls.Add(this.namensgenerator1);
			this.Namensgenerator.Location = new System.Drawing.Point(4, 22);
			this.Namensgenerator.Name = "Namensgenerator";
			this.Namensgenerator.Size = new System.Drawing.Size(993, 578);
			this.Namensgenerator.TabIndex = 1;
			this.Namensgenerator.Text = "tabPage1";
			this.Namensgenerator.UseVisualStyleBackColor = true;
			// 
			// namensgenerator1
			// 
			this.namensgenerator1.Location = new System.Drawing.Point(124, 69);
			this.namensgenerator1.Name = "namensgenerator1";
			this.namensgenerator1.Size = new System.Drawing.Size(691, 424);
			this.namensgenerator1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 628);
			this.Controls.Add(this.tbc_MainControl);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.tbc_MainControl.ResumeLayout(false);
			this.tbp_WuerfelUtility.ResumeLayout(false);
			this.Namensgenerator.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbc_MainControl;
		private System.Windows.Forms.TabPage tbp_WuerfelUtility;
		private WuerfelUtility uc_WuerfelUtility;
		private System.Windows.Forms.TabPage Namensgenerator;
		private Sources.Forms.Namensgenerator namensgenerator1;
	}
}

