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
    internal class PlayerData
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Nickname { set; get; }
        public string Birthday { set; get; }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public List<PlayerData> PlayerListData()
        {
            List<PlayerData> listdata = new List<PlayerData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectdata = "select * from player";

                    using (SqlCommand cmd = new SqlCommand(selectdata, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PlayerData sd = new PlayerData();
                            sd.Id = (int)reader["id"];
                            sd.Name = reader["name"].ToString();
                            sd.Nickname = reader["nick_name"].ToString();
                            sd.Birthday = reader["birthdate"].ToString();

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
