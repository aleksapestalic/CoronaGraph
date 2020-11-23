using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoronaGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            fillMain();

        }

        private void last24hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Show();
            chart2.Hide();
            chart3.Hide();

            this.Width = 1090;
            this.Height = 550;

            chart1.Width = 1050;
            chart1.Height = 480;

            chart1.Location = new Point(12, 27);
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1100;
            this.Height = 696;
            chart1.Location = new Point(12, 27);
            chart1.Width = 1056;
            chart1.Height = 191;
            chart2.Show();
            chart3.Show();
            fillMain();
        }

        private void infectedDeathsGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfectedDead frm = new InfectedDead();
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void fillMain()
        {
            List<string> data = new List<string>();
            data = DB.getAllData();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            

            #region chart1

            this.chart1.Series.Clear();

            Series tested24h = this.chart1.Series.Add("Number of tested by 24 hours");
            tested24h.ChartType = SeriesChartType.Spline;

            Series infected24h = this.chart1.Series.Add("Number of infected by 24 hours");
            infected24h.ChartType = SeriesChartType.Spline;
            infected24h.Color = Color.Red;
                        

            //single 0-6
            for (int i = 0; i < data.Count; i++)
            {
                string curr = data[i];
                string[] single = curr.Split(',');
                tested24h.Points.AddXY(single[6], single[0]);
                infected24h.Points.AddXY(single[6], single[1]);
            }


            #endregion

            #region chart2

            chart2.Series.Clear();

            Series totalTested = this.chart2.Series.Add("Total tested");
            totalTested.ChartType = SeriesChartType.Spline;

            Series totalInfected = this.chart2.Series.Add("Total infected");
            totalInfected.ChartType = SeriesChartType.Spline;
            totalInfected.Color = Color.Red;

            for (int i = 0; i < data.Count; i++)
            {
                string curr = data[i];
                string[] single = curr.Split(',');

                totalTested.Points.AddXY(single[6], single[4]);
                totalInfected.Points.AddXY(single[6], single[5]);
            }
            #endregion

            #region chart3

            chart3.Series.Clear();
            Series totalHospitalized = this.chart3.Series.Add("Total hospitalized");
            totalHospitalized.ChartType = SeriesChartType.Spline;

            Series totalDeaths = this.chart3.Series.Add("Total deaths");
            totalDeaths.ChartType = SeriesChartType.Spline;
            totalDeaths.Color = Color.Red;
            totalDeaths.IsValueShownAsLabel = true;

            for (int i = 0; i < data.Count; i++)
            {
                string curr = data[i];
                string[] single = curr.Split(',');

                totalHospitalized.Points.AddXY(single[6], single[2]);
                totalDeaths.Points.AddXY(single[6], single[3]);

            }

            #endregion

            #region lastUpdated
            string dateArr = data[data.Count - 1];
            string dateStr = dateArr.Split(',')[10];
            //dateStr = dateStr.Substring(0, dateStr.IndexOf(" "));
            string todayOrNot = "";
            
            if (dateStr == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                todayOrNot = "(today)";

            }
            else if ("0" + dateStr == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                todayOrNot = "(today)";
            }
            else todayOrNot = "(not today)";

            lLastUpdated.Text = "Last updated: " + dateStr + "  " + todayOrNot;
            #endregion
        }

        private void calculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculations frm = new Calculations();
            frm.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database frm = new Database();
            frm.Show();
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillMain();
            SystemSounds.Exclamation.Play();
        }

        private void futurebasedOnCurrentTrendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trend frm = new Trend();
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void allCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities frm = new Cities();
            frm.Show();
        }

        private void bGKVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BgKv frm = new BgKv();
            frm.Show();
        }

        private void changesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitiesChange frm = new CitiesChange();
            frm.Show();
        }
    }
}
