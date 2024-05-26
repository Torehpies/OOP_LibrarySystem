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
            id_txtbox.KeyPress += new KeyPressEventHandler(id_txtbox_KeyPress);
            id_txtbox.TextChanged += new EventHandler(id_txtbox_TextChanged);

            Dsplay_borrowedbooks.Visible = false;
        }

        private void enterId_btn_Click(object sender, EventArgs e)
        {
            errorMsg.Text = ""; // Clear previous error messages
            string id = id_txtbox.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(id))
            {
                errorMsg.Text = "Please enter a borrower ID.";
                return;
            }

            if (!int.TryParse(id, out _))
            {
                errorMsg.Text = "Please enter a valid borrower ID.";
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

                if (string.IsNullOrEmpty(borrowerName))
                {
                    errorMsg.Text = "No matching borrower ID found.";
                    namelbl.Text = "";
                    detailslbl.Text = "";
                    bbcountslbl.Text = "";
                    Dsplay_borrowedbooks.Visible = false;
                    return;
                }

                namelbl.Text = borrowerName;
                detailslbl.Text = details;
                bbcountslbl.Text = borrowedBookCounts;
                Dsplay_borrowedbooks.Visible = true;
                //Dsplay_detailsbrwer.Text = details;
            }
            catch (Exception ex)
            {
                errorMsg.Text = "Error retrieving borrower info: " + ex.Message;
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
                item.SubItems.Add(row["quantity"].ToString());
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
            // Check if items are checked in the ListView
            if (borrowedbooks_tbl.CheckedItems.Count > 0)
            {
                // Get the borrower ID from the input
                string borrowerId = id_txtbox.Text;

                // Get the current date
                DateTime returnDate = DateTime.Now;

                // Initialize total returned books count
                int totalReturnedBooks = 0;

                // Iterate over each checked item
                foreach (ListViewItem checkedItem in borrowedbooks_tbl.CheckedItems)
                {
                    // Get the title of the checked book
                    string title = checkedItem.SubItems[0].Text;

                    // Get the quantity of the checked book
                    int quantity = int.Parse(checkedItem.SubItems[2].Text);

                    // Add the quantity to the total returned books count
                    totalReturnedBooks += quantity;

                    // Get the borrowedbook ID from the Tag property
                    int borrowedBookId = (int)checkedItem.Tag;

                    try
                    {
                        // Update borrowedbooks table with the return date
                        Bookreturndb.UpdateReturnDateById(borrowedBookId, returnDate);

                        // Update books table to increment the available copies
                        Bookreturndb.IncrementAvailableCopies(title, quantity);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating database: " + ex.Message);
                    }
                }

                // Refresh the ListView to reflect the updated data
                DisplayBorrowedBooks(borrowerId);

                // Recalculate and update the total borrowed books count
                int currentBorrowedBooksCount = Bookreturndb.GetCurrentTotalBorrowedBooksCount(borrowerId);
                bbcountslbl.Text = currentBorrowedBooksCount.ToString();
            }
            else
            {
                MessageBox.Show("Please select a book to confirm return.");
            }
        }



        private void id_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a number or a control key (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void id_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (id_txtbox.Text.Length > 15)
            {
                id_txtbox.Text = id_txtbox.Text.Substring(0, 15);
                id_txtbox.SelectionStart = id_txtbox.Text.Length; // Move the cursor to the end
            }
        }
    }
}