using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LKS_SA_AhmadIrwansyah
{
    internal class ScheduleData
    {
        public string Match { set; get; }
        public string Time {  set; get; }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public List<ScheduleData> ScheduleListData()
        {
            List<ScheduleData> listdata = new List<ScheduleData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectdata = "select * from schedule";

                    using(SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ScheduleData sd = new ScheduleData();
                            sd.Match = reader["away_team_id"].ToString() + " vs " + reader["home_team_id"].ToString();
                            sd.Time = reader["time"].ToString();

                            listdata.Add(sd);

                        }
                    }
                }
                catch(Exception ex)
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
}
