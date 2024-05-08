using MySql.Data.MySqlClient;
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
    public partial class B_Books : UserControl
    {
        public B_Books()
        {
            InitializeComponent();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password=");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT bookId, B_id, B_name, B_date, D_date FROM borrowedbooks", con);


            // Right side table
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            

            // Left side table
            listView1.View = View.Details;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
               
                DataRow dr = dataTable.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["BookID"].ToString());
                listitem.SubItems.Add(dr["Title"].ToString());
                listitem.SubItems.Add(dr["Author"].ToString());
                listitem.SubItems.Add(dr["B_id"].ToString());
                listitem.SubItems.Add(dr["B_name"].ToString());
                listitem.SubItems.Add(((DateTime)dr["B_date"]).ToString("yyyy-MM-dd")); 
                listitem.SubItems.Add(((DateTime)dr["D_date"]).ToString("yyyy-MM-dd"));


                listView1.Items.Add(listitem);
            }
        }

        private void B_Books_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void B_Books_Load_1(object sender, EventArgs e)
        {

        }
    }
}
