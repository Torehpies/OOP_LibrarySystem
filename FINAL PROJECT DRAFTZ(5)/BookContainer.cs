using Org.BouncyCastle.Pkix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FINAL_PROJECT_DRAFTZ_5_
{


    public partial class BookContainer : UserControl
    {
        Book DetailsData;
        BookData BookDataInstance = BookData.Instance;
        public event EventHandler ButtonClick;
        private Library libraryForm;
        private Checkout checkoutForm;


        public bool ShowAddButton { get; set; } = true;
        public bool ShowRemoveButton { get; set; } = true;

        public BookContainer(Library parentForm)
        {
            InitializeComponent();
            this.libraryForm = parentForm;
            //detailsbtn.Text = "Details";
            numericUpDown2.Visible = false;

            
            
            
        }
        
        private NumericUpDown numericUpDown1;
        public BookContainer(Checkout parentForm)
        {
            InitializeComponent();
            this.checkoutForm = parentForm;
            availLabel.Text = "Remove";

            
            numericUpDown2.Visible = true;
            addbtn.Visible = false;


        }

        

        public BookContainer()
        {
            InitializeComponent();
        }


        private void detailsbtn_Click(object sender, EventArgs e)
        {
            
            if (this.libraryForm != null)
            {
                // Test data
                // MessageBox.Show($"The details for this book {Title}");

                /*
                BookDetails bookDetails = new BookDetails(Title, ISBN, Author, Category, Publisher, Year, aCopies, tCopies);
                bookDetails.Show();
                */

                MessageBox.Show("Hello");
            }
            else
            {
                checkoutForm.removeCard(this);
            }
            

        }

        static Dictionary<string, int> checkOutList = new Dictionary<string, int>();

        private void addbtn_Click(object sender, EventArgs e)
        {

            BookDetails bookDetails = new BookDetails(Title, ISBN, Author, Category, Publisher, Year, aCopies, tCopies);
            bookDetails.Show();
            


            /* Dating add button to
            Books addBook = new Books(Title, ISBN, Author, Category, Publisher, Year, aCopies, tCopies);

            //MessageBox.Show($"Bookname: `{Title}` {availCopies} is added to checkout");

            Checkout checkout1 = (this.ParentForm as Library).Controls["checkout1"] as Checkout;
            BookContainer book = new BookContainer();
            book._title = Title;
            book._author = Author;
            book._publisher = Publisher;
            book._year = Year;
            book._category = Category;
            book._ISBN = ISBN;
            book.availCopies = aCopies; 
            FlowLayoutPanel panel = checkout1.Controls["booksPanel"] as FlowLayoutPanel;
            panel.Controls.Add(book);

            bookTitles.Add(Title);
            checkout.Add(addBook);

            checkOutList[Title] = availCopies;
            */

        }

        public void addBook(string Title, string ISBN, string Author, string Category, string Publisher, string Year, int aCopies, int tCopies, int booksToBorrow)
        {
            Books addBook = new Books(Title, ISBN, Author, Category, Publisher, Year, aCopies, tCopies, booksToBorrow);
            //MessageBox.Show($"Bookname: `{Title}` {availCopies} is added to checkout");


            bookTitles.Add(Title);
            checkout.Add(addBook);
            checkOutList[Title] = availCopies;

        }

        

        #region Properties

        private string _title;
        private string _author;
        private string _category;
        private string _publisher;
        private string _year;
        private Image _icon;
        private string _ISBN;
        private static List<string> bookTitles = new List<string>();
        private static List<Books> checkout = new List<Books>();
        private int availCopies;
        private int totalCopies;
        private int booksToBorrow;

       
        public Dictionary<string, int> getdictList
        {
            get { return checkOutList; }
        }

        [Category("Custom Props")]
        public int BorrowCount
        {
            get { return booksToBorrow; }
            set { booksToBorrow = value;}
        }

        [Category("Custom Props")]
        public int tCopies
        {
            get { return totalCopies; }
            set { totalCopies = value; }
        }

        [Category("Custom Props")]
        public int aCopies
        {
            get { return availCopies; }
            set { availCopies = value; 
                if (libraryForm != null) availLabel.Text = availCopies + " left";

                
            }
        }

        



        [Category("Custom Props")]
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        [Category("Custom Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [Category("Custom Props")]
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        [Category("Custom Props")]
        public List<Books> getCheckout
        {
            get { return checkout; }
            set { checkout = value; }
        }

        [Category("Custom Props")]
        public List<string> checkoutTitles
        {
            get { return bookTitles; }
            set { bookTitles = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; bookTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Year
        {
            get { return _year; }
            set { _year = value; bookYear.Text = value; }
        }

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        [Category("Custom Props")]
        public Image icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        #endregion

        // Event handler for MouseEnter
        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            // Set the visibility of the button to true when the mouse enters the user control
            //detailsbtn.Visible = true;
        }

        // Event handler for MouseLeave
        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            // Set the visibility of the button to false when the mouse leaves the user control
            //detailsbtn.Visible = false;
        }

        private void bookYear_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
