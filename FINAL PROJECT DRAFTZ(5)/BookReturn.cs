using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MySql.Data.MySqlClient;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
        }

        private void enterId_btn_Click(object sender, EventArgs e)
        {
            string id = id_txtbox.Text;

            DisplayBorrowerInfo(id);
            DisplayBorrowedBooks(id);
        }

        private void DisplayBorrowerInfo(string id)
        {
            string borrowerName = "";
            string details = "";
            string borrowedBookCounts = "";
            string lastReturn = "";

            try
            {
                Bookreturndb.DisplayBorrowerInfo(id, out borrowerName, out details, out borrowedBookCounts, out lastReturn);

                namelbl.Text = borrowerName;
                detailslbl.Text = details;
                bbcountlbl.Text = borrowedBookCounts;
                lastreturnlbl.Text = lastReturn;
                Dsplay_namebrwer.Text = borrowerName;
                //Dsplay_detailsbrwer.Text = details;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving borrower info: " + ex.Message);
            }
        }

        private void DisplayBorrowedBooks(string id)
        {
            
            try
            {
                DataTable borrowedBooksTable = new DataTable();

                // Call method from Bookreturndb class to get borrowed books info
                Bookreturndb.DisplayBorrowedBooks(id, out borrowedBooksTable);

                // Populate ListView with borrowed books data
                PopulateListView(borrowedBooksTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving borrowed books info: " + ex.Message);
            }
        }

        private void PopulateListView(DataTable borrowedBooksTable)
        {
            borrowedbooks_tbl.Items.Clear();

            foreach (DataRow row in borrowedBooksTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["title"].ToString());
                item.SubItems.Add(row["author"].ToString());
                item.SubItems.Add(((DateTime)row["dueDate"]).ToString("yyyy-MM-dd"));

                borrowedbooks_tbl.Items.Add(item);
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView
            if (borrowedbooks_tbl.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = borrowedbooks_tbl.SelectedItems[0];

                // Get the title of the selected book
                string title = selectedItem.SubItems[0].Text;

                // Get the current date
                DateTime returnDate = DateTime.Now;

                try
                {
                    // Update borrowedbooks table with the return date
                    bookCRUD.UpdateReturnDate(title, returnDate);

                    // Update books table to increment the available copies
                    bookCRUD.IncrementAvailableCopies(title);

                    // Remove the returned book from the ListView
                    borrowedbooks_tbl.Items.Remove(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating database: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select a book to confirm return.");
            }
        }

    }
}
