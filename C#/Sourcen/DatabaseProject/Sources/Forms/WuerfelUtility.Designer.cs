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
            ((System.ComponentModel.ISupportInitialize)(this.nud_WuerfelAnzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WuerfelBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_WuerfelAnzahl
            // 
            this.nud_WuerfelAnzahl.BackColor = System.Drawing.Color.LemonChiffon;
            this.nud_WuerfelAnzahl.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_WuerfelAnzahl.ForeColor = System.Drawing.Color.Black;
            this.nud_WuerfelAnzahl.Location = new System.Drawing.Point(34, 189);
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
            this.nud_WuerfelAnzahl.Size = new System.Drawing.Size(53, 28);
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
            this.cbx_WuerfelTyp.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_WuerfelTyp.FormattingEnabled = true;
            this.cbx_WuerfelTyp.Location = new System.Drawing.Point(112, 188);
            this.cbx_WuerfelTyp.Name = "cbx_WuerfelTyp";
            this.cbx_WuerfelTyp.Size = new System.Drawing.Size(53, 29);
            this.cbx_WuerfelTyp.TabIndex = 2;
            // 
            // nud_WuerfelBonus
            // 
            this.nud_WuerfelBonus.BackColor = System.Drawing.Color.LemonChiffon;
            this.nud_WuerfelBonus.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_WuerfelBonus.Location = new System.Drawing.Point(200, 188);
            this.nud_WuerfelBonus.Name = "nud_WuerfelBonus";
            this.nud_WuerfelBonus.Size = new System.Drawing.Size(53, 28);
            this.nud_WuerfelBonus.TabIndex = 3;
            // 
            // btn_Wuerfeln
            // 
            this.btn_Wuerfeln.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Wuerfeln.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Wuerfeln.Location = new System.Drawing.Point(78, 265);
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
            this.lbl_WuerfelResult.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WuerfelResult.Location = new System.Drawing.Point(27, 79);
            this.lbl_WuerfelResult.Name = "lbl_WuerfelResult";
            this.lbl_WuerfelResult.Size = new System.Drawing.Size(138, 42);
            this.lbl_WuerfelResult.TabIndex = 5;
            this.lbl_WuerfelResult.Text = "Ergebnis";
            // 
            // WuerfelUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lbl_WuerfelResult);
            this.Controls.Add(this.btn_Wuerfeln);
            this.Controls.Add(this.nud_WuerfelBonus);
            this.Controls.Add(this.cbx_WuerfelTyp);
            this.Controls.Add(this.nud_WuerfelAnzahl);
            this.Name = "WuerfelUtility";
            this.Size = new System.Drawing.Size(588, 409);
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
	}
}
