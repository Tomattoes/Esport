using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LKS_SA_AhmadIrwansyah
{
    public partial class Admin_AddScheduleForm : Form
    {
        public Admin_AddScheduleForm()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd H:mm:ss";

        }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == ""
                || comboBox2.Text == ""
                || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Harap isi seluruh formulir yang ada!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();

                        DateTime today = DateTime.Now;
                        string insertData = "INSERT INTO schedule(home_team_id, away_team_id, time, created_at) VALUES(@home, @away, @time, @created)";
                        using (SqlCommand cmd = new SqlCommand(insertData, con))
                        {

                            cmd.Parameters.AddWithValue("@home", comboBox1);
                            cmd.Parameters.AddWithValue("@away", comboBox2);
                            cmd.Parameters.AddWithValue("@time", dateTimePicker1.Text);
                            cmd.Parameters.AddWithValue("@created", today);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Admin_ScheduleForm sf = new Admin_ScheduleForm();
            sf.Show();
            this.Hide();
        }

        private void Admin_AddScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'esemkaEsportDataSet2.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter2.Fill(this.esemkaEsportDataSet2.team);
            // TODO: This line of code loads data into the 'esemkaEsportDataSet1.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter1.Fill(this.esemkaEsportDataSet1.team);
            // TODO: This line of code loads data into the 'esemkaEsportDataSet.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.esemkaEsportDataSet.team);

        }
    }
}
