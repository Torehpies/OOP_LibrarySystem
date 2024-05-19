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


        }



        private void Checkout_Load(object sender, EventArgs e)
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
            if ( checkoutList.Count > 0)
            {
                foreach (var key in keyValuePairs.Keys)
                {
                    keyValuePairs[key]--;
                }

                Database update = new Database();
                foreach (var pairs in keyValuePairs)
                {
                    update.updateDatabase(pairs);
                }

                // Di ako sure dito kung ganito mag refresh
                if (Library.Instance != null)
                {
                    Library.Instance.populateItems();

                }
                


                //this.Close();
                flowLayoutPanel1.Controls.Clear();
                checkoutList.Clear();

                



            } else
            {
                MessageBox.Show("Nothing to checkout");
                //this.Close();

                
            }
            
        }
    }
}

