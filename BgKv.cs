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
    public partial class BgKv : Form
    {
        public BgKv()
        {
            InitializeComponent();
        }

        private void BgKv_Load(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.Series.Clear(); chart2.Series.Clear();

            #region load 1st graph
            List<string> data = new List<string>();
            data = DB.getAllCities("Београд");

            Series infBg = this.chart1.Series.Add("Infected");
            infBg.ChartType = SeriesChartType.Spline;
            infBg.Color = Color.Red;
            infBg.BorderWidth = 2;
            infBg.IsValueShownAsLabel = true;
            infBg.IsVisibleInLegend = false;

            #region label
            string currBg = data[data.Count - 1];
            string[] single12 = currBg.Split(',');
            lBg.Text = "Currently infected in BG: " + single12[1];
            #endregion

            //single 0-6
            for (int i = 0; i < data.Count; i++)
            {
                string curr1 = data[i];
                string[] single1 = curr1.Split(',');
                infBg.Points.AddXY(single1[3], single1[1]);
            }
            #endregion

            #region load 2nd graph
            List<string> dataKV = new List<string>();
            dataKV = DB.getAllCities("Краљево");

            Series infKv = this.chart2.Series.Add("Infected");
            infKv.IsVisibleInLegend = false;
            infKv.ChartType = SeriesChartType.Spline;
            infKv.Color = Color.Blue;
            infKv.BorderWidth = 2;
            infKv.IsValueShownAsLabel = true;

            #region labrlKv
            string currKv = dataKV[dataKV.Count - 1];
            string[] single123 = currKv.Split(',');
            lKv.Text = "Currently infected in KV: " + single123[1];
            #endregion

            //single 0-6
            for (int i = 0; i < dataKV.Count; i++)
            {
                string curr1 = dataKV[i];
                string[] single1 = curr1.Split(',');
                infKv.Points.AddXY(single1[3], single1[1]);
            }
            #endregion


        }
    }
}
