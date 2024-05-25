using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using FINAL_PROJECT_DRAFTZ_5_.Controls;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BookInventory : Form
    {
        Controls.AddBookDashboard abDashboard = new Controls.AddBookDashboard();
        private LibraryEdit libraryEditForm;
        private AddBookDashboard addBookDashboard;
        private bool alternate = false;

        public BookInventory()
        {
            InitializeComponent();
            abDashboard.Visible = false;
            //AddBookPanelMain.Visible = false;
            InitializeLibraryEditForm();




        }

        private void InitializeLibraryEditForm()
        {
            libraryEditForm = new LibraryEdit();
            libraryEditForm.TopLevel = false;
            libraryEditForm.FormBorderStyle = FormBorderStyle.None;
            libraryEditForm.Dock = DockStyle.Fill;
            libraryeditpanel.Controls.Add(libraryEditForm);
            libraryEditForm.Show();
        }



        public void ShowEditLibrary()
        {
            //AddBookPanelMain.Visible = false;
            libraryEditForm.populateItems();
            libraryeditpanel.Visible = true;

        }

        private void ShowAddBooks()
        {
            //AddBookPanelMain.Visible = true;
        }






        private void button1_Click_1(object sender, EventArgs e)
        {

            /*
             * BookContainer bookContainer = new BookContainer(checkout1);
            Checkout checkout = new Checkout();
            checkout.Visible = true;
            checkout1.Visible = !checkout1.Visible;
            if (checkout1.Visible)
            {
                checkout1.refresh();
            }
             */

            /*
            AddBookDashboard addBooks = new AddBookDashboard();
            addBooks.Visible = false;
            addBookDashboard1.Visible = !addBookDashboard1.Visible;
            if (addBookDashboard1.Visible)
            {
                ShowEditLibrary();

            }
            */

            BookContainer bookContainer = new BookContainer(addBookDashboard1);
            AddBookDashboard add = new AddBookDashboard();
            add.Visible = true;
            addBookDashboard1.Visible = ! addBookDashboard1.Visible;
            if (!addBookDashboard1.Visible)
            {
                ShowEditLibrary();
            }






        }

        public void closeAddBook()
        {

            abDashboard.Visible = false;
            //AddBookPanelMain.Visible = false;
            //AddBookPanelMain.Controls.Clear();

        }

        private void AddBookPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookInventory_Load(object sender, EventArgs e)
        {
            //AddBookPanelMain.Controls.Clear();
            //AddBookPanelMain.Controls.Add(abDashboard);
            abDashboard.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            LibraryEdit openLibrary = new LibraryEdit();
            openLibrary.ShowDialog();
            */

            ShowEditLibrary();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            closeAddBook();
        }

        private void addBookDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
