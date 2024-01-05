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

        public LandingForm()
        {
            InitializeComponent();
            InitializeBookContainers();
            contentPanel.Controls.Add(new BookReturning());
            
            
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

            libraryPanel.Controls.Add(academicLabel);

            FlowLayoutPanel academicPanel = new FlowLayoutPanel();
            academicPanel.BackColor = Color.Transparent;
            //academicPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            academicPanel.AutoSize = true;
            academicPanel.AutoScroll = true;

            Book[] BookList = new bookData().bookList;

            foreach (Book book in BookList)
            {
                BookContainer bookContainer = new BookContainer();
                bookContainer.BookContainerData = book;
                academicPanel.Controls.Add(bookContainer);
            }

            libraryPanel.Controls.Add(academicPanel);

            libraryPanel.Controls.Add(nonfictionLabel);

            contentPanel.Controls.Add(libraryPanel);
        }


        private void ReturningLabel_Click(object sender, EventArgs e)
        {
            libraryPanel.Visible = false;
            
        }
    }
}
