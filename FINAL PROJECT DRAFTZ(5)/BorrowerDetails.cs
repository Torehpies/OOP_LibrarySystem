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
        public BorrowerDetails()
        {
            InitializeComponent();
        }

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

            Member member = BorrowerDB.GetMemberDetails(idTextbox.Texts);
            nameLabel.Text = member.Name;
            detailsLabel.Text = member.Department + " " + member.Details;
            idLabel.Text = member.Id;
            confirmBorrowMode();

        }

        public Book[] booksToBorrow(Book[] book)
        {
            return null;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (idTextbox.Texts.Length <= 0)
            {
                warningText.Text = "Please input required fields";
                warningText.Visible = true;
                return;
            }

            string studentID = idTextbox.Texts;
            Checkout checkout = new Checkout();
            Dictionary<string, int> bookAndQuanity = checkout.getBookAndQuanity();

            
            checkout.actualcheckout("testing");
            

        }
    }
}
