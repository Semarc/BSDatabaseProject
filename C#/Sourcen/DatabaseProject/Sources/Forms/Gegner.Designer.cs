
namespace DatabaseProject.Sources.Forms
{
	partial class Gegner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gegner));
            this.cbxGegnerTyp = new System.Windows.Forms.ComboBox();
            this.cbxGegnerEnviroment = new System.Windows.Forms.ComboBox();
            this.cbxGegnerCombatRating = new System.Windows.Forms.ComboBox();
            this.btnGegnerZiehen = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxGegnerTyp
            // 
            this.cbxGegnerTyp.BackColor = System.Drawing.Color.Linen;
            this.cbxGegnerTyp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGegnerTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGegnerTyp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxGegnerTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGegnerTyp.FormattingEnabled = true;
            this.cbxGegnerTyp.Location = new System.Drawing.Point(83, 76);
            this.cbxGegnerTyp.Name = "cbxGegnerTyp";
            this.cbxGegnerTyp.Size = new System.Drawing.Size(121, 24);
            this.cbxGegnerTyp.TabIndex = 0;
            // 
            // cbxGegnerEnviroment
            // 
            this.cbxGegnerEnviroment.BackColor = System.Drawing.Color.Linen;
            this.cbxGegnerEnviroment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGegnerEnviroment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGegnerEnviroment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxGegnerEnviroment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGegnerEnviroment.FormattingEnabled = true;
            this.cbxGegnerEnviroment.Location = new System.Drawing.Point(83, 136);
            this.cbxGegnerEnviroment.Name = "cbxGegnerEnviroment";
            this.cbxGegnerEnviroment.Size = new System.Drawing.Size(121, 24);
            this.cbxGegnerEnviroment.TabIndex = 1;
            // 
            // cbxGegnerCombatRating
            // 
            this.cbxGegnerCombatRating.BackColor = System.Drawing.Color.Linen;
            this.cbxGegnerCombatRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxGegnerCombatRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGegnerCombatRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxGegnerCombatRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGegnerCombatRating.FormattingEnabled = true;
            this.cbxGegnerCombatRating.Location = new System.Drawing.Point(83, 202);
            this.cbxGegnerCombatRating.Name = "cbxGegnerCombatRating";
            this.cbxGegnerCombatRating.Size = new System.Drawing.Size(121, 24);
            this.cbxGegnerCombatRating.TabIndex = 2;
            // 
            // btnGegnerZiehen
            // 
            this.btnGegnerZiehen.BackColor = System.Drawing.Color.Transparent;
            this.btnGegnerZiehen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGegnerZiehen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGegnerZiehen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGegnerZiehen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGegnerZiehen.Location = new System.Drawing.Point(84, 250);
            this.btnGegnerZiehen.Name = "btnGegnerZiehen";
            this.btnGegnerZiehen.Size = new System.Drawing.Size(120, 36);
            this.btnGegnerZiehen.TabIndex = 3;
            this.btnGegnerZiehen.Text = "Kreieren";
            this.btnGegnerZiehen.UseVisualStyleBackColor = false;
            this.btnGegnerZiehen.Click += new System.EventHandler(this.GegnerZiehen);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(268, 97);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(69, 20);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Gegner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "WÄHLE DEINEN UNTERGANG!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gegnertyp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Umgebung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Schwierigkeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(10, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Du kannst die Felder nach Belieben kombinieren.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(10, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(502, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Du kannst auch nichts auswählen und dem Wahnsinn freien lauf lassen...";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(10, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(532, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Falls rechts kein Gegner erscheint, traut sich wohl niemand gegen Deine Gruppe an" +
    "zutreten!";
            // 
            // Gegner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.btnGegnerZiehen);
            this.Controls.Add(this.cbxGegnerCombatRating);
            this.Controls.Add(this.cbxGegnerEnviroment);
            this.Controls.Add(this.cbxGegnerTyp);
            this.Name = "Gegner";
            this.Size = new System.Drawing.Size(564, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxGegnerTyp;
		private System.Windows.Forms.ComboBox cbxGegnerEnviroment;
		private System.Windows.Forms.ComboBox cbxGegnerCombatRating;
		private System.Windows.Forms.Button btnGegnerZiehen;
		private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
