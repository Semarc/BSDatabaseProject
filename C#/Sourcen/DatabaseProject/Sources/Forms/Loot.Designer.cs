
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loot));
            this.typ = new System.Windows.Forms.ComboBox();
            this.Seltenheit = new System.Windows.Forms.ComboBox();
            this.btn_BeuteGenerieren = new System.Windows.Forms.Button();
            this.Beute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typ
            // 
            this.typ.BackColor = System.Drawing.Color.Linen;
            this.typ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(253, 105);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(121, 24);
            this.typ.TabIndex = 0;
            // 
            // Seltenheit
            // 
            this.Seltenheit.BackColor = System.Drawing.Color.Linen;
            this.Seltenheit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seltenheit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Seltenheit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Seltenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seltenheit.FormattingEnabled = true;
            this.Seltenheit.Location = new System.Drawing.Point(253, 194);
            this.Seltenheit.Name = "Seltenheit";
            this.Seltenheit.Size = new System.Drawing.Size(121, 24);
            this.Seltenheit.TabIndex = 1;
            // 
            // btn_BeuteGenerieren
            // 
            this.btn_BeuteGenerieren.BackColor = System.Drawing.Color.Transparent;
            this.btn_BeuteGenerieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BeuteGenerieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BeuteGenerieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BeuteGenerieren.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_BeuteGenerieren.Location = new System.Drawing.Point(376, 147);
            this.btn_BeuteGenerieren.Name = "btn_BeuteGenerieren";
            this.btn_BeuteGenerieren.Size = new System.Drawing.Size(121, 34);
            this.btn_BeuteGenerieren.TabIndex = 2;
            this.btn_BeuteGenerieren.Text = "Plündern";
            this.btn_BeuteGenerieren.UseVisualStyleBackColor = false;
            this.btn_BeuteGenerieren.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Beute
            // 
            this.Beute.AutoSize = true;
            this.Beute.BackColor = System.Drawing.Color.Transparent;
            this.Beute.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beute.ForeColor = System.Drawing.Color.Linen;
            this.Beute.Location = new System.Drawing.Point(115, 310);
            this.Beute.Name = "Beute";
            this.Beute.Size = new System.Drawing.Size(95, 33);
            this.Beute.TabIndex = 3;
            this.Beute.Text = "Beute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "WÄHLE DEINE BEUTE!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seltenheit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Typ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Loot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
