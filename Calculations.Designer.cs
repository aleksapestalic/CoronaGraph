namespace CoronaGraph
{
    partial class Calculations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lRatio = new System.Windows.Forms.Label();
            this.lDeadliness = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lDead24 = new System.Windows.Forms.Label();
            this.lHosp24 = new System.Windows.Forms.Label();
            this.lInf24 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.lRec24h = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lRatio);
            this.groupBox1.Controls.Add(this.lDeadliness);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numbers";
            // 
            // lRatio
            // 
            this.lRatio.AutoSize = true;
            this.lRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRatio.Location = new System.Drawing.Point(143, 67);
            this.lRatio.Name = "lRatio";
            this.lRatio.Size = new System.Drawing.Size(51, 16);
            this.lRatio.TabIndex = 3;
            this.lRatio.Text = "label3";
            // 
            // lDeadliness
            // 
            this.lDeadliness.AutoSize = true;
            this.lDeadliness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDeadliness.Location = new System.Drawing.Point(355, 37);
            this.lDeadliness.Name = "lDeadliness";
            this.lDeadliness.Size = new System.Drawing.Size(51, 16);
            this.lDeadliness.TabIndex = 2;
            this.lDeadliness.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tested positive ratio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percentage of a deadly outcome for the infected population:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 155);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(849, 181);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 342);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(849, 181);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lRec24h);
            this.groupBox2.Controls.Add(this.lDead24);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lHosp24);
            this.groupBox2.Controls.Add(this.lInf24);
            this.groupBox2.Controls.Add(this.l3);
            this.groupBox2.Controls.Add(this.l2);
            this.groupBox2.Controls.Add(this.l1);
            this.groupBox2.Location = new System.Drawing.Point(468, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lDead24
            // 
            this.lDead24.AutoSize = true;
            this.lDead24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDead24.Location = new System.Drawing.Point(151, 64);
            this.lDead24.Name = "lDead24";
            this.lDead24.Size = new System.Drawing.Size(51, 16);
            this.lDead24.TabIndex = 4;
            this.lDead24.Text = "label3";
            // 
            // lHosp24
            // 
            this.lHosp24.AutoSize = true;
            this.lHosp24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHosp24.Location = new System.Drawing.Point(163, 39);
            this.lHosp24.Name = "lHosp24";
            this.lHosp24.Size = new System.Drawing.Size(51, 16);
            this.lHosp24.TabIndex = 5;
            this.lHosp24.Text = "label3";
            // 
            // lInf24
            // 
            this.lInf24.AutoSize = true;
            this.lInf24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInf24.Location = new System.Drawing.Point(138, 15);
            this.lInf24.Name = "lInf24";
            this.lInf24.Size = new System.Drawing.Size(51, 16);
            this.lInf24.TabIndex = 4;
            this.lInf24.Text = "label3";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(6, 64);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(145, 15);
            this.l3.TabIndex = 6;
            this.l3.Text = "Deceased in the last 24h:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(6, 39);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(157, 15);
            this.l2.TabIndex = 5;
            this.l2.Text = "Hospitalised in the last 24h:";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(6, 15);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(132, 15);
            this.l1.TabIndex = 4;
            this.l1.Text = "Infected in the last 24h:";
            // 
            // lRec24h
            // 
            this.lRec24h.AutoSize = true;
            this.lRec24h.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRec24h.ForeColor = System.Drawing.Color.ForestGreen;
            this.lRec24h.Location = new System.Drawing.Point(151, 89);
            this.lRec24h.Name = "lRec24h";
            this.lRec24h.Size = new System.Drawing.Size(51, 16);
            this.lRec24h.TabIndex = 7;
            this.lRec24h.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Recovered in the last 24h:";
            // 
            // Calculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculations";
            this.ShowInTaskbar = false;
            this.Text = "Calculations - CoronaGraph";
            this.Load += new System.EventHandler(this.Calculations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lRatio;
        private System.Windows.Forms.Label lDeadliness;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label lDead24;
        private System.Windows.Forms.Label lHosp24;
        private System.Windows.Forms.Label lInf24;
        private System.Windows.Forms.Label lRec24h;
        private System.Windows.Forms.Label label4;
    }
}