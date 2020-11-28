
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
            this.kuldes = new System.Windows.Forms.Button();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.valuta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.celListBox = new System.Windows.Forms.ListBox();
            this.eredetListBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.megbizoListbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mennyiseg
            // 
            this.mennyiseg.Location = new System.Drawing.Point(12, 106);
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.Size = new System.Drawing.Size(352, 22);
            this.mennyiseg.TabIndex = 0;
            // 
            // megbizoAzonosito
            // 
            this.megbizoAzonosito.Location = new System.Drawing.Point(587, 106);
            this.megbizoAzonosito.Name = "megbizoAzonosito";
            this.megbizoAzonosito.Size = new System.Drawing.Size(79, 22);
            this.megbizoAzonosito.TabIndex = 2;
            // 
            // celszamlaSzamlaszama
            // 
            this.celszamlaSzamlaszama.Location = new System.Drawing.Point(461, 284);
            this.celszamlaSzamlaszama.Name = "celszamlaSzamlaszama";
            this.celszamlaSzamlaszama.Size = new System.Drawing.Size(340, 22);
            this.celszamlaSzamlaszama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mennyiség";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Megbízó azonosító";
            // 
            // eredetszamlaSzamlaszama
            // 
            this.eredetszamlaSzamlaszama.Location = new System.Drawing.Point(461, 180);
            this.eredetszamlaSzamlaszama.Name = "eredetszamlaSzamlaszama";
            this.eredetszamlaSzamlaszama.Size = new System.Drawing.Size(340, 22);
            this.eredetszamlaSzamlaszama.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Célszámla számlaszáma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eredetszámla számlaszáma";
            // 
            // kuldes
            // 
            this.kuldes.Location = new System.Drawing.Point(461, 344);
            this.kuldes.Name = "kuldes";
            this.kuldes.Size = new System.Drawing.Size(221, 47);
            this.kuldes.TabIndex = 11;
            this.kuldes.Text = "Küldés";
            this.kuldes.UseVisualStyleBackColor = true;
            this.kuldes.Click += new System.EventHandler(this.SendData);
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(12, 44);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 22);
            this.datum.TabIndex = 46;
            // 
            // valuta
            // 
            this.valuta.Location = new System.Drawing.Point(820, 106);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(87, 22);
            this.valuta.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Valuta";
            // 
            // celListBox
            // 
            this.celListBox.FormattingEnabled = true;
            this.celListBox.ItemHeight = 16;
            this.celListBox.Location = new System.Drawing.Point(13, 264);
            this.celListBox.Name = "celListBox";
            this.celListBox.Size = new System.Drawing.Size(372, 84);
            this.celListBox.TabIndex = 49;
            this.celListBox.SelectedIndexChanged += new System.EventHandler(this.CelListBoxChanged);
            // 
            // eredetListBox
            // 
            this.eredetListBox.FormattingEnabled = true;
            this.eredetListBox.ItemHeight = 16;
            this.eredetListBox.Location = new System.Drawing.Point(12, 160);
            this.eredetListBox.Name = "eredetListBox";
            this.eredetListBox.Size = new System.Drawing.Size(373, 84);
            this.eredetListBox.TabIndex = 50;
            this.eredetListBox.SelectedValueChanged += new System.EventHandler(this.ErderListBoxChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "EUR",
            "HUF",
            "USD"});
            this.listBox1.Location = new System.Drawing.Point(672, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 68);
            this.listBox1.TabIndex = 51;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ValutaListBoxChanged);
            // 
            // megbizoListbox
            // 
            this.megbizoListbox.FormattingEnabled = true;
            this.megbizoListbox.ItemHeight = 16;
            this.megbizoListbox.Location = new System.Drawing.Point(379, 44);
            this.megbizoListbox.Name = "megbizoListbox";
            this.megbizoListbox.Size = new System.Drawing.Size(202, 84);
            this.megbizoListbox.TabIndex = 52;
            this.megbizoListbox.SelectedIndexChanged += new System.EventHandler(this.MegbizoListBoxChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 47);
            this.button2.TabIndex = 53;
            this.button2.Text = "Küldés és bezárás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendAndClose);
            // 
            // AddAtutalasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.megbizoListbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.eredetListBox);
            this.Controls.Add(this.celListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valuta);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.kuldes);
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
            this.Load += new System.EventHandler(this.AddAtutalasForm_Load);
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
        private System.Windows.Forms.Button kuldes;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.TextBox valuta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox celListBox;
        private System.Windows.Forms.ListBox eredetListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox megbizoListbox;
        private System.Windows.Forms.Button button2;
    }
}