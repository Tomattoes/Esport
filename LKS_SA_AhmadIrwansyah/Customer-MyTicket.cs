using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_SA_AhmadIrwansyah
{
    public partial class Customer_MyTicket : Form
    {
        public Customer_MyTicket()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Customer_MainForm main = new Customer_MainForm();
            main.Show();
            this.Hide();
        }
    }
}
