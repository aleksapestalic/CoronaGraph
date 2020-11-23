using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaGraph
{
    public partial class CitiesChange : Form
    {
        public CitiesChange()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void CitiesChange_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("City name");
            listView1.Columns.Add("Yesterday");
            listView1.Columns.Add("Today");
            listView1.Columns.Add("Diff");
            listView1.Items.Add("Loading ...");

            worker.DoWork += DoWork;
            worker.RunWorkerCompleted += WorkerCompleted;
            worker.RunWorkerAsync();

        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> cities = DB.getCityNames();

            for (int i = 0; i < cities.Count; i++)
            {
                int percentage = (i + 1) * 100 / cities.Count;
                worker.ReportProgress(percentage);
                List<string> data = new List<string>();
                data = DB.getAllCities(cities[i]);
                string city = cities[i];

                string valueYesterday = "";
                string valueToday = data[data.Count - 1].ToString().Split(',')[1];
                try
                {
                    valueYesterday = data[data.Count - 2].ToString().Split(',')[1];
                }
                catch
                {
                    city = char.ToUpper(city.ToLower()[0]) + (city.Substring(1, city.Length - 1)).ToLower();
                    list.Add("?" + city + ",0," + valueToday);
                    continue;
                }

                if (valueToday != valueYesterday)
                {
                    city = char.ToUpper(city.ToLower()[0]) + (city.Substring(1, city.Length - 1)).ToLower();

                    if (int.Parse(valueYesterday) > int.Parse(valueToday))
                    {
                        list.Add("!" + city + "," + valueYesterday + "," + valueToday+",");
                    }
                    else list.Add(city + "," + valueYesterday + "," + valueToday);
                }
                
            }
            if (listView1.Items.Count == 0) listView1.Items.Add("No changes!");
        }

        private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int br = 0;
            listView1.Items.Clear();
            foreach (var item in list)
            {
                //bg,100,150
                string city = item.Split(',')[0];
                string valYesterday = item.Split(',')[1];
                string valToday = item.Split(',')[2];

                int diff = int.Parse(valToday) - int.Parse(valYesterday);

                string[] row = { city, valYesterday, valToday, diff.ToString() };
                ListViewItem lvItem = new ListViewItem(row);

                listView1.Items.Add(lvItem);
                //listView1.Items[br].ForeColor = Color.Red;
                if (lvItem.Text.StartsWith("!"))
                {
                    lvItem.Text = lvItem.Text.Substring(1, lvItem.Text.Length - 1);
                    listView1.Items[br].ForeColor = Color.DarkGreen;
                    listView1.Items[br].Font = new Font(listView1.Items[br].Font, FontStyle.Bold);
                }

                if(lvItem.Text.StartsWith("?"))
                {
                    lvItem.Text = lvItem.Text.Substring(1, lvItem.Text.Length - 1);
                    listView1.Items[br].ForeColor = Color.DarkOrange;
                    listView1.Items[br].Font = new Font(listView1.Items[br].Font, FontStyle.Bold);
                }
                
                br++;
            }
            listView1.Columns[0].Width = -1;
            listView1.Columns[1].Width = -2;
            listView1.Columns[2].Width = -2;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            listView1.Items[0].Text = ("Loading ... " + e.ProgressPercentage + "%");
            listView1.Columns[0].Width = -1;
            listView1.Columns[1].Width = -2;
            listView1.Columns[2].Width = -2;
        }
    }
}
