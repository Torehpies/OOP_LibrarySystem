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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void populateTable()
        {
            using (MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=test; password=;Convert Zero Datetime=True"))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM users", con);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                

                foreach (DataRow dr in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["username"].ToString());
                    
                    item.SubItems.Add(dr["created"].ToString());
                    item.SubItems.Add(dr["type"].ToString());
                    
                    //item.SubItems.Add(((DateTime)dr["returnDate"]).ToString("yyyy-MM-dd"));
                    users.Items.Add(item);
                }
            }

        }

        private void borrowedbooks_tbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
