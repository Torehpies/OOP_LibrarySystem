using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DRAFTZ_5_
{


    public partial class BookDetails : Form
    {
        string title;
        string isbn;
        string author;
        string category;
        string publisher;
        string published;
        int avail;
        int total;
        int booksToBorrow;

        public BookDetails(string title, string isbn, string author, string category, string publisher, string published, int availableCopies, int totalCopies)
        {
            InitializeComponent();
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            this.avail = availableCopies;
            this.total = totalCopies;
            
        }

        public void populateDetails(object sender, EventArgs e)
        {
            populateDetails();
        }

        public void populateDetails()
        {
            titleLabel.Text = "Title: " + title;
            isbn10Label.Text = "ISBN: " + isbn;
            authorLabel.Text = "Author: " + author;
            categoryLabel.Text = "Category: " + category;
            publisherLabel.Text = "Publisher: " + publisher;
            publishedLabel.Text = "Year: " + published;
            availablecopies.Text = "Available Copies: " + avail + " of " + total;
            borrownumber.Maximum = avail;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        static Dictionary<string, int> checkOutList = new Dictionary<string, int>();
        private static List<string> bookTitles = new List<string>();
        private static List<Books> checkout = new List<Books>();

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            this.booksToBorrow = Convert.ToInt32(borrownumber.Value);
            if (booksToBorrow <= 0)
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            Books addBook = new Books(title, isbn, author, category, publisher, published, avail, total, Convert.ToInt32(borrownumber.Value));

            //MessageBox.Show($"Bookname: `{Title}` {availCopies} is added to checkout");
            BookContainer book = new BookContainer();

            book.Title = title;
            book.ISBN = isbn;
            book.Author = author;
            book.Publisher = publisher;
            book.Year = published;
            book.Category = category;

            
            book.aCopies = avail;
            book.BorrowCount = Convert.ToInt32(borrownumber.Value);

            // Books that are actually left
            int bookLeftUpdate = Convert.ToInt32(borrownumber.Value) - avail;
            book.aCopies = bookLeftUpdate;


   
            bookTitles.Add(title);
            checkout.Add(addBook);
            checkOutList[title] = avail;



            MessageBox.Show($"Bookname : `{title}` borrowed {booksToBorrow} books is added to checkout");
        }

        public static List<Books> getCheckout
        {
            get { return checkout; }
            set { checkout = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
