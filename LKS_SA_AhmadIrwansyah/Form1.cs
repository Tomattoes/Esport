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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Contexts;

namespace LKS_SA_AhmadIrwansyah
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");
        
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rgstr = new Register();
            rgstr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pw.Checked)
            {
                textBox_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '*';
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == ""
               || textBox_Password.Text == "")
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
                        string selectData = "SELECT * FROM pengguna WHERE username = @username " +
                                               "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, con))
                        {
                            cmd.Parameters.AddWithValue("@username", textBox_Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", textBox_Password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Admin_ScheduleForm mForm = new Admin_ScheduleForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_Username.Text = "";
                                textBox_Password.Text = "";
                            }
                        }
                    }
                    catch (Exception ex)
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

    }
}
