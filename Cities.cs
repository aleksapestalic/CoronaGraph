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
    public partial class Cities : Form
    {
        public Cities()
        {
            InitializeComponent();
        }

        private void Cities_Load(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.Series.Clear();

            #region load 1st graph
            List<string> data = new List<string>();
            data = DB.getAllCities(comboBox1.Text);

            #region chart1
            chart1.Series.Clear();
            Series deathPerc = this.chart1.Series.Add("Infected");
            deathPerc.ChartType = SeriesChartType.Spline;
            deathPerc.Color = Color.Red;
            deathPerc.BorderWidth = 2;
            deathPerc.IsValueShownAsLabel = true;



            //single 0-6
            for (int i = 0; i < data.Count; i++)
            {
                string curr1 = data[i];
                string[] single1 = curr1.Split(',');
                deathPerc.Points.AddXY(single1[3], single1[1]);
            }
            #endregion
            #endregion

            chart2.Series.Clear();
            Series topTen = chart2.Series.Add("Top cities");
            topTen.IsVisibleInLegend = false;
            chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            topTen.ChartType = SeriesChartType.Column;
            topTen.IsValueShownAsLabel = true;


            DateTime curr = new DateTime();
            curr = DateTime.Now;
            string todaysDate = curr.ToString("yyyy/MM/dd");            
           
            List<string> citiesTop = new List<string>();
            citiesTop = DB.getTopCities(todaysDate);
            int cnt = 0;
            if(citiesTop == null)
            {
                todaysDate = curr.AddDays(-1).ToString("yyyy/MM/dd");
                citiesTop = DB.getTopCities(todaysDate);
            }
            foreach (var top in citiesTop)
            {
                if (cnt <= 18) {
                    string[] singles = top.Split(',');
                    topTen.Points.AddXY(singles[0], singles[1]);
                    
                }
                ++cnt;
            }
            topTen.Points[0].Color = Color.Red;
            topTen.Points[1].Color = Color.Orange;
            topTen.Points[2].Color = Color.Green;

            //dropdown
            List<string> cities = DB.getCityNames();
            foreach (var city in cities)
            {
                comboBox1.Items.Add(char.ToUpper(city.ToLower()[0]) + (city.Substring(1, city.Length-1)).ToLower());
            }
            string latest = data[data.Count - 1];
            string[] single11 = latest.Split(',');

            lInfected.Text = "Currently infected: " + single11[1] + " taking up " + single11[2] + "% of \nSerbia's infected population.";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data = DB.getAllCities(comboBox1.SelectedItem.ToString());

            #region chart1
            chart1.Series.Clear();
            Series infected = this.chart1.Series.Add("Infected");
            infected.ChartType = SeriesChartType.Spline;
            infected.Color = Color.Red;
            infected.BorderWidth = 2;
            infected.IsValueShownAsLabel = true;
            


            //single 0-6
            for (int i = 0; i < data.Count; i++)
            {
                string curr1 = data[i];
                string[] single1 = curr1.Split(',');
                infected.Points.AddXY(single1[3], single1[1]);                
            }
            string latest = data[data.Count-1];
            string[] single11 = latest.Split(',');
            #endregion
            lInfected.Text = "Currently infected: " + single11[1] + " taking up " + single11[2] + "% of \nSerbia's infected population.";
        }

        private void bChanges_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
