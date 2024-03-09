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
    public partial class Customer_MainForm : Form
    {
        public Customer_MainForm()
        {
            InitializeComponent();
            DisplayScheduleData1();

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayScheduleData1();
        }

        public void DisplayScheduleData1()
        {
            ScheduleData1 sd = new ScheduleData1();
            List<ScheduleData1> listData1 = sd.ScheduleListData1();

            dataGridView1.DataSource = listData1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Apakah Anda yakin ingin logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_MyTicket tiket = new Customer_MyTicket();
            tiket.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Book")
            {
                this.Hide();
                Customer_BookForm bf = new Customer_BookForm();
                bf.Show();
            }
        }
    }
}
