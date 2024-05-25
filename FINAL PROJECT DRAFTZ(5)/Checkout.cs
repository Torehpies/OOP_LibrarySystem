using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class Checkout : UserControl
    {
        List<Books> checkoutList = new List<Books>();
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        BookContainer getList = new BookContainer();

        
     


        public Checkout()
        {
            InitializeComponent();
            keyValuePairs = getList.getdictList;
            borrowerDetails1.Visible = false;

        }

       



        private void Checkout_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            populatecheckout();
            
        }


        public void removeCard(BookContainer userControl)
        {
            string titleToRemove = userControl.Title;
            Books bookToRemove = checkoutList.FirstOrDefault(book => book.Title == titleToRemove);
            if (bookToRemove != null)
            {
                MessageBox.Show($"Removed from checkout book: {titleToRemove}");
                checkoutList.Remove(bookToRemove);
                keyValuePairs.Remove(bookToRemove.Title);
                MessageBox.Show($"Removed: {bookToRemove.Title}");
                MessageBox.Show($"Dict count: {keyValuePairs.Count}");
            }
            booksPanel.Controls.Remove(userControl);
        }



        private void populatecheckout()
        {
            
            booksPanel.AutoScroll = true;
            booksPanel.Controls.Clear();
            checkoutList = BookDetails.getCheckout;

            int borrowCount = 0;
            Dictionary<string, int> bookTitleCount = new Dictionary<string, int>();
            foreach (Books book in checkoutList)
            {
                BookContainer bookContainer = new BookContainer(this);
                // Gawa tayo ng list ng mga duplicates.
                if (bookTitleCount.ContainsKey(book.Title))
                {
                    // May duplicated
                    bookTitleCount[book.Title]++;
                    borrowCount = book.BooksToborrow + borrowCount;
                }
                else
                {
                    // Unique
                    bookTitleCount[book.Title] = 1;
                }

                // Check natin yung libro kung duplicated
                if (bookTitleCount[book.Title] > 1)
                {
                    // May duplicated
                    bookContainer.BorrowCount += book.BooksToborrow;
                    break;

                }

                // Gawin yung pane
                
                bookContainer.Title = book.Title;
                bookContainer.Year = book.Date;
                bookContainer.aCopies = book.AvailableCopies;
                bookContainer.tCopies = book.TotalCopies;
                bookContainer.BorrowCount = book.BooksToborrow;
                //MessageBox.Show("Books to borrow: " + book.BooksToborrow);
                bookContainer.numericUpDown2.Value = book.BooksToborrow;
                bookContainer.numericUpDown2.Maximum = book.AvailableCopies;

                // Add the value pair in a dictionary
                booksPanel.Controls.Add(bookContainer);
                
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (checkoutList.Count <= 0)
            {
                MessageBox.Show("Nothing to checkout");
                return;
            }
            
            borrowerDetails1.Visible = true;
        }

        public void actualcheckout(string borrowerId)
        {
            while (booksPanel.Controls.Count > 0)
            {

                if (checkoutList.Count > 0)
                {
                    //Dictionary<string, int> keyValuePair = new Dictionary<string, int>();
                    foreach (Control control in booksPanel.Controls)
                    {

                        if (control is BookContainer bookContainer)
                        {
                            string title = bookContainer.Title;


                            int newAvailBooks = bookContainer.aCopies - Convert.ToInt32(bookContainer.numericUpDown2.Value);
                            keyValuePairs[title] = newAvailBooks;

                            //MessageBox.Show("Title: " + title + " borrowing: " + bookContainer.numericUpDown2.Value + " new available book total is: " + newAvailBooks);

                            removeCard(bookContainer);
                        }

                    }

                    Database update = new Database();
                    foreach (var pairs in keyValuePairs)
                    {
                        update.updateDatabase(pairs);
                    }

                    // Reset para gamitin ule
                    keyValuePairs.Clear();
                    checkoutList.Clear();
                }
                else
                {
                    MessageBox.Show("Nothing to checkout");
                    //this.Close();
                }
            }
        }


        

        public Dictionary<string, int> getBookAndQuanity()
        {
            return keyValuePairs;
        }

        private void borrowerDetails1_Load(object sender, EventArgs e)
        {

            
        }
    }
}

