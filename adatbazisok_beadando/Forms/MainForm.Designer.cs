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
            this.ügyfelekMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átutalásokMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számlákMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankkártyákMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1666, 455);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ügyfelekMutatásaToolStripMenuItem,
            this.átutalásokMutatásaToolStripMenuItem,
            this.számlákMutatásaToolStripMenuItem,
            this.bankkártyákMutatásaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1690, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ügyfelekMutatásaToolStripMenuItem
            // 
            this.ügyfelekMutatásaToolStripMenuItem.Name = "ügyfelekMutatásaToolStripMenuItem";
            this.ügyfelekMutatásaToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.ügyfelekMutatásaToolStripMenuItem.Text = "Ügyfelek mutatása";
            this.ügyfelekMutatásaToolStripMenuItem.Click += new System.EventHandler(this.ÜgyfelekMutatásaToolStripMenuItem_Click);
            // 
            // átutalásokMutatásaToolStripMenuItem
            // 
            this.átutalásokMutatásaToolStripMenuItem.Name = "átutalásokMutatásaToolStripMenuItem";
            this.átutalásokMutatásaToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.átutalásokMutatásaToolStripMenuItem.Text = "Átutalások mutatása";
            this.átutalásokMutatásaToolStripMenuItem.Click += new System.EventHandler(this.ÁtutalásokMutatásaToolStripMenuItem_Click);
            // 
            // számlákMutatásaToolStripMenuItem
            // 
            this.számlákMutatásaToolStripMenuItem.Name = "számlákMutatásaToolStripMenuItem";
            this.számlákMutatásaToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.számlákMutatásaToolStripMenuItem.Text = "Számlák mutatása";
            this.számlákMutatásaToolStripMenuItem.Click += new System.EventHandler(this.SzámlákMutatásaToolStripMenuItem_Click);
            // 
            // bankkártyákMutatásaToolStripMenuItem
            // 
            this.bankkártyákMutatásaToolStripMenuItem.Name = "bankkártyákMutatásaToolStripMenuItem";
            this.bankkártyákMutatásaToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.bankkártyákMutatásaToolStripMenuItem.Text = "Bankkártyák mutatása";
            this.bankkártyákMutatásaToolStripMenuItem.Click += new System.EventHandler(this.bankkártyákMutatásaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adatok hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ügyfelekMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átutalásokMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem számlákMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankkártyákMutatásaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

