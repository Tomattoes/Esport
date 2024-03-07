using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_SA_AhmadIrwansyah
{
    internal class TeamData
    {

        public int Id { set; get; }
        public string Name { set; get; }
        public string Company { set; get; }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");


        public List<TeamData> TeamListData()
        {
            List<TeamData> listdata = new List<TeamData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectdata = "select * from team";

                    using (SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            TeamData sd = new TeamData();
                            sd.Id = (int)reader["id"];
                            sd.Name = reader["team-name"].ToString();
                            sd.Company = reader["company_name"].ToString();

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
}
