using FINAL_PROJECT_DRAFTZ_5_;
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


    public partial class LandingForm : Form
    {
        BookReturning returnPanel = new BookReturning();
        BorrowerList borrowersPanel = new BorrowerList();
        private List <Book> books;
        public LandingForm()
        {
            InitializeComponent();
            InitializeBookContainers();
            contentPanel.Controls.Add(returnPanel);
            contentPanel.Controls.Add(borrowersPanel);
            //foreach (Book book in BookData.bookList)
            


        }

        private void InitializeBookContainers()
        {

            Label academicLabel = new Label();
            academicLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            academicLabel.ForeColor = Color.FromArgb(73, 85, 121);
            academicLabel.Size = new Size(203, 28);
            academicLabel.TabIndex = 1;
            academicLabel.Text = "ACADEMIC BOOKS";

            Label nonfictionLabel = new Label();
            nonfictionLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nonfictionLabel.ForeColor = Color.FromArgb(73, 85, 121);
            nonfictionLabel.Size = new Size(203, 28);
            nonfictionLabel.TabIndex = 1;
            nonfictionLabel.Text = "NON-FICTION BOOKS";

            Label fictionLabel = new Label();
            fictionLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fictionLabel.ForeColor = Color.FromArgb(73, 85, 121);
            fictionLabel.Size = new Size(203, 28);
            fictionLabel.TabIndex = 1;
            fictionLabel.Text = "FICTION BOOKS";

            libraryPanel.Controls.Add(academicLabel);

            Book[] BookList = new bookData().bookList;

            FlowLayoutPanel academicPanel = new FlowLayoutPanel();
            academicPanel.BackColor = Color.Transparent;
            academicPanel.AutoSize = true;
            academicPanel.AutoScroll = true;

            foreach (Book book in BookList)
            {
                if (book.category == "Academic")
                {
                    BookContainer bookContainer = new BookContainer();
                    bookContainer.InitializeUI(book);
                    academicPanel.Controls.Add(bookContainer);
                }
            }

            libraryPanel.Controls.Add(academicPanel);

            libraryPanel.Controls.Add(nonfictionLabel);


            FlowLayoutPanel nonfictionPanel = new FlowLayoutPanel();
            nonfictionPanel.BackColor = Color.Transparent;
            nonfictionPanel.AutoSize = true;
            nonfictionPanel.AutoScroll = true;

            foreach (Book book in BookList)
            {
                if (book.category == "Non-Fiction")
                {
                    BookContainer bookContainer = new BookContainer();
                    bookContainer.InitializeUI(book);
                    nonfictionPanel.Controls.Add(bookContainer);
                }
            }

            libraryPanel.Controls.Add(nonfictionPanel);

            libraryPanel.Controls.Add(fictionLabel);


            FlowLayoutPanel fictionPanel = new FlowLayoutPanel();
            fictionPanel.BackColor = Color.Transparent;
            fictionPanel.AutoSize = true;
            fictionPanel.AutoScroll = true;

            foreach (Book book in BookList)
            {
                if (book.category == "Fiction")
                {
                    BookContainer bookContainer = new BookContainer();
                    bookContainer.InitializeUI(book);
                    fictionPanel.Controls.Add(bookContainer);
                }
            }

            libraryPanel.Controls.Add(fictionPanel);

            contentPanel.Controls.Add(libraryPanel);
        }


        private void ReturningLabel_Click(object sender, EventArgs e)
        {
            libraryPanel.Hide();
            borrowersPanel.Hide();
            returnPanel.Show();
        }

        private void BorrowerListLabel_Click(object sender, EventArgs e)
        {
            libraryPanel.Hide();
            returnPanel.Hide();
            borrowersPanel.Show();
        }

        private void LibraryLabel_Click(object sender, EventArgs e)
        {
            returnPanel.Hide();
            borrowersPanel.Hide();
            libraryPanel.Show();
        }
    }
}
