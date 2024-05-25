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
    public partial class BorrowerDetails : UserControl
    {
        //public Dictionary<string, int> checkoutBooks;

        public BorrowerDetails()
        {
            InitializeComponent();
        }

        Member currentMember;
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            warningText.Hide();
            idTextbox.Texts = string.Empty;
            inputIdMode();
        }

        private void inputIdMode()
        {
            nameLabel.Hide();
            detailsLabel.Hide();
            idLabel.Hide();
            confirmButton.Hide();
            cancelButton.Location = new Point(cancelButton.Location.X, 157);
        }

        private void confirmBorrowMode()
        {
            nameLabel.Show();
            detailsLabel.Show();
            idLabel.Show();

            confirmButton.Show();
            confirmButton.Location = new Point(confirmButton.Location.X, 223);
            cancelButton.Location = new Point(cancelButton.Location.X, cancelButton.Location.Y + 106);
        }

        private void checkIDBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextbox.Texts))
            {
                warningText.Text = "Please enter a borrower ID";
                warningText.Show();
                return;
            }

            if (!int.TryParse(idTextbox.Texts, out _))
            {
                warningText.Text = "Please enter a valid ID";
                warningText.Show();
                return;
            }

            if (!BorrowerDB.DoesMemberExists(idTextbox.Texts))
            {
                warningText.Text = "ID doesn't exist";
                warningText.Show();
                return;
            }

            currentMember = BorrowerDB.GetMemberDetails(idTextbox.Texts);
            nameLabel.Text = currentMember.Name;
            detailsLabel.Text = currentMember.Department + " " + currentMember.Details;
            idLabel.Text = currentMember.Id;
            confirmBorrowMode();

        }

        public Book[] booksToBorrow(Book[] book)
        {
            return null;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            //Checkout checkout = new Checkout();

            /*

            Checkout checkout = this.Parent as Checkout;

            Dictionary<string, int> checkoutBooks = checkout.getBookAndQuantity();
            Database database = new Database();

            MessageBox.Show("hello");
            
            foreach (KeyValuePair<string, int> books in checkoutBooks)
            {
                MessageBox.Show(books.Key);
                
                database.addBorrowedBooks(books.Key, currentMember.Id, books.Value);
            }
            */



            // Gumagana to ng maayos //
            Checkout checkout = this.Parent as Checkout;
            //checkout.actualcheckout("testing"); 
            List<Books> books = checkout.getBookAndQuantity();

            Database database = new Database();
            foreach (Books book in books)
            {
                if (book != null)
                {
                    //database.addBorrowedBooks(book.Title, currentMember.Id, 5);
                    MessageBox.Show(book.Title + " is the title and the member id is " + currentMember.Id);
                }
            }








            
            

        }
    }
}
