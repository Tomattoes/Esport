using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LKS_SA_AhmadIrwansyah
{

    // admin
    internal class ScheduleData
    {
        public string Match { set; get; }
        public string Time { set; get; }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public List<ScheduleData> ScheduleListData()
        {
            List<ScheduleData> listdata = new List<ScheduleData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectdata = "select t1.team_name as home, t2.team_name as away, s.time from schedule as s join team as t1 on s.home_team_id=t1.id join team as t2 on s.away_team_id=t2.id where s.time > GETDATE()";

                    using (SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DateTime time = Convert.ToDateTime(reader["time"]);
                            ScheduleData sd = new ScheduleData();
                            sd.Match = reader["home"].ToString() + " vs " + reader["away"].ToString();
                            sd.Time = time.ToString("dddd, MMMM yyyy (HH:mm)");

                            listdata.Add(sd);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return listdata;
        }
    }

    // User
    internal class ScheduleData1
    {
        public string Match { set; get; }
        public string Time { set; get; }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public List<ScheduleData1> ScheduleListData1()
        {
            List<ScheduleData1> listdata1 = new List<ScheduleData1>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectdata = "select t1.team_name as home, t2.team_name as away, s.time from schedule as s join team as t1 on s.home_team_id=t1.id join team as t2 on s.away_team_id=t2.id where s.time > GETDATE()";

                    using (SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DateTime time = Convert.ToDateTime(reader["time"]);
                            ScheduleData1 sd = new ScheduleData1();
                            sd.Match = reader["home"].ToString() + " vs " + reader["away"].ToString();
                            sd.Time = time.ToString("dddd, MMMM yyyy (HH:mm)") ;

                            listdata1.Add(sd);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return listdata1;
        }
    }
}
