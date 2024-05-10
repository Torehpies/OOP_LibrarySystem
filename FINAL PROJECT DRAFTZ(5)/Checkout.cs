using System;
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
    public partial class Checkout : Form
    {

        public Checkout()
        {
            InitializeComponent();


        }



        private void Checkout_Load(object sender, EventArgs e)
        {
            populatecheckout();
        }

        List<Books> checkoutList = new List<Books>();
        public void removeCard(BookContainer userControl)
        {
            string titleToRemove = userControl.Title;
            Books bookToRemove = checkoutList.FirstOrDefault(book => book.Title == titleToRemove);
            if (bookToRemove != null)
            {
                MessageBox.Show($"Removed from checkout book: {titleToRemove}");
                checkoutList.Remove(bookToRemove);
            }
            flowLayoutPanel1.Controls.Remove(userControl);
        }



        private void populatecheckout()
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Clear();

            BookContainer retrieveCheckout = new BookContainer();

            checkoutList = retrieveCheckout.getCheckout;

            foreach (Books book in checkoutList)
            {
                BookContainer bookContainer = new BookContainer(this);
                bookContainer.Title = book.Title;
                bookContainer.Year = book.Date;


                flowLayoutPanel1.Controls.Add(bookContainer);
            }
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            BookContainer getList = new BookContainer();
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs = getList.getdictList;

            foreach (var key in keyValuePairs.Keys)
            {
                keyValuePairs[key]--;
            }

            Database update = new Database();
            foreach (var pairs in keyValuePairs)
            {
                update.updateDatabase(pairs);
            }

            this.Close();
            flowLayoutPanel1.Controls.Clear();
            checkoutList.Clear();
        }
    }
}

