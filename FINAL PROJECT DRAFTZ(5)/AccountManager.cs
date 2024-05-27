using ExcelDataReader;
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
using Z.Dapper.Plus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
            populate();

        }

        private void populate()
        {
            DataTable borrowedBooksTable = new DataTable();
            // Call method from Bookreturndb class to get borrowed books info
            Bookreturndb.DisplayMembers(out borrowedBooksTable);

            // Populate ListView with borrowed books data
            PopulateListView(borrowedBooksTable);

        }

        private void PopulateListView(DataTable borrowedBooksTable)
        {
            borrowedbooks_tbl.Items.Clear();
            foreach (DataRow row in borrowedBooksTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["username"].ToString());

                item.SubItems.Add(((DateTime)row["lastLogin"]).ToString());
                item.SubItems.Add(((DateTime)row["created"]).ToString());
                item.SubItems.Add(row["type"].ToString());

                borrowedbooks_tbl.Items.Add(item);
            }
        }

        private void confirm_btn_Click_1(object sender, EventArgs e)
        {
            // Check if items are checked in the ListView
            if (borrowedbooks_tbl.CheckedItems.Count > 0)
            {
                foreach (ListViewItem checkedItem in borrowedbooks_tbl.CheckedItems)
                {
                    // Get the title of the checked book
                    string name = checkedItem.SubItems[1].Text;
                    string id = checkedItem.SubItems[0].Text;

                    if (name == LoginDatabase.currentUsername)
                    {
                        MessageBox.Show("You cannot delete your own account!");
                        return;
                    }

                    //MessageBox.Show(id);
                    Database delete = new Database();
                    delete.deleteUser(Convert.ToInt32(id));

                    MessageBox.Show("Successfully deleted! Account: " + name);
                    populate();
                }
            }
            else
            {
                MessageBox.Show("Checkfields are empty");
            }

        }

        
        private void customButton1_Click(object sender, EventArgs e)
        {
            StudentFillUp studentFillUp = new StudentFillUp();
            studentFillUp.Show();
            
        }
    }
}
