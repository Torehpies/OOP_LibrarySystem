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
            Refresh();
        }

        private void inputIdMode()
        {
            confirmButton.Visible = false;
            cancelButton.Location = new Point(cancelButton.Location.Y - 76, cancelButton.Location.Y);
        }

        private void confirmBorrowMode()
        {
            confirmButton.Visible = true;
            confirmButton.Location = new Point(confirmButton.Location.Y + 76, confirmButton.Location.Y);
            cancelButton.Location = new Point(cancelButton.Location.Y + 76, cancelButton.Location.Y);
        }

        private void checkIDBtn_Click(object sender, EventArgs e)
        {
            if (!BorrowerDB.DoesMemberExists(idTextbox.Texts))
            {
                warningText.Visible = true;
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





            //string studentID = idTextbox.Texts;
            //Checkout checkout = new Checkout();
            //Dictionary<string, int> bookAndQuanity = checkout.getBookAndQuanity();

            Checkout checkout = new Checkout();
            checkout.actualcheckout("testing");
            
           

            

            




           





        }
    }
}
