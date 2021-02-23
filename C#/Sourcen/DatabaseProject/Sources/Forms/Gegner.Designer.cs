
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
			this.cbxGegnerTyp = new System.Windows.Forms.ComboBox();
			this.cbxGegnerEnviroment = new System.Windows.Forms.ComboBox();
			this.cbxGegnerCombatRating = new System.Windows.Forms.ComboBox();
			this.btnGegnerZiehen = new System.Windows.Forms.Button();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// GegnerTyp
			// 
			this.cbxGegnerTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxGegnerTyp.FormattingEnabled = true;
			this.cbxGegnerTyp.Location = new System.Drawing.Point(161, 79);
			this.cbxGegnerTyp.Name = "GegnerTyp";
			this.cbxGegnerTyp.Size = new System.Drawing.Size(121, 21);
			this.cbxGegnerTyp.TabIndex = 0;
			// 
			// GegnerEnviroment
			// 
			this.cbxGegnerEnviroment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxGegnerEnviroment.FormattingEnabled = true;
			this.cbxGegnerEnviroment.Location = new System.Drawing.Point(161, 131);
			this.cbxGegnerEnviroment.Name = "GegnerEnviroment";
			this.cbxGegnerEnviroment.Size = new System.Drawing.Size(121, 21);
			this.cbxGegnerEnviroment.TabIndex = 1;
			// 
			// GegnerCombatRating
			// 
			this.cbxGegnerCombatRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxGegnerCombatRating.FormattingEnabled = true;
			this.cbxGegnerCombatRating.Location = new System.Drawing.Point(161, 179);
			this.cbxGegnerCombatRating.Name = "GegnerCombatRating";
			this.cbxGegnerCombatRating.Size = new System.Drawing.Size(121, 21);
			this.cbxGegnerCombatRating.TabIndex = 2;
			// 
			// button1
			// 
			this.btnGegnerZiehen.Location = new System.Drawing.Point(349, 94);
			this.btnGegnerZiehen.Name = "button1";
			this.btnGegnerZiehen.Size = new System.Drawing.Size(75, 23);
			this.btnGegnerZiehen.TabIndex = 3;
			this.btnGegnerZiehen.Text = "Gegner Generieren";
			this.btnGegnerZiehen.UseVisualStyleBackColor = true;
			this.btnGegnerZiehen.Click += new System.EventHandler(this.GegnerZiehen);
			// 
			// label1
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Location = new System.Drawing.Point(349, 186);
			this.ResultLabel.Name = "label1";
			this.ResultLabel.Size = new System.Drawing.Size(42, 13);
			this.ResultLabel.TabIndex = 4;
			this.ResultLabel.Text = "Gegner";
			// 
			// Gegner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.btnGegnerZiehen);
			this.Controls.Add(this.cbxGegnerCombatRating);
			this.Controls.Add(this.cbxGegnerEnviroment);
			this.Controls.Add(this.cbxGegnerTyp);
			this.Name = "Gegner";
			this.Size = new System.Drawing.Size(564, 383);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxGegnerTyp;
		private System.Windows.Forms.ComboBox cbxGegnerEnviroment;
		private System.Windows.Forms.ComboBox cbxGegnerCombatRating;
		private System.Windows.Forms.Button btnGegnerZiehen;
		private System.Windows.Forms.Label ResultLabel;
	}
}
