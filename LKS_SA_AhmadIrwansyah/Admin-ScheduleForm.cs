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
using System.IO;

namespace LKS_SA_AhmadIrwansyah
{
    public partial class Admin_ScheduleForm : Form
    {

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public Admin_ScheduleForm()
        {
            InitializeComponent();

            DisplayScheduleData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayScheduleData();
        }

        public void DisplayScheduleData()
        {
            ScheduleData sd = new ScheduleData();
            List<ScheduleData> listData = sd.ScheduleListData();

            dataGridView1.DataSource = listData;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_TransferPlayer tp = new Admin_TransferPlayer();
            tp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin_FormTeam af = new Admin_FormTeam();
            af.Show();
            this.Hide();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Admin_AddScheduleForm asf = new Admin_AddScheduleForm();
            asf.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Apakah Anda yakin ingin logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }
        }
    }
}
