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
    public partial class BookReturning : UserControl
    {
        public BookReturning()
        {
            InitializeComponent();
            AddBooksToComboBox();
        }

        private void AddBooksToComboBox()
        {
            foreach (Book book in BookData.Instance.BookList)
            {
                if (book.status == Book.BookType.Borrowed)
                {
                    BookListCB.Items.Add(book.title);
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!isTextBoxValid(this))
            {
                MessageBox.Show("Please check the information that is missing.", "Notice");
                return;
            }

            if (!isComboBoxValid())
            {
                MessageBox.Show("Invalid book title.\nPlease choose the title from the list.", "Notice");
                return;
            }

            User user = new User(FirstNameTB.Text, LastNameTB.Text);


            if (!UsersData.isUserExists(user))
            {
                MessageBox.Show("Incorrect information or User does not exist.", "Notice");
                return;
            }

            UsersData.deductBorrowCount(user);

        }

        private bool isComboBoxValid()
        {
            foreach (string title in BookListCB.Items)
            {
                if (BookListCB.Text == title)
                {
                    return true;
                }
            }

            return false;
        }
        private bool isTextBoxValid(Control container)
        {
            bool result = true;
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}
