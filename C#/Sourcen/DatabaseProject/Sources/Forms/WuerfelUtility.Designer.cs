namespace DatabaseProject
{
	partial class WuerfelUtility
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WuerfelUtility));
			this.nud_WuerfelAnzahl = new System.Windows.Forms.NumericUpDown();
			this.cbx_WuerfelTyp = new System.Windows.Forms.ComboBox();
			this.nud_WuerfelBonus = new System.Windows.Forms.NumericUpDown();
			this.btn_Wuerfeln = new System.Windows.Forms.Button();
			this.lbl_WuerfelResult = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nud_WuerfelAnzahl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_WuerfelBonus)).BeginInit();
			this.SuspendLayout();
			// 
			// nud_WuerfelAnzahl
			// 
			this.nud_WuerfelAnzahl.BackColor = System.Drawing.Color.LemonChiffon;
			this.nud_WuerfelAnzahl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nud_WuerfelAnzahl.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nud_WuerfelAnzahl.ForeColor = System.Drawing.Color.Black;
			this.nud_WuerfelAnzahl.Location = new System.Drawing.Point(201, 124);
			this.nud_WuerfelAnzahl.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.nud_WuerfelAnzahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_WuerfelAnzahl.Name = "nud_WuerfelAnzahl";
			this.nud_WuerfelAnzahl.Size = new System.Drawing.Size(67, 33);
			this.nud_WuerfelAnzahl.TabIndex = 1;
			this.nud_WuerfelAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_WuerfelAnzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbx_WuerfelTyp
			// 
			this.cbx_WuerfelTyp.BackColor = System.Drawing.Color.LemonChiffon;
			this.cbx_WuerfelTyp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbx_WuerfelTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_WuerfelTyp.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_WuerfelTyp.FormattingEnabled = true;
			this.cbx_WuerfelTyp.Location = new System.Drawing.Point(201, 191);
			this.cbx_WuerfelTyp.Name = "cbx_WuerfelTyp";
			this.cbx_WuerfelTyp.Size = new System.Drawing.Size(67, 33);
			this.cbx_WuerfelTyp.TabIndex = 2;
			// 
			// nud_WuerfelBonus
			// 
			this.nud_WuerfelBonus.BackColor = System.Drawing.Color.LemonChiffon;
			this.nud_WuerfelBonus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nud_WuerfelBonus.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nud_WuerfelBonus.Location = new System.Drawing.Point(197, 254);
			this.nud_WuerfelBonus.Name = "nud_WuerfelBonus";
			this.nud_WuerfelBonus.Size = new System.Drawing.Size(71, 37);
			this.nud_WuerfelBonus.TabIndex = 3;
			this.nud_WuerfelBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_Wuerfeln
			// 
			this.btn_Wuerfeln.BackColor = System.Drawing.Color.LemonChiffon;
			this.btn_Wuerfeln.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Wuerfeln.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Wuerfeln.Location = new System.Drawing.Point(39, 309);
			this.btn_Wuerfeln.Name = "btn_Wuerfeln";
			this.btn_Wuerfeln.Size = new System.Drawing.Size(114, 40);
			this.btn_Wuerfeln.TabIndex = 4;
			this.btn_Wuerfeln.Text = "Würfeln";
			this.btn_Wuerfeln.UseVisualStyleBackColor = false;
			this.btn_Wuerfeln.Click += new System.EventHandler(this.evh_btnWuerfelnClick);
			// 
			// lbl_WuerfelResult
			// 
			this.lbl_WuerfelResult.AutoSize = true;
			this.lbl_WuerfelResult.BackColor = System.Drawing.Color.Transparent;
			this.lbl_WuerfelResult.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_WuerfelResult.ForeColor = System.Drawing.Color.Black;
			this.lbl_WuerfelResult.Location = new System.Drawing.Point(3, 369);
			this.lbl_WuerfelResult.Name = "lbl_WuerfelResult";
			this.lbl_WuerfelResult.Size = new System.Drawing.Size(145, 46);
			this.lbl_WuerfelResult.TabIndex = 5;
			this.lbl_WuerfelResult.Text = "Ergebnis";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 30);
			this.label1.TabIndex = 10;
			this.label1.Text = "Anzahl ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 30);
			this.label2.TabIndex = 11;
			this.label2.Text = "Art";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 30);
			this.label3.TabIndex = 12;
			this.label3.Text = "Bonusschaden?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(444, 42);
			this.label4.TabIndex = 13;
			this.label4.Text = "WÄHLE DEINE WÜRFEL!";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// WuerfelUtility
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_WuerfelResult);
			this.Controls.Add(this.btn_Wuerfeln);
			this.Controls.Add(this.nud_WuerfelBonus);
			this.Controls.Add(this.cbx_WuerfelTyp);
			this.Controls.Add(this.nud_WuerfelAnzahl);
			this.Name = "WuerfelUtility";
			this.Size = new System.Drawing.Size(650, 470);
			((System.ComponentModel.ISupportInitialize)(this.nud_WuerfelAnzahl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_WuerfelBonus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nud_WuerfelAnzahl;
		private System.Windows.Forms.ComboBox cbx_WuerfelTyp;
		private System.Windows.Forms.NumericUpDown nud_WuerfelBonus;
		private System.Windows.Forms.Button btn_Wuerfeln;
		private System.Windows.Forms.Label lbl_WuerfelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
