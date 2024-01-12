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
using static System.Reflection.Metadata.BlobBuilder;



namespace FINAL_PROJECT_DRAFTZ_5_
{


    public partial class LandingForm : Form
    {
        BookReturning returnPanel = new BookReturning();
        BorrowerList borrowersPanel = new BorrowerList();


        // public List <Book> books = new List<Book>();
        public LandingForm()
        {
            InitializeComponent();
            InitializeBookContainers();
            contentPanel.Controls.Add(returnPanel);
            contentPanel.Controls.Add(borrowersPanel);
            LandingFormReference.Reference = this;
        }

        public void RefreshLandingForm()
        {
            BookData.Instance.BookList[3].status = Book.BookType.Borrowed;
        }

        private Label CreateLabel(string label)
        {
            Label newLabel = new Label();
            newLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            newLabel.ForeColor = Color.FromArgb(73, 85, 121);
            newLabel.Size = new Size(203, 28);
            newLabel.TabIndex = 1;
            newLabel.Text = label;
            return newLabel;
        }

        private Panel CreateBookPanel(string category)
        {

            FlowLayoutPanel newPanel = new FlowLayoutPanel();
            newPanel.BackColor = Color.Transparent;
            newPanel.AutoSize = true;
            newPanel.AutoScroll = true;

            foreach (Book book in BookData.Instance.BookList)
            {
                if (book.category == category)
                {
                    BookContainer bookContainer = new BookContainer();
                    bookContainer.InitializeUI(book);
                    newPanel.Controls.Add(bookContainer);
                }
            }

            return newPanel;

        }
        private void InitializeBookContainers()
        {

            Label academicLabel = CreateLabel("ACADEMIC BOOKS");
            Label nonfictionLabel = CreateLabel("NON-FICTION BOOKS");
            Label fictionLabel = CreateLabel("FICTION BOOKS");

            Panel academicPanel = CreateBookPanel("Academic");
            Panel fictionPanel = CreateBookPanel("Fiction");
            Panel nonfictionPanel = CreateBookPanel("Non-Fiction");

            libraryPanel.Controls.Add(academicLabel);
            libraryPanel.Controls.Add(academicPanel);

            libraryPanel.Controls.Add(nonfictionLabel);
            libraryPanel.Controls.Add(nonfictionPanel);

            libraryPanel.Controls.Add(fictionLabel);
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

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshLandingForm();
        }
    }
}
