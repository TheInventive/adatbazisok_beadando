﻿namespace adatbazisok_beadando
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ügyfelekMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átutalásokMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.számlákMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankkártyákMutatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ügyfél hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UgyfelMegjelenitese);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Átutalás hozzáaása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Átutalás hozzáaása";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(522, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "Számla hozzáadása";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(754, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Bankkártya hozzáadása";
            this.button5.UseVisualStyleBackColor = true;
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
            // 
            // bankkártyákMutatásaToolStripMenuItem
            // 
            this.bankkártyákMutatásaToolStripMenuItem.Name = "bankkártyákMutatásaToolStripMenuItem";
            this.bankkártyákMutatásaToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.bankkártyákMutatásaToolStripMenuItem.Text = "Bankkártyák mutatása";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ügyfelekMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átutalásokMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem számlákMutatásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankkártyákMutatásaToolStripMenuItem;
    }
}
