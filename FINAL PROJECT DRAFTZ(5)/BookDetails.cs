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


    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        public void InitializeUI(Book BookContainerData)
        {

            picture.Image = Image.FromFile(BookContainerData.picturePath);
            titleLabel.Text = BookContainerData.title;
            publishedLabel.Text = "Published: " + BookContainerData.published;
            isbn10Label.Text = "ISBN-10: " + BookContainerData.isbn10;
            isbn13Label.Text = "ISBN-13: " + BookContainerData.isbn13;
            publisherLabel.Text = "Publisher: " + BookContainerData.publisher;
            authorLabel.Text = "Author: " + BookContainerData.author;
            categoryLabel.Text = "Category: " + BookContainerData.category;
            statusLabel.Text = "STATUS: " + BookContainerData.status;
            if (BookContainerData.status == Book.BookType.Borrowed)
            {
                BorrowButton.Enabled = false;
                BorrowButton.BackColor = Color.White;
                BorrowButton.Text = "NOT AVAILABLE";
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.TopMost = true;
            login.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
