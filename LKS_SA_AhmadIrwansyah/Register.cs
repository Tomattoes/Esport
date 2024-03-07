using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_SA_AhmadIrwansyah
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");
  
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == ""
                || textBox_Password.Text == ""
                || textBox_repass.Text == "")
            {
                MessageBox.Show("Harap mengisi seluruh formulir yang ada", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Password.Text != textBox_repass.Text)
            {
                MessageBox.Show("Password dan Re-type Password tidak sama", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox_Password.Text = "";
                textBox_repass.Text = "";
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();

                        string selectUser = "SELECT COUNT(id) FROM pengguna WHERE username = @user";
                        using (SqlCommand user = new SqlCommand(selectUser, con))
                        {
                            user.Parameters.AddWithValue("@user", textBox_Username.Text.Trim());
                            int count = (int)user.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Username " + textBox_Username.Text + " telah digunakan, gunakan username lain", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox_Username.Text = "";
                                textBox_Password.Text = "";
                                textBox_repass.Text = "";
                            }
                            else
                            {
                                DateTime today = DateTime.Now;

                                string jk = "";
                                if (radioButton1.Checked == true)
                                {
                                    jk = "1";
                                }
                                else if (radioButton2.Checked == true)
                                {
                                    jk = "0";
                                }

                                string insertData = "INSERT INTO pengguna(username, password, birthdate, gender, Role, created_at) VALUES (@username, @password, @birthday, @gender, @role, @created_at)";
                                using (SqlCommand insert = new SqlCommand(insertData, con))
                                {
                                    insert.Parameters.AddWithValue("@username", textBox_Username.Text.Trim());
                                    insert.Parameters.AddWithValue("@password", textBox_Password.Text.Trim());
                                    insert.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                    insert.Parameters.AddWithValue("@gender", jk);
                                    insert.Parameters.AddWithValue("@role", 1);
                                    insert.Parameters.AddWithValue("@created_at", today);

                                    insert.ExecuteNonQuery();

                                    MessageBox.Show("Akun berhasil diregistrasi", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoginForm login = new LoginForm();
                                    login.Show();
                                    this.Hide();
                                }
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

        private void checkBox_pw_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_pw.Checked)
            {
                textBox_Password.PasswordChar = '\0';
                textBox_repass.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '*';
                textBox_repass.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lgFrm = new LoginForm();
            lgFrm.Show();
            this.Hide();
        }
    }
}
