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
    public partial class Admin_TransferPlayer : Form
    {

        SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EsemkaEsport;Data Source=ANDIWS\SQLEXPRESS");

        public Admin_TransferPlayer()
        {
            InitializeComponent();
            DisplayPlayer();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayPlayer();
        }

        public void DisplayPlayer()
        {
            TPlayer sd = new TPlayer();
            List<TPlayer> listData = sd.TPlayerListData();

            dataGridView2.DataSource = listData;
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

        private void combo1()
        {
            string query1 = "select id, team_name from team";
            SqlDataAdapter da = new SqlDataAdapter(query1, con);
            con.Open();
            DataSet dt = new DataSet();
            da.Fill(dt, "team_name");

            comboBox1.DisplayMember = "team_name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = dt.Tables["team_name"];
            con.Close();

            if (comboBox1.Items.Count>1)
            {
                comboBox1.SelectedIndex = -1;
            }
        }
        private void display_dataGridView1()
        {
            SqlCommand query2 = new SqlCommand("select p.nick_name from team_detail as td join player as p on td.player_id=p.id where td.team_id = '" + comboBox1.SelectedValue + "'", con);
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = query2;
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }

        private void Admin_TransferPlayer_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'esemkaEsportDataSet6.player' table. You can move, or remove it, as needed.
            this.playerTableAdapter1.Fill(this.esemkaEsportDataSet6.player);
            // TODO: This line of code loads data into the 'esemkaEsportDataSet5.player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.esemkaEsportDataSet5.player);
            // TODO: This line of code loads data into the 'esemkaEsportDataSet4.team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.esemkaEsportDataSet4.team);
            //combo1();
            display_dataGridView1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
  
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
