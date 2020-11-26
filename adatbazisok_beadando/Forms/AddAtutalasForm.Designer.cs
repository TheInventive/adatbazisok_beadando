
namespace adatbazisok_beadando.Forms
{
    partial class AddAtutalasForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mennyiseg = new System.Windows.Forms.TextBox();
            this.megbizoAzonosito = new System.Windows.Forms.TextBox();
            this.celszamlaSzamlaszama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eredetszamlaSzamlaszama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.valuta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mennyiseg
            // 
            this.mennyiseg.Location = new System.Drawing.Point(12, 123);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(352, 22);
            this.mennyiseg.TabIndex = 0;
            // 
            // megbizoAzonosito
            // 
            this.megbizoAzonosito.Location = new System.Drawing.Point(242, 60);
            this.megbizoAzonosito.Name = "megbizoAzonosito";
            this.megbizoAzonosito.Size = new System.Drawing.Size(134, 22);
            this.megbizoAzonosito.TabIndex = 2;
            // 
            // celszamlaSzamlaszama
            // 
            this.celszamlaSzamlaszama.Location = new System.Drawing.Point(542, 60);
            this.celszamlaSzamlaszama.Name = "celszamlaSzamlaszama";
            this.celszamlaSzamlaszama.Size = new System.Drawing.Size(340, 22);
            this.celszamlaSzamlaszama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mennyiség";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Megbízó azonosító";
            // 
            // eredetszamlaSzamlaszama
            // 
            this.eredetszamlaSzamlaszama.Location = new System.Drawing.Point(542, 123);
            this.eredetszamlaSzamlaszama.Name = "eredetszamlaSzamlaszama";
            this.eredetszamlaSzamlaszama.Size = new System.Drawing.Size(340, 22);
            this.eredetszamlaSzamlaszama.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Célszámla számlaszáma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eredetszámla számlaszáma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Küldés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendData);
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(12, 60);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 22);
            this.datum.TabIndex = 46;
            // 
            // valuta
            // 
            this.valuta.Location = new System.Drawing.Point(381, 123);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(87, 22);
            this.valuta.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Valuta";
            // 
            // AddAtutalasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 403);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valuta);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eredetszamlaSzamlaszama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.celszamlaSzamlaszama);
            this.Controls.Add(this.megbizoAzonosito);
            this.Controls.Add(this.mennyiseg);
            this.Name = "AddAtutalasForm";
            this.Text = "AddAtutalasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mennyiseg;
        private System.Windows.Forms.TextBox megbizoAzonosito;
        private System.Windows.Forms.TextBox celszamlaSzamlaszama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eredetszamlaSzamlaszama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.TextBox valuta;
        private System.Windows.Forms.Label label6;
    }
}