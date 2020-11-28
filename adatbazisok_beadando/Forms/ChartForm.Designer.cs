
namespace adatbazisok_beadando
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.atutalasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eredetListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.atutalasChart)).BeginInit();
            this.SuspendLayout();
            // 
            // atutalasChart
            // 
            chartArea2.Name = "ChartArea1";
            this.atutalasChart.ChartAreas.Add(chartArea2);
            this.atutalasChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.atutalasChart.Legends.Add(legend2);
            this.atutalasChart.Location = new System.Drawing.Point(0, 0);
            this.atutalasChart.Name = "atutalasChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Átutalások";
            this.atutalasChart.Series.Add(series2);
            this.atutalasChart.Size = new System.Drawing.Size(1466, 569);
            this.atutalasChart.TabIndex = 0;
            this.atutalasChart.Text = "chart1";
            // 
            // eredetListBox
            // 
            this.eredetListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.eredetListBox.FormattingEnabled = true;
            this.eredetListBox.ItemHeight = 16;
            this.eredetListBox.Location = new System.Drawing.Point(0, 569);
            this.eredetListBox.Name = "eredetListBox";
            this.eredetListBox.Size = new System.Drawing.Size(1466, 84);
            this.eredetListBox.TabIndex = 51;
            this.eredetListBox.SelectedValueChanged += new System.EventHandler(this.EredetListBox_SelectedValueChanged);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 569);
            this.Controls.Add(this.eredetListBox);
            this.Controls.Add(this.atutalasChart);
            this.Name = "ChartForm";
            this.Text = "Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atutalasChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart atutalasChart;
        private System.Windows.Forms.ListBox eredetListBox;
    }
}