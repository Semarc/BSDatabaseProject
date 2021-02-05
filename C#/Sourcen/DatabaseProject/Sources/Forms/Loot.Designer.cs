
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
            this.button1 = new System.Windows.Forms.Button();
            this.Beute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(48, 117);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(121, 21);
            this.typ.TabIndex = 0;
            this.typ.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Seltenheit
            // 
            this.Seltenheit.FormattingEnabled = true;
            this.Seltenheit.Location = new System.Drawing.Point(48, 208);
            this.Seltenheit.Name = "Seltenheit";
            this.Seltenheit.Size = new System.Drawing.Size(121, 21);
            this.Seltenheit.TabIndex = 1;
            this.Seltenheit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Beute
            // 
            this.Beute.AutoSize = true;
            this.Beute.Location = new System.Drawing.Point(338, 228);
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
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Beute;
    }
}
