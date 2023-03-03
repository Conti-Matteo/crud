namespace crud
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextB1 = new System.Windows.Forms.TextBox();
            this.TextB3 = new System.Windows.Forms.TextBox();
            this.TextB4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextB2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textB5 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(562, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carrello";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "inseire un prodotto da aggiungere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "inserire un prodotto da ricercare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inserire il nuovo prodotto";
            // 
            // TextB1
            // 
            this.TextB1.Location = new System.Drawing.Point(273, 17);
            this.TextB1.Name = "TextB1";
            this.TextB1.Size = new System.Drawing.Size(152, 20);
            this.TextB1.TabIndex = 6;
            this.TextB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextB3
            // 
            this.TextB3.Location = new System.Drawing.Point(273, 100);
            this.TextB3.Name = "TextB3";
            this.TextB3.Size = new System.Drawing.Size(152, 20);
            this.TextB3.TabIndex = 7;
            // 
            // TextB4
            // 
            this.TextB4.Location = new System.Drawing.Point(273, 137);
            this.TextB4.Name = "TextB4";
            this.TextB4.Size = new System.Drawing.Size(152, 20);
            this.TextB4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "inserire il prezzo del prodotto";
            // 
            // TextB2
            // 
            this.TextB2.Location = new System.Drawing.Point(273, 55);
            this.TextB2.Name = "TextB2";
            this.TextB2.Size = new System.Drawing.Size(152, 20);
            this.TextB2.TabIndex = 10;
            this.TextB2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "inserimento del prodotto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "ricerca del prodotto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 57);
            this.button3.TabIndex = 13;
            this.button3.Text = "modifica del prodotto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textB5
            // 
            this.textB5.Location = new System.Drawing.Point(273, 176);
            this.textB5.Name = "textB5";
            this.textB5.Size = new System.Drawing.Size(152, 20);
            this.textB5.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Inserire il nuovo prezzo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textB5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextB2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextB4);
            this.Controls.Add(this.TextB3);
            this.Controls.Add(this.TextB1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextB1;
        private System.Windows.Forms.TextBox TextB3;
        private System.Windows.Forms.TextBox TextB4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textB5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
    }
}

