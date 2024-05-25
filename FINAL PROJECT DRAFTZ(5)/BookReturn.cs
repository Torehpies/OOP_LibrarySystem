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

            // Validate input
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter a borrower ID.");
                return;
            }

            if (!int.TryParse(id, out _))
            {
                MessageBox.Show("Please enter a valid borrower ID.");
                return;
            }

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
                bbcountslbl.Text = borrowedBookCounts;
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
                item.SubItems.Add(((DateTime)row["borrowDate"]).ToString("yyyy-MM-dd"));
                item.Tag = row["id"];  // Store the borrowedbook ID in the Tag property

                borrowedbooks_tbl.Items.Add(item);
            }
        }


        private void Borrowedbooks_tbl_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Select the item when its checkbox is checked
            e.Item.Selected = e.Item.Checked;
        }


        private void confirm_btn_Click(object sender, EventArgs e)
        {
            // Check if items are selected in the ListView
            if (borrowedbooks_tbl.SelectedItems.Count > 0)
            {
                // Get the borrower ID from the input
                string borrowerId = id_txtbox.Text;

                // Get the current date
                DateTime returnDate = DateTime.Now;

                // Iterate over each selected item
                foreach (ListViewItem selectedItem in borrowedbooks_tbl.SelectedItems)
                {
                    // Get the title of the selected book
                    string title = selectedItem.SubItems[0].Text;

                    // Get the borrowedbook ID from the Tag property
                    int borrowedBookId = (int)selectedItem.Tag;

                    try
                    {
                        // Update borrowedbooks table with the return date
                        Bookreturndb.UpdateReturnDateById(borrowedBookId, returnDate);

                        // Update books table to increment the available copies
                        Bookreturndb.IncrementAvailableCopies(title);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating database: " + ex.Message);
                    }
                }

                // Refresh the ListView to reflect the updated data
                DisplayBorrowedBooks(borrowerId);

                // Update the borrowed books count label
                int currentBorrowedBooksCount = Bookreturndb.GetCurrentBorrowedBooksCount(borrowerId);
                bbcountslbl.Text = currentBorrowedBooksCount.ToString();
            }
            else
            {
                MessageBox.Show("Please select a book to confirm return.");
            }
        }



    }
}