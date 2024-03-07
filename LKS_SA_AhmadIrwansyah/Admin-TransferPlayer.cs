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
    public partial class Admin_TransferPlayer : Form
    {
        public Admin_TransferPlayer()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Admin_ScheduleForm sf = new Admin_ScheduleForm();
            sf.Show();
            this.Hide();
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            Admin_PlayerForm pf = new Admin_PlayerForm();
            pf.Show();
            this.Hide();
        }
    }
}
