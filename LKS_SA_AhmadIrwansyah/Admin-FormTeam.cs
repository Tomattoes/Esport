using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_SA_AhmadIrwansyah
{
    public partial class Admin_FormTeam : Form
    {

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public Admin_FormTeam()
        {
            InitializeComponent();

            DisplayTeamData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayTeamData();
        }

        public void DisplayTeamData()
        {
            TeamData sd = new TeamData();
            List<TeamData> listData = sd.TeamListData();

            dataGridView1.DataSource = listData;
        }

        public void clearfields()
        {
            textBox_tn.Text = "";
            textBox_cn.Text = "";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Admin_ScheduleForm sf = new Admin_ScheduleForm();
            sf.Show();
            this.Hide();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_tn.Text == ""
                || textBox_cn.Text == "")
            {
                MessageBox.Show("Harap mengisi seluruh formulir yang ada", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();

                        string check = "SELECT COUNT(id) FROM team WHERE team_name = @name AND deleted_at IS NULL";
                        using (SqlCommand ck = new SqlCommand(check, con))
                        {
                            ck.Parameters.AddWithValue("@name", textBox_tn.Text.Trim());    
                            int count = (int)ck.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Nama team " + textBox_tn.Text + " telah digunakan", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_tn.Text = "";
                                textBox_cn.Text = "";
                            }
                            else
                            {
                                DateTime today = DateTime.Now;
                                string insert = "INSERT INTO team(team_name, company_name, created_at) VALUES(@tn, @cn, @ct)";
                                using(SqlCommand cmd = new SqlCommand(insert, con))
                                {
                                    cmd.Parameters.AddWithValue("@tn", textBox_tn.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cn", textBox_cn.Text.Trim());
                                    cmd.Parameters.AddWithValue("@ct", today);
                                    cmd.ExecuteNonQuery();

                                    DisplayTeamData();

                                    MessageBox.Show("Added Succesfully!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearfields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
