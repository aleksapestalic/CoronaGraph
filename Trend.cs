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
    public partial class Trend : Form
    {
        public Trend()
        {
            InitializeComponent();
        }

        private void Trend_Load(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            List<string> trend = new List<string>();
            data = DB.getAllData();

            #region charts config
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart3.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart3.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;


            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();

            Series infected = this.chart1.Series.Add("Infected expectation");
            infected.ChartType = SeriesChartType.Spline;
            infected.Color = Color.Red;
            infected.IsValueShownAsLabel = false;

            Series hosp = this.chart2.Series.Add("Hospitalized expectation");
            hosp.ChartType = SeriesChartType.Spline;
            hosp.Color = Color.Blue;
            hosp.IsValueShownAsLabel = false;

            Series recovered = this.chart3.Series.Add("Recovered expectation");
            recovered.ChartType = SeriesChartType.Spline;
            recovered.Color = Color.Green;
            recovered.IsValueShownAsLabel = false;
            recovered.BorderWidth = 2;

            #endregion

            string jucerasnji = data[data.Count - 2];
            string danasnji = data[data.Count - 1];

            string[] splitDanas = danasnji.Split(',');
            string[] splitJuce = jucerasnji.Split(',');


            #region infected - eksponencijalni
            double infJuce = Convert.ToDouble(splitJuce[5]);
            double infDanas = Convert.ToDouble(splitDanas[5]);

            double eks = Math.Log(infDanas, infJuce); //eksponent baziran na razlici izmedju danasnjeg i jucerasnjeg preseka


            double brojZarazenih = infDanas;
            double dani = 1;
            while (brojZarazenih <= 4900000)
            {
                brojZarazenih = Math.Pow(brojZarazenih, eks);
                string dan = "+" + dani + "d";
                infected.Points.AddXY(dan, brojZarazenih); //date, brZar
                ++dani;
            }
          
            lPrognoza.Text = dani.ToString("0")+" days";
            var today = DateTime.Now;
            today = today.AddDays(dani);
            
            lDatumKraja.Text = today.ToString("dd/MM/yyyy");
            //lCurrExp.Text = eks.ToString("0.00");
            #endregion

            #region hospitalized - eksponencijalni
            double hospDanas = Convert.ToDouble(splitDanas[2]);
            double hospJuce = Convert.ToDouble(splitJuce[2]);

            double razlikaH = hospDanas - hospJuce;
            double eksHosp = Math.Log(hospJuce, hospDanas);
            double hospitalised = hospDanas;
            double daniHosp = 1;
            if (razlikaH > 0)
            {
                
                while (hospitalised <= 20000)
                {
                    hospitalised += razlikaH;
                    string dan = "+" + daniHosp + "d";
                    hosp.Points.AddXY(dan, hospitalised); //date, brZar
                    ++daniHosp;
                }
            }
            else //ako je negativan rast
            {
                Random r = new Random();
                int cnt = 0;
                foreach(string one in data)
                {
                    if (cnt % 5 == 0)
                    {
                        string[] spl = one.Split(',');
                        string hospitalised1 = spl[2];
                        string date1 = spl[6];
                        hosp.Points.AddXY(date1, hospitalised1);
                    }
                    ++cnt;
                }
                while (hospitalised > 0)
                {
                    hospitalised += razlikaH;
                    string dan = "+" + daniHosp + "d";
                    hosp.Points.AddXY(dan, hospitalised); //date, brZar
                    ++daniHosp;
                }
                lHospiDet.Text = "The number of hospitalised from COVID-19 could drop to zero in ";
            }
            var todayHosp = DateTime.Now;
            todayHosp = todayHosp.AddDays(daniHosp);

            lKolaps.Text = daniHosp.ToString("0") + " days";
            lKolapsDatum.Text = todayHosp.ToString("dd/MM/yyyy");
            //lExpHosp.Text = eksHosp.ToString("0.00");

            //double hospSutra = Math.Pow(hospDanas, eksHosp) - hospDanas;
            double hospSutra = razlikaH;
            double infSutra = Math.Pow(infDanas, eks) - infDanas;
            lTommorowHospitalised.Text = hospSutra.ToString("0");
            lTommorowInfected.Text = infSutra.ToString("0");
#endregion

            #region recovered - linearni
            //LINEARNI RAST!!!
            double recJuce = Convert.ToDouble(splitJuce[9]);
            double recDanas = Convert.ToDouble(splitDanas[9]);

            double razlikaDanasJuce = recDanas - recJuce;
            double recSutra = recDanas + razlikaDanasJuce;

            double dani1 = 1;
            while (recSutra <= infDanas)
            {
                recSutra += razlikaDanasJuce;
                string dan = "+" + dani1 + "d";
                recovered.Points.AddXY(dan, recSutra); //date, brZar
                ++dani1;
            }

            lPrognoza.Text = dani.ToString("0") + " days";
            var today1 = DateTime.Now;
            today1 = today1.AddDays(dani1);
                        
            double percOfPplToRecover = 100 - double.Parse(splitDanas[7]); //100 posto minus procenat smrtnih slucajeva

            lRecoveries.Text = "At this rate of recoveries, " + percOfPplToRecover.ToString("0.00") + "% of the infected population could recover in " + dani1.ToString("0") + " days, or by " + today1.ToString("dd/MM/yyyy");
            lTommorowRec.Text = razlikaDanasJuce.ToString("0");
            #endregion
            
        }
    }
}
