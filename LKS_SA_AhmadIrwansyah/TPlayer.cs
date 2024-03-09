using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_SA_AhmadIrwansyah
{
    internal class TPlayer
    {
        public string Nickname { set; get; }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public List<TPlayer> TPlayerListData()
        {
            List<TPlayer> listdata = new List<TPlayer>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectdata = "select id, nick_name from player where id NOT IN (select player_id from team_detail)";

                    using (SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            TPlayer sd = new TPlayer();
                            sd.Nickname = reader["nick_name"].ToString();

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
