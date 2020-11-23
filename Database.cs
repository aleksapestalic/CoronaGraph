using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaGraph
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {
            #region popunjavam listu
            string sqlComm = "SELECT * from data";
            List<string> data = new List<string>();
            data = DB.select9(sqlComm);
            popunilistView(listView1, data);
            #endregion
        }

        #region popunilistView
        private void popunilistView(ListView listView1, List<string> rows)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details; //da bi se videle kolone tj naslovi u listView            
            listView1.Columns.Add("id");
            listView1.Columns.Add("testedLast24h");
            listView1.Columns.Add("infectedLast24h");
            listView1.Columns.Add("totalHospitalised");
            listView1.Columns.Add("totalDeaths"); //sve ovo je za upis kolona tj "naslova" u listView
            listView1.Columns.Add("totalTested");
            listView1.Columns.Add("totalInfected");
            listView1.Columns.Add("date");
            listView1.Columns.Add("deathPercentage");
            listView1.Columns.Add("positivePercentage");
            try
            {
                foreach (string item in rows) //ciklus koji prolazi kroz svaki element u listi rows, a rows dodeljujemo kad pozivamo metodu
                {
                    ListViewItem lv1 = new ListViewItem(item.Split('|')[0]);
                    lv1.SubItems.Add(item.Split('|')[1]); //subItem je ono polje koje nije prvi red u listView
                    lv1.SubItems.Add(item.Split('|')[2]);
                    lv1.SubItems.Add(item.Split('|')[3]);
                    lv1.SubItems.Add(item.Split('|')[4]);
                    lv1.SubItems.Add(item.Split('|')[5]);
                    lv1.SubItems.Add(item.Split('|')[6]);
                    lv1.SubItems.Add(item.Split('|')[7].Substring(0, item.Split('|')[7].IndexOf(" "))); //date
                    lv1.SubItems.Add(item.Split('|')[8]);
                    lv1.SubItems.Add(item.Split('|')[9]);
                    listView1.Items.Add(lv1);

                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //da bi se sve lepo videlo u listView-u
            }
            catch (Exception)
            {
                MessageBox.Show("Nema podataka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion
    }
}
