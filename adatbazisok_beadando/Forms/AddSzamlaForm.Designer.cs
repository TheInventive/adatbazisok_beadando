﻿
namespace adatbazisok_beadando.Forms
{
    partial class AddSzamlaForm
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
            this.szamlaszam = new System.Windows.Forms.TextBox();
            this.valuta = new System.Windows.Forms.TextBox();
            this.penz = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.szerzodesDatuma = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.kuldes = new System.Windows.Forms.Button();
            this.valutaListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // szamlaszam
            // 
            this.szamlaszam.Location = new System.Drawing.Point(12, 61);
            this.szamlaszam.Name = "szamlaszam";
            this.szamlaszam.Size = new System.Drawing.Size(308, 22);
            this.szamlaszam.TabIndex = 0;
            // 
            // valuta
            // 
            this.valuta.Location = new System.Drawing.Point(12, 121);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(100, 22);
            this.valuta.TabIndex = 2;
            // 
            // penz
            // 
            this.penz.Location = new System.Drawing.Point(132, 121);
            this.penz.Name = "penz";
            this.penz.Size = new System.Drawing.Size(188, 22);
            this.penz.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Számlaszám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Valuta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Pénz";
            // 
            // szerzodesDatuma
            // 
            this.szerzodesDatuma.Location = new System.Drawing.Point(394, 59);
            this.szerzodesDatuma.Name = "szerzodesDatuma";
            this.szerzodesDatuma.Size = new System.Drawing.Size(200, 22);
            this.szerzodesDatuma.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Szerződés dátuma";
            // 
            // kuldes
            // 
            this.kuldes.Location = new System.Drawing.Point(394, 111);
            this.kuldes.Name = "kuldes";
            this.kuldes.Size = new System.Drawing.Size(170, 42);
            this.kuldes.TabIndex = 50;
            this.kuldes.Text = "Küldés";
            this.kuldes.UseVisualStyleBackColor = true;
            this.kuldes.Click += new System.EventHandler(this.SendData);
            // 
            // valutaListbox
            // 
            this.valutaListbox.FormattingEnabled = true;
            this.valutaListbox.ItemHeight = 16;
            this.valutaListbox.Items.AddRange(new object[] {
            "HUF",
            "USD",
            "EUR"});
            this.valutaListbox.Location = new System.Drawing.Point(12, 149);
            this.valutaListbox.Name = "valutaListbox";
            this.valutaListbox.Size = new System.Drawing.Size(100, 84);
            this.valutaListbox.TabIndex = 51;
            this.valutaListbox.SelectedIndexChanged += new System.EventHandler(this.ValutaListbox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 42);
            this.button1.TabIndex = 52;
            this.button1.Text = "Küldés és bezárás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendAndClose);
            // 
            // AddSzamlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valutaListbox);
            this.Controls.Add(this.kuldes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.szerzodesDatuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.penz);
            this.Controls.Add(this.valuta);
            this.Controls.Add(this.szamlaszam);
            this.Name = "AddSzamlaForm";
            this.Text = "AddSzamlaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox szamlaszam;
        private System.Windows.Forms.TextBox valuta;
        private System.Windows.Forms.TextBox penz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker szerzodesDatuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kuldes;
        private System.Windows.Forms.ListBox valutaListbox;
        private System.Windows.Forms.Button button1;
    }
}