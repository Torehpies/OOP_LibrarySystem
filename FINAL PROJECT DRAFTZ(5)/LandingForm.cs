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
using System.Runtime.InteropServices;



namespace FINAL_PROJECT_DRAFTZ_5_
{


    public partial class LandingForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public LandingForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1080, 720, 25, 25));
            InitializeComponent();
            InitializeBookContainers();
            LandingFormReference.Reference = this;
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
            BookReturning returnPanel = new BookReturning();
            returnPanel.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(returnPanel);
            returnPanel.BringToFront();
            returnPanel.Show();
        }

        private void BorrowerListLabel_Click(object sender, EventArgs e)
        {
            BorrowerList borrowerPanel = new BorrowerList();
            borrowerPanel.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(borrowerPanel);
            borrowerPanel.BringToFront();
            borrowerPanel.Show();
        }

        private void LibraryLabel_Click(object sender, EventArgs e)
        {

            contentPanel.Controls.Add(libraryPanel);
            libraryPanel.BringToFront();
            libraryPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
