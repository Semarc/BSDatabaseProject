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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Namensgenerator));
            this.cbx_VolkAuswahl = new System.Windows.Forms.ComboBox();
            this.btn_NachnameGenerieren = new System.Windows.Forms.Button();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.btn_VornamenGenerieren = new System.Windows.Forms.Button();
            this.cbx_GeschlechtAuswahl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_VolkAuswahl
            // 
            this.cbx_VolkAuswahl.BackColor = System.Drawing.Color.LightBlue;
            this.cbx_VolkAuswahl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_VolkAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_VolkAuswahl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_VolkAuswahl.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_VolkAuswahl.ForeColor = System.Drawing.Color.Black;
            this.cbx_VolkAuswahl.FormattingEnabled = true;
            this.cbx_VolkAuswahl.Location = new System.Drawing.Point(162, 142);
            this.cbx_VolkAuswahl.Name = "cbx_VolkAuswahl";
            this.cbx_VolkAuswahl.Size = new System.Drawing.Size(106, 38);
            this.cbx_VolkAuswahl.Sorted = true;
            this.cbx_VolkAuswahl.TabIndex = 0;

            // 
            // btn_NachnameGenerieren
            // 
            this.btn_NachnameGenerieren.BackColor = System.Drawing.Color.Transparent;
            this.btn_NachnameGenerieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NachnameGenerieren.FlatAppearance.BorderSize = 0;
            this.btn_NachnameGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NachnameGenerieren.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NachnameGenerieren.ForeColor = System.Drawing.Color.Black;
            this.btn_NachnameGenerieren.Location = new System.Drawing.Point(395, 249);
            this.btn_NachnameGenerieren.Name = "btn_NachnameGenerieren";
            this.btn_NachnameGenerieren.Size = new System.Drawing.Size(196, 52);
            this.btn_NachnameGenerieren.TabIndex = 1;
            this.btn_NachnameGenerieren.Text = "GetNachname";
            this.btn_NachnameGenerieren.UseVisualStyleBackColor = false;
            this.btn_NachnameGenerieren.Click += new System.EventHandler(this.NachnamenButtonClick);
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nachname.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nachname.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nachname.Location = new System.Drawing.Point(413, 344);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(95, 42);
            this.lbl_Nachname.TabIndex = 2;
            this.lbl_Nachname.Text = "label1";
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vorname.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vorname.ForeColor = System.Drawing.Color.Black;
            this.lbl_Vorname.Location = new System.Drawing.Point(257, 344);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(95, 42);
            this.lbl_Vorname.TabIndex = 4;
            this.lbl_Vorname.Text = "label2";
            // 
            // btn_VornamenGenerieren
            // 
            this.btn_VornamenGenerieren.BackColor = System.Drawing.Color.Transparent;
            this.btn_VornamenGenerieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VornamenGenerieren.FlatAppearance.BorderSize = 0;
            this.btn_VornamenGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VornamenGenerieren.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VornamenGenerieren.ForeColor = System.Drawing.Color.Black;
            this.btn_VornamenGenerieren.Location = new System.Drawing.Point(212, 249);
            this.btn_VornamenGenerieren.Name = "btn_VornamenGenerieren";
            this.btn_VornamenGenerieren.Size = new System.Drawing.Size(177, 52);
            this.btn_VornamenGenerieren.TabIndex = 3;
            this.btn_VornamenGenerieren.Text = "GetVorname";
            this.btn_VornamenGenerieren.UseVisualStyleBackColor = false;
            this.btn_VornamenGenerieren.Click += new System.EventHandler(this.VornamenButtonClick);
            // 
            // cbx_GeschlechtAuswahl
            // 
            this.cbx_GeschlechtAuswahl.BackColor = System.Drawing.Color.LightBlue;
            this.cbx_GeschlechtAuswahl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_GeschlechtAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GeschlechtAuswahl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_GeschlechtAuswahl.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_GeschlechtAuswahl.ForeColor = System.Drawing.Color.Black;
            this.cbx_GeschlechtAuswahl.FormattingEnabled = true;
            this.cbx_GeschlechtAuswahl.Location = new System.Drawing.Point(503, 142);
            this.cbx_GeschlechtAuswahl.Name = "cbx_GeschlechtAuswahl";
            this.cbx_GeschlechtAuswahl.Size = new System.Drawing.Size(57, 38);
            this.cbx_GeschlechtAuswahl.Sorted = true;
            this.cbx_GeschlechtAuswahl.TabIndex = 5;
 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "WÄHLE DEINEN NAMEN!";
  
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(332, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geschlecht";
            // 
            // Namensgenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_GeschlechtAuswahl);
            this.Controls.Add(this.lbl_Vorname);
            this.Controls.Add(this.btn_VornamenGenerieren);
            this.Controls.Add(this.lbl_Nachname);
            this.Controls.Add(this.btn_NachnameGenerieren);
            this.Controls.Add(this.cbx_VolkAuswahl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Namensgenerator";
            this.Size = new System.Drawing.Size(650, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbx_VolkAuswahl;
		private System.Windows.Forms.Button btn_NachnameGenerieren;
		private System.Windows.Forms.Label lbl_Nachname;
		private System.Windows.Forms.Label lbl_Vorname;
		private System.Windows.Forms.Button btn_VornamenGenerieren;
		private System.Windows.Forms.ComboBox cbx_GeschlechtAuswahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
