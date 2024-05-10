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
        private DataTable originalDataTable;

        public B_Books()
        {
            InitializeComponent();
            originalDataTable = new DataTable();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password=;Convert Zero Datetime=True");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM borrowedbooks", con);


            // Right side table
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            // Left side table
            listView1.View = View.Details;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                DataRow dr = dataTable.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["bookID"].ToString());
                listitem.SubItems.Add(dr["borrowerId"].ToString());
                listitem.SubItems.Add(dr["borrowDate"].ToString());
                listitem.SubItems.Add(dr["returnDate"].ToString());
                listitem.SubItems.Add(dr["dueDate"].ToString());



                listView1.Items.Add(listitem);
            }
        }

        private void UpdateListView(DataTable dataTable)
        {
            listView1.Items.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["bookID"].ToString());
                listitem.SubItems.Add(dr["borrowerId"].ToString());
                listitem.SubItems.Add(dr["borrowDate"].ToString());
                listitem.SubItems.Add(dr["returnDate"].ToString());
                listitem.SubItems.Add(dr["dueDate"].ToString());


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetListView()
        {
            listView1.Items.Clear();
            LoadUsersData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();


            if (string.IsNullOrEmpty(searchText))
            {
                ResetListView();
                return;
            }



            // Construct the SQL query with the search condition
            string query = $"SELECT bookId, borrowerId, borrowDate, returnDate, dueDate FROM borrowedbooks WHERE " +
                           $"LOWER(bookId) LIKE '%{searchText.ToLower()}%' OR " +
                           $"LOWER(borrowerId) LIKE '%{searchText.ToLower()}%' OR " +
                           $"LOWER(borrowDate) LIKE '%{searchText.ToLower()}%' OR " +
                           $"LOWER(returnDate) LIKE '%{searchText.ToLower()}%' OR " +
                           $"LOWER(dueDate) LIKE '%{searchText.ToLower()}%'";

            // Create MySqlConnection and MySqlDataAdapter
            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password="))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    
                    DataTable filteredDataTable = new DataTable();
                    adapter.Fill(filteredDataTable);

                
                    UpdateListView(filteredDataTable);
                    
                }
            }
        }
    }
}
