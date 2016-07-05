namespace Zeilenumbruch
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.RichTextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Vorher";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 44);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(346, 216);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "[Hier Text einfügen]";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(13, 263);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Nachher";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(13, 283);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(346, 230);
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Text = "";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(10, 529);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(119, 17);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Breite in Zeichen:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(136, 528);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(36, 20);
            this.TextBox3.TabIndex = 5;
            this.TextBox3.Text = "25";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(265, 529);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 23);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Umbrechen";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(-2, -2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(196, 23);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Datei Öffnen";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(181, -2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(199, 23);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Datei Speichern";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Textdateien|*.txt";
            this.openFileDialog1.Title = "Textdatei öffnen";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Textdateien|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 560);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Textumbruch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn1;
        public System.Windows.Forms.RichTextBox TextBox1;
        public System.Windows.Forms.RichTextBox TextBox2;
        public System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

