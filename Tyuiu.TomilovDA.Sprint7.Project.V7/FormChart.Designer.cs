namespace Tyuiu.TomilovDA.Sprint7.Project.V7
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartDebtorCount_TDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitContainerChart_TDA = new SplitContainer();
            labelNoDebtPercent_TDA = new Label();
            labelHasDebtPercent_TDA = new Label();
            labelNoDebtCount_TDA = new Label();
            labelHasDebtCount_TDA = new Label();
            ((System.ComponentModel.ISupportInitialize)chartDebtorCount_TDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerChart_TDA).BeginInit();
            splitContainerChart_TDA.Panel1.SuspendLayout();
            splitContainerChart_TDA.Panel2.SuspendLayout();
            splitContainerChart_TDA.SuspendLayout();
            SuspendLayout();
            // 
            // chartDebtorCount_TDA
            // 
            chartArea1.Name = "ChartArea1";
            chartDebtorCount_TDA.ChartAreas.Add(chartArea1);
            chartDebtorCount_TDA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDebtorCount_TDA.Legends.Add(legend1);
            chartDebtorCount_TDA.Location = new Point(0, 0);
            chartDebtorCount_TDA.Name = "chartDebtorCount_TDA";
            chartDebtorCount_TDA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDebtorCount_TDA.Series.Add(series1);
            chartDebtorCount_TDA.Size = new Size(456, 412);
            chartDebtorCount_TDA.TabIndex = 0;
            chartDebtorCount_TDA.Text = "Количество должников";
            // 
            // splitContainerChart_TDA
            // 
            splitContainerChart_TDA.Dock = DockStyle.Fill;
            splitContainerChart_TDA.Location = new Point(0, 0);
            splitContainerChart_TDA.Name = "splitContainerChart_TDA";
            // 
            // splitContainerChart_TDA.Panel1
            // 
            splitContainerChart_TDA.Panel1.Controls.Add(labelNoDebtPercent_TDA);
            splitContainerChart_TDA.Panel1.Controls.Add(labelHasDebtPercent_TDA);
            splitContainerChart_TDA.Panel1.Controls.Add(labelNoDebtCount_TDA);
            splitContainerChart_TDA.Panel1.Controls.Add(labelHasDebtCount_TDA);
            // 
            // splitContainerChart_TDA.Panel2
            // 
            splitContainerChart_TDA.Panel2.Controls.Add(chartDebtorCount_TDA);
            splitContainerChart_TDA.Size = new Size(710, 412);
            splitContainerChart_TDA.SplitterDistance = 250;
            splitContainerChart_TDA.TabIndex = 1;
            // 
            // labelNoDebtPercent_TDA
            // 
            labelNoDebtPercent_TDA.AutoSize = true;
            labelNoDebtPercent_TDA.Location = new Point(12, 82);
            labelNoDebtPercent_TDA.Name = "labelNoDebtPercent_TDA";
            labelNoDebtPercent_TDA.Size = new Size(92, 15);
            labelNoDebtPercent_TDA.TabIndex = 3;
            labelNoDebtPercent_TDA.Text = "Должники (%): ";
            // 
            // labelHasDebtPercent_TDA
            // 
            labelHasDebtPercent_TDA.AutoSize = true;
            labelHasDebtPercent_TDA.Location = new Point(12, 57);
            labelHasDebtPercent_TDA.Name = "labelHasDebtPercent_TDA";
            labelHasDebtPercent_TDA.Size = new Size(92, 15);
            labelHasDebtPercent_TDA.TabIndex = 2;
            labelHasDebtPercent_TDA.Text = "Должники (%): ";
            // 
            // labelNoDebtCount_TDA
            // 
            labelNoDebtCount_TDA.AutoSize = true;
            labelNoDebtCount_TDA.Location = new Point(12, 33);
            labelNoDebtCount_TDA.Name = "labelNoDebtCount_TDA";
            labelNoDebtCount_TDA.Size = new Size(153, 15);
            labelNoDebtCount_TDA.TabIndex = 1;
            labelNoDebtCount_TDA.Text = "Количество не должников";
            // 
            // labelHasDebtCount_TDA
            // 
            labelHasDebtCount_TDA.AutoSize = true;
            labelHasDebtCount_TDA.Location = new Point(12, 9);
            labelHasDebtCount_TDA.Name = "labelHasDebtCount_TDA";
            labelHasDebtCount_TDA.Size = new Size(140, 15);
            labelHasDebtCount_TDA.TabIndex = 0;
            labelHasDebtCount_TDA.Text = "Количество должников:";
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(710, 412);
            Controls.Add(splitContainerChart_TDA);
            Name = "FormChart";
            Text = "Количество должников";
            ((System.ComponentModel.ISupportInitialize)chartDebtorCount_TDA).EndInit();
            splitContainerChart_TDA.Panel1.ResumeLayout(false);
            splitContainerChart_TDA.Panel1.PerformLayout();
            splitContainerChart_TDA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerChart_TDA).EndInit();
            splitContainerChart_TDA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDebtorCount_TDA;
        private SplitContainer splitContainerChart_TDA;
        private Label labelHasDebtCount_TDA;
        private Label labelNoDebtCount_TDA;
        private Label labelNoDebtPercent_TDA;
        private Label labelHasDebtPercent_TDA;
    }
}