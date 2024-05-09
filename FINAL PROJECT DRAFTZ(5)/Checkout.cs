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

        private void populatecheckout()
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Clear();

            BookContainer retrieveCheckout = new BookContainer();
            BookContainer.Checker = false;
            List<Books> checkoutList = retrieveCheckout.getCheckout;



            BookContainer[] books = new BookContainer[checkoutList.Count];
            
            for (int i = 0; i < 1; i++)
            {
                foreach (Books book in checkoutList)
                {
                    books[i] = new BookContainer();

                    books[i].Title = book.Title;
                    books[i].Year = book.Date;

                    flowLayoutPanel1.Controls.Add(books[i]);
                }
            }
        }





            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }


        }
    }

