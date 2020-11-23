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
    public partial class Calculations : Form
    {
        public Calculations()
        {
            InitializeComponent();
        }

        private void Calculations_Load(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            List<string> data = new List<string>();
            data = DB.getAllData();

            string curr = data[data.Count-1];
            string[] single = curr.Split(',');

            double infected = int.Parse(single[5]);
            double dead = int.Parse(single[3]);

            lDeadliness.Text = single[7].ToString() + " %";
            lRatio.Text = single[8].ToString() + " %";

            #region chart1
            chart1.Series.Clear();
            chart2.Series.Clear();
            Series deathPerc = this.chart1.Series.Add("Deadliness");
            deathPerc.ChartType = SeriesChartType.Spline;
            deathPerc.Color = Color.Red;
            deathPerc.IsValueShownAsLabel = true;

            Series infectedPerc = this.chart2.Series.Add("Infected to tested ratio");
            infectedPerc.ChartType = SeriesChartType.Spline;
            infectedPerc.Color = Color.Red;
            infectedPerc.IsValueShownAsLabel = true;

            //single 0-6
            for (int i = 0; i < data.Count; i++)
            {
                string curr1 = data[i];
                string[] single1 = curr1.Split(',');
                deathPerc.Points.AddXY(single1[6], single1[7]);
                infectedPerc.Points.AddXY(single1[6], single1[8]);
            }
            #endregion

            string latestEntry = data[data.Count - 1];
            string yesterdayEntry = data[data.Count - 2];

            lInf24.Text = latestEntry.Split(',')[1];

            int hospNow = int.Parse(latestEntry.Split(',')[2]);
            int hospYesterday = int.Parse(yesterdayEntry.Split(',')[2]);

            lHosp24.Text = (hospNow - hospYesterday).ToString();

            int deceasedNow = int.Parse(latestEntry.Split(',')[3]);
            int deceasedYesterday = int.Parse(yesterdayEntry.Split(',')[3]);
            lDead24.Text = (deceasedNow - deceasedYesterday).ToString();


            double recJuce = Convert.ToDouble(yesterdayEntry.Split(',')[9]);
            double recDanas = Convert.ToDouble(latestEntry.Split(',')[9]);

            double razlikaDanasJuce = recDanas - recJuce;
            lRec24h.Text = razlikaDanasJuce.ToString("0");
        }
    }
}
