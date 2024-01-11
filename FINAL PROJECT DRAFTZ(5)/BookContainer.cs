using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BookContainer : UserControl
    {
        Book BookData;
        public event EventHandler ButtonClick;
        public BookContainer()
        {
            InitializeComponent();
            
            //MouseEnter += MyUserControl_MouseEnter;
            //MouseLeave += MyUserControl_MouseLeave;
        }

        public void InitializeUI(Book BookContainerData)
        {
            BookData = BookContainerData;
            bookPic.Image = Image.FromFile(BookContainerData.picturePath);
            bookTitle.Text = BookContainerData.title;
            bookYear.Text = BookContainerData.published;
            if (BookContainerData.status == Book.BookType.Borrowed)
            {
                borrowBtn.Text = "SEE DETAILS";
            }
        }


        private void Book1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for MouseEnter
        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            // Set the visibility of the button to true when the mouse enters the user control
            borrowBtn.Visible = true;
        }

        // Event handler for MouseLeave
        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            // Set the visibility of the button to false when the mouse leaves the user control
            borrowBtn.Visible = false;
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            BookDetails bookDetails = new BookDetails();
            bookDetails.InitializeUI(BookData);
            
            bookDetails.ShowDialog();

        }
    }
}
