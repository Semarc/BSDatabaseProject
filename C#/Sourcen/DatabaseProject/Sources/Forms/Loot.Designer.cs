
namespace DatabaseProject.Sources.Forms
{
    partial class Loot
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.typ = new System.Windows.Forms.ComboBox();
			this.Seltenheit = new System.Windows.Forms.ComboBox();
			this.btn_BeuteGenerieren = new System.Windows.Forms.Button();
			this.Beute = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// typ
			// 
			this.typ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typ.FormattingEnabled = true;
			this.typ.Location = new System.Drawing.Point(48, 117);
			this.typ.Name = "typ";
			this.typ.Size = new System.Drawing.Size(121, 21);
			this.typ.TabIndex = 0;
			// 
			// Seltenheit
			// 
			this.Seltenheit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Seltenheit.FormattingEnabled = true;
			this.Seltenheit.Location = new System.Drawing.Point(48, 208);
			this.Seltenheit.Name = "Seltenheit";
			this.Seltenheit.Size = new System.Drawing.Size(121, 21);
			this.Seltenheit.TabIndex = 1;
			// 
			// btn_BeuteGenerieren
			// 
			this.btn_BeuteGenerieren.Location = new System.Drawing.Point(246, 115);
			this.btn_BeuteGenerieren.Name = "btn_BeuteGenerieren";
			this.btn_BeuteGenerieren.Size = new System.Drawing.Size(75, 23);
			this.btn_BeuteGenerieren.TabIndex = 2;
			this.btn_BeuteGenerieren.Text = "Beute Generieren";
			this.btn_BeuteGenerieren.UseVisualStyleBackColor = true;
			this.btn_BeuteGenerieren.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Beute
			// 
			this.Beute.AutoSize = true;
			this.Beute.Location = new System.Drawing.Point(263, 226);
			this.Beute.Name = "Beute";
			this.Beute.Size = new System.Drawing.Size(35, 13);
			this.Beute.TabIndex = 3;
			this.Beute.Text = "Beute";
			// 
			// Loot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Beute);
			this.Controls.Add(this.btn_BeuteGenerieren);
			this.Controls.Add(this.Seltenheit);
			this.Controls.Add(this.typ);
			this.Name = "Loot";
			this.Size = new System.Drawing.Size(659, 471);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.ComboBox Seltenheit;
        private System.Windows.Forms.Button btn_BeuteGenerieren;
        private System.Windows.Forms.Label Beute;
    }
}
