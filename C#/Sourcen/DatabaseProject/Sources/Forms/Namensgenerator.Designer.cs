namespace DatabaseProject
{
	partial class Namensgenerator
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
			this.cbx_VolkAuswahl = new System.Windows.Forms.ComboBox();
			this.btn_NachnameGenerieren = new System.Windows.Forms.Button();
			this.lbl_NachnameGenerieren = new System.Windows.Forms.Label();
			this.lbl_Vorname = new System.Windows.Forms.Label();
			this.btn_VornamenGenerieren = new System.Windows.Forms.Button();
			this.cbx_GeschlechtAuswahl = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cbx_VolkAuswahl
			// 
			this.cbx_VolkAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_VolkAuswahl.FormattingEnabled = true;
			this.cbx_VolkAuswahl.Location = new System.Drawing.Point(89, 82);
			this.cbx_VolkAuswahl.Name = "cbx_VolkAuswahl";
			this.cbx_VolkAuswahl.Size = new System.Drawing.Size(121, 21);
			this.cbx_VolkAuswahl.Sorted = true;
			this.cbx_VolkAuswahl.TabIndex = 0;
			// 
			// btn_NachnameGenerieren
			// 
			this.btn_NachnameGenerieren.Location = new System.Drawing.Point(89, 122);
			this.btn_NachnameGenerieren.Name = "btn_NachnameGenerieren";
			this.btn_NachnameGenerieren.Size = new System.Drawing.Size(75, 23);
			this.btn_NachnameGenerieren.TabIndex = 1;
			this.btn_NachnameGenerieren.Text = "button1";
			this.btn_NachnameGenerieren.UseVisualStyleBackColor = true;
			this.btn_NachnameGenerieren.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_NachnameGenerieren
			// 
			this.lbl_NachnameGenerieren.AutoSize = true;
			this.lbl_NachnameGenerieren.Location = new System.Drawing.Point(175, 127);
			this.lbl_NachnameGenerieren.Name = "lbl_NachnameGenerieren";
			this.lbl_NachnameGenerieren.Size = new System.Drawing.Size(35, 13);
			this.lbl_NachnameGenerieren.TabIndex = 2;
			this.lbl_NachnameGenerieren.Text = "label1";
			// 
			// lbl_Vorname
			// 
			this.lbl_Vorname.AutoSize = true;
			this.lbl_Vorname.Location = new System.Drawing.Point(175, 212);
			this.lbl_Vorname.Name = "lbl_Vorname";
			this.lbl_Vorname.Size = new System.Drawing.Size(35, 13);
			this.lbl_Vorname.TabIndex = 4;
			this.lbl_Vorname.Text = "label2";
			// 
			// btn_VornamenGenerieren
			// 
			this.btn_VornamenGenerieren.Location = new System.Drawing.Point(89, 207);
			this.btn_VornamenGenerieren.Name = "btn_VornamenGenerieren";
			this.btn_VornamenGenerieren.Size = new System.Drawing.Size(75, 23);
			this.btn_VornamenGenerieren.TabIndex = 3;
			this.btn_VornamenGenerieren.Text = "button2";
			this.btn_VornamenGenerieren.UseVisualStyleBackColor = true;
			// 
			// cbx_GeschlechtAuswahl
			// 
			this.cbx_GeschlechtAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_GeschlechtAuswahl.FormattingEnabled = true;
			this.cbx_GeschlechtAuswahl.Location = new System.Drawing.Point(89, 180);
			this.cbx_GeschlechtAuswahl.Name = "cbx_GeschlechtAuswahl";
			this.cbx_GeschlechtAuswahl.Size = new System.Drawing.Size(121, 21);
			this.cbx_GeschlechtAuswahl.Sorted = true;
			this.cbx_GeschlechtAuswahl.TabIndex = 5;
			// 
			// Namensgenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbx_GeschlechtAuswahl);
			this.Controls.Add(this.lbl_Vorname);
			this.Controls.Add(this.btn_VornamenGenerieren);
			this.Controls.Add(this.lbl_NachnameGenerieren);
			this.Controls.Add(this.btn_NachnameGenerieren);
			this.Controls.Add(this.cbx_VolkAuswahl);
			this.Name = "Namensgenerator";
			this.Size = new System.Drawing.Size(691, 424);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbx_VolkAuswahl;
		private System.Windows.Forms.Button btn_NachnameGenerieren;
		private System.Windows.Forms.Label lbl_NachnameGenerieren;
		private System.Windows.Forms.Label lbl_Vorname;
		private System.Windows.Forms.Button btn_VornamenGenerieren;
		private System.Windows.Forms.ComboBox cbx_GeschlechtAuswahl;
	}
}
