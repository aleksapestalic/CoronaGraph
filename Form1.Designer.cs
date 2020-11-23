namespace CoronaGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last24hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infectedDeathsGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futurebasedOnCurrentTrendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGKVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lLastUpdated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1056, 191);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 224);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1056, 173);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart1";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(12, 403);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(1056, 226);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.infectedDeathsGraphToolStripMenuItem,
            this.calculationsToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.futurebasedOnCurrentTrendsToolStripMenuItem,
            this.refreshDataToolStripMenuItem,
            this.citiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.last24hToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.viewToolStripMenuItem.Text = "Take a closer look";
            // 
            // last24hToolStripMenuItem
            // 
            this.last24hToolStripMenuItem.Name = "last24hToolStripMenuItem";
            this.last24hToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.last24hToolStripMenuItem.Text = "Progress by days";
            this.last24hToolStripMenuItem.Click += new System.EventHandler(this.last24hToolStripMenuItem_Click);
            // 
            // infectedDeathsGraphToolStripMenuItem
            // 
            this.infectedDeathsGraphToolStripMenuItem.Name = "infectedDeathsGraphToolStripMenuItem";
            this.infectedDeathsGraphToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.infectedDeathsGraphToolStripMenuItem.Text = "Infected and recovered";
            this.infectedDeathsGraphToolStripMenuItem.Click += new System.EventHandler(this.infectedDeathsGraphToolStripMenuItem_Click);
            // 
            // calculationsToolStripMenuItem
            // 
            this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
            this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.calculationsToolStripMenuItem.Text = "Calculations";
            this.calculationsToolStripMenuItem.Click += new System.EventHandler(this.calculationsToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // futurebasedOnCurrentTrendsToolStripMenuItem
            // 
            this.futurebasedOnCurrentTrendsToolStripMenuItem.Name = "futurebasedOnCurrentTrendsToolStripMenuItem";
            this.futurebasedOnCurrentTrendsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.futurebasedOnCurrentTrendsToolStripMenuItem.Text = "Possible outcomes";
            this.futurebasedOnCurrentTrendsToolStripMenuItem.Click += new System.EventHandler(this.futurebasedOnCurrentTrendsToolStripMenuItem_Click);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.refreshDataToolStripMenuItem.Text = "Refresh data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGKVToolStripMenuItem,
            this.allCitiesToolStripMenuItem,
            this.changesToolStripMenuItem});
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.citiesToolStripMenuItem.Text = "Cities";
            // 
            // bGKVToolStripMenuItem
            // 
            this.bGKVToolStripMenuItem.Name = "bGKVToolStripMenuItem";
            this.bGKVToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.bGKVToolStripMenuItem.Text = "BG / KV";
            this.bGKVToolStripMenuItem.Click += new System.EventHandler(this.bGKVToolStripMenuItem_Click);
            // 
            // allCitiesToolStripMenuItem
            // 
            this.allCitiesToolStripMenuItem.Name = "allCitiesToolStripMenuItem";
            this.allCitiesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.allCitiesToolStripMenuItem.Text = "All cities";
            this.allCitiesToolStripMenuItem.Click += new System.EventHandler(this.allCitiesToolStripMenuItem_Click);
            // 
            // changesToolStripMenuItem
            // 
            this.changesToolStripMenuItem.Name = "changesToolStripMenuItem";
            this.changesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.changesToolStripMenuItem.Text = "Changes";
            this.changesToolStripMenuItem.Click += new System.EventHandler(this.changesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1028, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "AP 2020";
            // 
            // lLastUpdated
            // 
            this.lLastUpdated.AutoSize = true;
            this.lLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastUpdated.Location = new System.Drawing.Point(12, 632);
            this.lLastUpdated.Name = "lLastUpdated";
            this.lLastUpdated.Size = new System.Drawing.Size(75, 12);
            this.lLastUpdated.TabIndex = 6;
            this.lLastUpdated.Text = "Last update: N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 653);
            this.Controls.Add(this.lLastUpdated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CoronaGraph";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem last24hToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infectedDeathsGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futurebasedOnCurrentTrendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGKVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changesToolStripMenuItem;
        private System.Windows.Forms.Label lLastUpdated;
    }
}

