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
    public partial class FormHomepage : Form
    {
        private static FormHomepage instance;
        private static BookReturningForm instanceReturning;
        private static BorrowerListForm instanceBorrowerList;
        private PictureBox[] bookPictureBoxes;
        public FormHomepage()
        {
            InitializeComponent();
            InitializePictureBoxArray();
            InitializeBookData();
        }
        private void InitializeBookData()
        {

        }
        private void InitializePictureBoxArray()
        {
            bookPictureBoxes = new PictureBox[15];
            for (int i = 0; i < 15; i++)
            {
                string pictureBoxName = "Book" + (i + 1);
                bookPictureBoxes[i] = Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

                bookPictureBoxes[i].Click += BookPictureBox_Click;
            }
        }
        private void BookPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null)
            {
                string pictureBoxName = clickedPictureBox.Name;
                MessageBox.Show("PictureBox Clicked: " + pictureBoxName);
            }
        }
        private void FormHomepage_Load(object sender, EventArgs e)
        {
            BorrowerListLabel.Click += BorrowerListLabel_Click;
            LibraryLabel.Click += LibraryLabel_Click;
            ReturningLabel.Click += ReturningLabel_Click;
        }

        private void BorrowerListLabel_Click(object sender, EventArgs e)
        {
            if (instance != null && !instance.IsDisposed)
            {
                instance.Close();
            }
            if (instanceBorrowerList != null && !instanceBorrowerList.IsDisposed)
            {
                instanceBorrowerList.Close();
            }
            instanceBorrowerList = new BorrowerListForm();
            instanceBorrowerList.Show();

        }

        private void BorrowerListLabel_MouseEnter(object sender, EventArgs e)
        {
            BorrowerListLabel.BackColor = ColorTranslator.FromHtml("#FFFBEB");
            BorrowerListLabel.ForeColor = ColorTranslator.FromHtml("#495579");
        }

        private void BorrowerListLabel_MouseLeave(object sender, EventArgs e)
        {
            BorrowerListLabel.BackColor = ColorTranslator.FromHtml("#495579");
            BorrowerListLabel.ForeColor = ColorTranslator.FromHtml("#FFFBEB");
        }

        private void LibraryLabel_MouseEnter(object sender, EventArgs e)
        {
            LibraryLabel.BackColor = ColorTranslator.FromHtml("#FFFBEB");
            LibraryLabel.ForeColor = ColorTranslator.FromHtml("#495579");
        }

        private void LibraryLabel_MouseLeave(object sender, EventArgs e)
        {
            LibraryLabel.BackColor = ColorTranslator.FromHtml("#495579");
            LibraryLabel.ForeColor = ColorTranslator.FromHtml("#FFFBEB");
        }

        private void LibraryLabel_Click(object sender, EventArgs e)
        {
            if (instance != null && !instance.IsDisposed)
            {
                instance.Close();
            }
            else
            {
                instance = new FormHomepage();
                instance.Show();
            }
        }

        private void ReturningLabel_MouseEnter(object sender, EventArgs e)
        {
            ReturningLabel.BackColor = ColorTranslator.FromHtml("#FFFBEB");
            ReturningLabel.ForeColor = ColorTranslator.FromHtml("#495579");
        }

        private void ReturningLabel_MouseLeave(object sender, EventArgs e)
        {
            ReturningLabel.BackColor = ColorTranslator.FromHtml("#495579");
            ReturningLabel.ForeColor = ColorTranslator.FromHtml("#FFFBEB");
        }

        private void ReturningLabel_Click(object sender, EventArgs e)
        {
            if (instance != null && !instance.IsDisposed)
            {
                instance.Close();
            }
            if (instanceReturning != null && !instanceReturning.IsDisposed)
            {
                instanceReturning.Close();
            }
            instanceReturning = new BookReturningForm();
            instanceReturning.Show();
        }
    }
}
