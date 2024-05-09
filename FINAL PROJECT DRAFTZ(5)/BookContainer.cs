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

        private Library parentForm;

        public BookContainer(Library parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public BookContainer()
        {
            InitializeComponent();
        }

        // Event handler for MouseEnter
        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            // Set the visibility of the button to true when the mouse enters the user control
            borrowBtn.Visible = true;
        }

        // Event handler for MouseLeave
        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            // Set the visibility of the button to false when the mouse leaves the user control
            borrowBtn.Visible = false;
        }

        #region Properties

        private string _title;
        private string _year;
        private Image _icon;
        private string _ISBN;
        private static List<string> bookTitles = new List<string>();
        private static List<Books> checkout = new List<Books>();
        private int index;

        private void bookTitle_Click(object sender, EventArgs e)
        {

        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            parentForm.removeCard(this);
        }

        private static bool checker = true;
        public static bool Checker
        {
            get { return checker; }
            set { checker = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books addBook = new Books(Title, Year);

            
            MessageBox.Show($"Bookname: `{Title}` is added to checkout");
            bookTitles.Add(Title);
            checkout.Add(addBook);
            MessageBox.Show($"Added {Title} to bookTitles. Count: {bookTitles.Count} "); 
        }

        [Category("Custom Props")]
        public int Index
        {
            get { return index; }
            set {  index = value; }
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
            set {  bookTitles = value; }
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
    }
}
