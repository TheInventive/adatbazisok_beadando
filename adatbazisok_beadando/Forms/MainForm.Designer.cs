namespace adatbazisok_beadando
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.átutalásokMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átutalásaokMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfelekMutatásaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.számlákMutatásaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bankkártyákMutatásaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adatokHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átutalásHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyfélHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számlaHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankkártyaHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikonMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzakciókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókNövekedéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesButton = new System.Windows.Forms.Button();
            this.modositasButton = new System.Windows.Forms.Button();
            this.sqlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1690, 455);
            this.dataGridView1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.átutalásokMutatásaToolStripMenuItem,
            this.adatokHozzáadásaToolStripMenuItem,
            this.grafikonMutatásaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1690, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // átutalásokMutatásaToolStripMenuItem
            // 
            this.átutalásokMutatásaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.átutalásaokMutatásaToolStripMenuItem,
            this.ügyfelekMutatásaToolStripMenuItem1,
            this.számlákMutatásaToolStripMenuItem1,
            this.bankkártyákMutatásaToolStripMenuItem1});
            this.átutalásokMutatásaToolStripMenuItem.Name = "átutalásokMutatásaToolStripMenuItem";
            this.átutalásokMutatásaToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.átutalásokMutatásaToolStripMenuItem.Text = "Adatok mutatása";
            // 
            // átutalásaokMutatásaToolStripMenuItem
            // 
            this.átutalásaokMutatásaToolStripMenuItem.Name = "átutalásaokMutatásaToolStripMenuItem";
            this.átutalásaokMutatásaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.átutalásaokMutatásaToolStripMenuItem.Text = "Átutalásaok mutatása";
            this.átutalásaokMutatásaToolStripMenuItem.Click += new System.EventHandler(this.ShowAtutalasok);
            // 
            // ügyfelekMutatásaToolStripMenuItem1
            // 
            this.ügyfelekMutatásaToolStripMenuItem1.Name = "ügyfelekMutatásaToolStripMenuItem1";
            this.ügyfelekMutatásaToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.ügyfelekMutatásaToolStripMenuItem1.Text = "Ügyfelek mutatása";
            this.ügyfelekMutatásaToolStripMenuItem1.Click += new System.EventHandler(this.ShowUgyfelek);
            // 
            // számlákMutatásaToolStripMenuItem1
            // 
            this.számlákMutatásaToolStripMenuItem1.Name = "számlákMutatásaToolStripMenuItem1";
            this.számlákMutatásaToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.számlákMutatásaToolStripMenuItem1.Text = "Számlák mutatása";
            this.számlákMutatásaToolStripMenuItem1.Click += new System.EventHandler(this.ShowSzamlak);
            // 
            // bankkártyákMutatásaToolStripMenuItem1
            // 
            this.bankkártyákMutatásaToolStripMenuItem1.Name = "bankkártyákMutatásaToolStripMenuItem1";
            this.bankkártyákMutatásaToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.bankkártyákMutatásaToolStripMenuItem1.Text = "Bankkártyák mutatása";
            this.bankkártyákMutatásaToolStripMenuItem1.Click += new System.EventHandler(this.ShowBankkartyak);
            // 
            // adatokHozzáadásaToolStripMenuItem
            // 
            this.adatokHozzáadásaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.átutalásHozzáadásaToolStripMenuItem,
            this.ügyfélHozzáadásaToolStripMenuItem,
            this.számlaHozzáadásaToolStripMenuItem,
            this.bankkártyaHozzáadásaToolStripMenuItem});
            this.adatokHozzáadásaToolStripMenuItem.Name = "adatokHozzáadásaToolStripMenuItem";
            this.adatokHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.adatokHozzáadásaToolStripMenuItem.Text = "Adatok hozzáadása";
            // 
            // átutalásHozzáadásaToolStripMenuItem
            // 
            this.átutalásHozzáadásaToolStripMenuItem.Name = "átutalásHozzáadásaToolStripMenuItem";
            this.átutalásHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.átutalásHozzáadásaToolStripMenuItem.Text = "Átutalás hozzáadása";
            this.átutalásHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.AddAtutalas);
            // 
            // ügyfélHozzáadásaToolStripMenuItem
            // 
            this.ügyfélHozzáadásaToolStripMenuItem.Name = "ügyfélHozzáadásaToolStripMenuItem";
            this.ügyfélHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.ügyfélHozzáadásaToolStripMenuItem.Text = "Ügyfél hozzáadása";
            this.ügyfélHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.AddUgyfel);
            // 
            // számlaHozzáadásaToolStripMenuItem
            // 
            this.számlaHozzáadásaToolStripMenuItem.Name = "számlaHozzáadásaToolStripMenuItem";
            this.számlaHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.számlaHozzáadásaToolStripMenuItem.Text = "Számla hozzáadása";
            this.számlaHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.AddSzamla);
            // 
            // bankkártyaHozzáadásaToolStripMenuItem
            // 
            this.bankkártyaHozzáadásaToolStripMenuItem.Name = "bankkártyaHozzáadásaToolStripMenuItem";
            this.bankkártyaHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.bankkártyaHozzáadásaToolStripMenuItem.Text = "Bankkártya hozzáadása";
            this.bankkártyaHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.AddBankkartya);
            // 
            // grafikonMutatásaToolStripMenuItem
            // 
            this.grafikonMutatásaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranzakciókToolStripMenuItem,
            this.felhasználókNövekedéseToolStripMenuItem});
            this.grafikonMutatásaToolStripMenuItem.Name = "grafikonMutatásaToolStripMenuItem";
            this.grafikonMutatásaToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.grafikonMutatásaToolStripMenuItem.Text = "Grafikon mutatása";
            // 
            // tranzakciókToolStripMenuItem
            // 
            this.tranzakciókToolStripMenuItem.Name = "tranzakciókToolStripMenuItem";
            this.tranzakciókToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.tranzakciókToolStripMenuItem.Text = "Tranzakciók";
            // 
            // felhasználókNövekedéseToolStripMenuItem
            // 
            this.felhasználókNövekedéseToolStripMenuItem.Name = "felhasználókNövekedéseToolStripMenuItem";
            this.felhasználókNövekedéseToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.felhasználókNövekedéseToolStripMenuItem.Text = "Felhasználók növekedése";
            // 
            // torlesButton
            // 
            this.torlesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.torlesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.torlesButton.Location = new System.Drawing.Point(0, 485);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(1690, 35);
            this.torlesButton.TabIndex = 7;
            this.torlesButton.Text = "Kijelölt sor törlése";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.TorlesButton_Click);
            // 
            // modositasButton
            // 
            this.modositasButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modositasButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.modositasButton.Location = new System.Drawing.Point(0, 520);
            this.modositasButton.Name = "modositasButton";
            this.modositasButton.Size = new System.Drawing.Size(1690, 35);
            this.modositasButton.TabIndex = 8;
            this.modositasButton.Text = "Kijelölt sor módosítása";
            this.modositasButton.UseVisualStyleBackColor = true;
            this.modositasButton.Click += new System.EventHandler(this.ModositasButton_Click);
            // 
            // sqlLabel
            // 
            this.sqlLabel.AutoSize = true;
            this.sqlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqlLabel.Location = new System.Drawing.Point(0, 555);
            this.sqlLabel.Name = "sqlLabel";
            this.sqlLabel.Size = new System.Drawing.Size(0, 27);
            this.sqlLabel.TabIndex = 10;
            this.sqlLabel.TextChanged += new System.EventHandler(this.SqlLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1690, 657);
            this.Controls.Add(this.sqlLabel);
            this.Controls.Add(this.modositasButton);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem átutalásokMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átutalásaokMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfelekMutatásaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem számlákMutatásaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bankkártyákMutatásaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adatokHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átutalásHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyfélHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem számlaHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankkártyaHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button modositasButton;
        private System.Windows.Forms.ToolStripMenuItem grafikonMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzakciókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználókNövekedéseToolStripMenuItem;
        private System.Windows.Forms.Label sqlLabel;
    }
}

