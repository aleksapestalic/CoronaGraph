using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaGraph
{
    class DB
    {
        public static string MyConnection = "server=127.0.0.1;uid=root;pwd=root;database=covid";
        //public static string MyConnection = "server=localhost;uid=root;pwd=root;database=covid19";

        public static List<string> getAllData()
        {
            MySqlConnection conn = new MySqlConnection(MyConnection);
            conn.Open();

            MySqlCommand comm = new MySqlCommand("select * from data order by date", conn);
            MySqlDataReader reader = comm.ExecuteReader();

            string testedLast24h = "";
            string infectedLast24h = "";
            string totalHospitalized = "";
            string totalDeaths = "";
            string totalTested = "";
            string totalInfected = "";
            string date = "";
            string deadliness = "";
            string infectedPerc = "";
            string recovered = "";
            string dateNative = "";

            List<string> ret = new List<string>();
            while (reader.Read())
            {
                testedLast24h = reader.GetValue(1).ToString();
                infectedLast24h = reader.GetValue(2).ToString();
                totalHospitalized = reader.GetValue(3).ToString();
                totalDeaths = reader.GetValue(4).ToString();
                totalTested = reader.GetValue(5).ToString();
                totalInfected = reader.GetValue(6).ToString();
                deadliness = reader.GetValue(7).ToString();
                infectedPerc = reader.GetValue(8).ToString();
                recovered = reader.GetValue(10).ToString();

                //date handling
                date = reader.GetValue(9).ToString();
                dateNative = date; //da vraca datum u originalnom formatu
                date = date.Substring(0, date.IndexOf(" "));
                string[] temp = date.Split('/');
                int mo = int.Parse(temp[0]);
                string day = temp[1];
                string year = temp[2];
                string month = "";
                switch (mo)
                {
                    case 1:
                        month = "Jan";
                        break;
                    case 2:
                        month = "Feb";
                        break;
                    case 3:
                        month = "Mar";
                        break;
                    case 4:
                        month = "Apr";
                        break;
                    case 5:
                        month = "May";
                        break;
                    case 6:
                        month = "Jun";
                        break;
                    case 7:
                        month = "Jul";
                        break;
                    case 8:
                        month = "Aug";
                        break;
                    case 9:
                        month = "Sep";
                        break;
                    case 10:
                        month = "Oct";
                        break;
                    case 11:
                        month = "Nov";
                        break;
                    case 12:
                        month = "Dec";
                        break;
                }

                string dateFinal = day + " " + month;
                string formatted = testedLast24h + "," + infectedLast24h + "," + totalHospitalized + "," + totalDeaths + "," + totalTested + "," + totalInfected + "," + dateFinal + "," + deadliness + "," + infectedPerc + "," + recovered + "," + dateNative;                ret.Add(formatted);
            }
            
            conn.Close();
            return ret;
        }

        public static List<string> getAllCities(string searchName)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection);
            conn.Open();

            MySqlCommand comm = new MySqlCommand("select cityName, infected, percentage, date from cities where cityName = '" + searchName + "' order by date", conn);
            MySqlDataReader reader = comm.ExecuteReader();

            string cityName = "";
            string infected = "";
            string perc = "";
            string date = "";
            

            List<string> ret = new List<string>();
            while (reader.Read())
            {
                cityName = reader.GetValue(0).ToString();
                infected = reader.GetValue(1).ToString();
                perc = reader.GetValue(2).ToString();

                #region date
                //date handling
                date = reader.GetValue(3).ToString();
                date = date.Substring(0, date.IndexOf(" "));
                string[] temp = date.Split('/');
                int mo = int.Parse(temp[0]);
                string day = temp[1];
                string year = temp[2];
                string month = "";
                switch (mo)
                {
                    case 1:
                        month = "Jan";
                        break;
                    case 2:
                        month = "Feb";
                        break;
                    case 3:
                        month = "Mar";
                        break;
                    case 4:
                        month = "Apr";
                        break;
                    case 5:
                        month = "May";
                        break;
                    case 6:
                        month = "Jun";
                        break;
                    case 7:
                        month = "Jul";
                        break;
                    case 8:
                        month = "Aug";
                        break;
                    case 9:
                        month = "Sep";
                        break;
                    case 10:
                        month = "Oct";
                        break;
                    case 11:
                        month = "Nov";
                        break;
                    case 12:
                        month = "Dec";
                        break;
                }
                #endregion

                string dateFinal = day + " " + month;
                string formatted = cityName + "," + infected + "," + perc + "," + dateFinal;
                ret.Add(formatted);                
            }
            conn.Close();
            return ret;
        }

        public static List<string> getCityNames()
        {
            MySqlConnection conn = new MySqlConnection(MyConnection);
            conn.Open();

            MySqlCommand comm = new MySqlCommand("select distinct cityName from cities order by cityName", conn);
            MySqlDataReader reader = comm.ExecuteReader();

            string name = "";
            


            List<string> ret = new List<string>();
            while (reader.Read())
            {
                name = reader.GetValue(0).ToString();
                
                string formatted = name;
                ret.Add(formatted);
            }
            conn.Close();
            return ret;
        }

        public static List<string> getTopCities(string TodaysDate)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection);
            conn.Open();
            
            MySqlCommand comm = new MySqlCommand("select distinct cityName, infected, percentage from cities where date = '"+ TodaysDate + "' order by infected desc", conn);
            MySqlDataReader reader = comm.ExecuteReader();

            string cityName = "";
            string infected = "";
            string perc = "";
            //test komitova

            List<string> ret = new List<string>();
            while (reader.Read())
            {
                cityName = reader.GetValue(0).ToString();
                infected = reader.GetValue(1).ToString();
                perc = reader.GetValue(2).ToString();

                string formatted = cityName + "," + infected + "," + perc;
                ret.Add(formatted);
            }
            /*if (ret.Count > 0)
            {
                string one = ret[0].Substring(0, ret[0].IndexOf(','));
                if ((ret[0].Substring(0, ret[0].IndexOf(',')) != "Београд") || (ret[0].Substring(0, ret[0].IndexOf(',')) != "БЕОГРАД"))
                {
                    conn.Close();
                    return null;
                }
            }
            else
            {
                conn.Close();
                return null;
            }*/
            conn.Close();
            return ret;
        }

        #region select 9
        public static List<string> select9(string sqlCommand) //vraca listu sa redovima podataka naguranim u jednu recenicu na osnovu upita (SELECT * FROM table -> sqlCommand)
        {
            MySqlConnection conn = new MySqlConnection(MyConnection);
            try
            {
                List<string> rows = new List<string>();
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = sqlCommand;


                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rows.Add(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5) + "|" + reader.GetString(6) + "|" + reader.GetString(7) + "|" + reader.GetString(8) + "|" + reader.GetString(9));
                    }
                    conn.Close();
                    return rows;
                }
                else
                {
                    conn.Close();
                    rows.Add("No rows found."); return rows;
                }

            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion     
    }
}
