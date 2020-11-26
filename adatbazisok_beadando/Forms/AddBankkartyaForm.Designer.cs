
namespace adatbazisok_beadando.Forms
{
    partial class AddBankkartyaForm
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
            this.bankkartyaszam = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lejarat = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipus = new System.Windows.Forms.TextBox();
            this.limit = new System.Windows.Forms.TextBox();
            this.megerositoCod = new System.Windows.Forms.TextBox();
            this.bankszamlaszam = new System.Windows.Forms.TextBox();
            this.kuldes = new System.Windows.Forms.Button();
            this.bankszamaszamListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bankkartyaszam
            // 
            this.bankkartyaszam.Location = new System.Drawing.Point(15, 45);
            this.bankkartyaszam.Name = "bankkartyaszam";
            this.bankkartyaszam.Size = new System.Drawing.Size(238, 22);
            this.bankkartyaszam.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 17);
            this.label17.TabIndex = 49;
            this.label17.Text = "Bankszámlaszám";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(450, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 48;
            this.label16.Text = "Limit";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(695, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 17);
            this.label15.TabIndex = 47;
            this.label15.Text = "Tpus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(266, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "Lejárat";
            // 
            // lejarat
            // 
            this.lejarat.Location = new System.Drawing.Point(260, 45);
            this.lejarat.Name = "lejarat";
            this.lejarat.Size = new System.Drawing.Size(200, 22);
            this.lejarat.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Megerősitő kód";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Bankkártyaszám";
            // 
            // tipus
            // 
            this.tipus.Location = new System.Drawing.Point(687, 129);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(131, 22);
            this.tipus.TabIndex = 42;
            // 
            // limit
            // 
            this.limit.Location = new System.Drawing.Point(453, 128);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(178, 22);
            this.limit.TabIndex = 41;
            // 
            // megerositoCod
            // 
            this.megerositoCod.Location = new System.Drawing.Point(481, 45);
            this.megerositoCod.Name = "megerositoCod";
            this.megerositoCod.Size = new System.Drawing.Size(100, 22);
            this.megerositoCod.TabIndex = 40;
            // 
            // bankszamlaszam
            // 
            this.bankszamlaszam.Location = new System.Drawing.Point(18, 128);
            this.bankszamlaszam.Name = "bankszamlaszam";
            this.bankszamlaszam.Size = new System.Drawing.Size(380, 22);
            this.bankszamlaszam.TabIndex = 39;
            // 
            // kuldes
            // 
            this.kuldes.Location = new System.Drawing.Point(436, 203);
            this.kuldes.Name = "kuldes";
            this.kuldes.Size = new System.Drawing.Size(195, 37);
            this.kuldes.TabIndex = 50;
            this.kuldes.Text = "Küldés";
            this.kuldes.UseVisualStyleBackColor = true;
            this.kuldes.Click += new System.EventHandler(this.SendData);
            // 
            // bankszamaszamListbox
            // 
            this.bankszamaszamListbox.FormattingEnabled = true;
            this.bankszamaszamListbox.ItemHeight = 16;
            this.bankszamaszamListbox.Location = new System.Drawing.Point(18, 156);
            this.bankszamaszamListbox.Name = "bankszamaszamListbox";
            this.bankszamaszamListbox.Size = new System.Drawing.Size(380, 84);
            this.bankszamaszamListbox.TabIndex = 51;
            this.bankszamaszamListbox.SelectedIndexChanged += new System.EventHandler(this.BankszamaszamListbox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 37);
            this.button1.TabIndex = 52;
            this.button1.Text = "Küldés és bezárás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendAndClose);
            // 
            // AddBankkartyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankszamaszamListbox);
            this.Controls.Add(this.kuldes);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lejarat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipus);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.megerositoCod);
            this.Controls.Add(this.bankszamlaszam);
            this.Controls.Add(this.bankkartyaszam);
            this.Name = "AddBankkartyaForm";
            this.Text = "AddBankkartyaForm";
            this.Load += new System.EventHandler(this.AddBankkartyaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bankkartyaszam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker lejarat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipus;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.TextBox megerositoCod;
        private System.Windows.Forms.TextBox bankszamlaszam;
        private System.Windows.Forms.Button kuldes;
        private System.Windows.Forms.ListBox bankszamaszamListbox;
        private System.Windows.Forms.Button button1;
    }
}