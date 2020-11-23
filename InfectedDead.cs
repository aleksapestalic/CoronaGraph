using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoronaGraph
{
    public partial class InfectedDead : Form
    {
        public InfectedDead()
        {
            InitializeComponent();
        }

        private void InfectedDead_Load(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data = DB.getAllData();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            this.chart1.Series.Clear();
            this.chart2.Series.Clear();

            #region chart1
            Series infectedTotal = this.chart1.Series.Add("Total infected");
            infectedTotal.ChartType = SeriesChartType.Spline;
            infectedTotal.IsValueShownAsLabel = true;

            Series deadTotal = this.chart1.Series.Add("Total deaths");
            deadTotal.ChartType = SeriesChartType.Spline;
            deadTotal.Color = Color.Red;
            deadTotal.IsValueShownAsLabel = true;

            //single 0-6
            for (int i = 0; i < data.Count; i++)
            {
                string curr = data[i];
                string[] single = curr.Split(',');
                infectedTotal.Points.AddXY(single[6], single[5]);
                deadTotal.Points.AddXY(single[6], single[3]);
            }
            #endregion


            #region chart2

            Series totalInfected1 = this.chart2.Series.Add("Total infected");
            totalInfected1.ChartType = SeriesChartType.Spline;
            totalInfected1.Color = Color.Red;
            totalInfected1.IsValueShownAsLabel = true;


            Series totalRecovered = this.chart2.Series.Add("Total recovered");
            totalRecovered.ChartType = SeriesChartType.Spline;
            totalRecovered.Color = Color.Green;
            totalRecovered.IsValueShownAsLabel = true;
            totalRecovered.BorderWidth = 4;

            for (int i = 0; i < data.Count; i++)
            {
                string curr = data[i];
                string[] single = curr.Split(',');

                totalInfected1.Points.AddXY(single[6], single[5]);
                totalRecovered.Points.AddXY(single[6], single[9]);

            }
            #endregion
        }
    }
}
