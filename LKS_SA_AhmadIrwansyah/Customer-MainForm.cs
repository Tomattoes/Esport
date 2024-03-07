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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show("Apakah anda yakin ingin logout?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_MyTicket tiket = new Customer_MyTicket();
            tiket.Show();
            this.Hide();
        }
    }
}
