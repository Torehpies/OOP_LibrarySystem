using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BorrowerList : UserControl
    {
        public BorrowerList()
        {
            InitializeComponent();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password=");
            con.Open();



            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test", con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            testView1.DataSource = dataTable;



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void StudentListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {

        }
    }
}
