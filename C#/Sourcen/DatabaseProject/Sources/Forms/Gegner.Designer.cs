
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
			this.GegnerTyp = new System.Windows.Forms.ComboBox();
			this.GegnerEnviroment = new System.Windows.Forms.ComboBox();
			this.GegnerCombatRating = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// GegnerTyp
			// 
			this.GegnerTyp.FormattingEnabled = true;
			this.GegnerTyp.Location = new System.Drawing.Point(161, 79);
			this.GegnerTyp.Name = "GegnerTyp";
			this.GegnerTyp.Size = new System.Drawing.Size(121, 21);
			this.GegnerTyp.TabIndex = 0;
			// 
			// GegnerEnviroment
			// 
			this.GegnerEnviroment.FormattingEnabled = true;
			this.GegnerEnviroment.Location = new System.Drawing.Point(161, 131);
			this.GegnerEnviroment.Name = "GegnerEnviroment";
			this.GegnerEnviroment.Size = new System.Drawing.Size(121, 21);
			this.GegnerEnviroment.TabIndex = 1;
			// 
			// GegnerCombatRating
			// 
			this.GegnerCombatRating.FormattingEnabled = true;
			this.GegnerCombatRating.Location = new System.Drawing.Point(161, 179);
			this.GegnerCombatRating.Name = "GegnerCombatRating";
			this.GegnerCombatRating.Size = new System.Drawing.Size(121, 21);
			this.GegnerCombatRating.TabIndex = 2;
			// 
			// Gegner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GegnerCombatRating);
			this.Controls.Add(this.GegnerEnviroment);
			this.Controls.Add(this.GegnerTyp);
			this.Name = "Gegner";
			this.Size = new System.Drawing.Size(744, 448);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox GegnerTyp;
		private System.Windows.Forms.ComboBox GegnerEnviroment;
		private System.Windows.Forms.ComboBox GegnerCombatRating;
	}
}
