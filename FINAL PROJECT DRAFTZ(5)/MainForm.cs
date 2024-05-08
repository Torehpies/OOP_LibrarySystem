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
    public partial class MainForm : Form
    {
        private Library libPane;
        private BorrowedList borrowPane;
        private BookReturn bookreturnPane;
        private BookInventory bookinventPane;

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            container_pnl.Controls.Clear();
            container_pnl.Controls.Add(userControl);
            userControl.BringToFront();

        }
        public MainForm()
        {
            InitializeComponent();

            libPane = new Library() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            borrowPane = new BorrowedList() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            bookreturnPane = new BookReturn() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            bookinventPane = new BookInventory() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };

            // Add panes to container panel
            container_pnl.Controls.Add(libPane);
            container_pnl.Controls.Add(borrowPane);
            container_pnl.Controls.Add(bookreturnPane);
            container_pnl.Controls.Add(bookinventPane);

            // Hide BorrowedList initially
            libPane.Show();
            libPane.FormBorderStyle = FormBorderStyle.None;
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void library_btn_Click(object sender, EventArgs e)
        {
          
            
            borrowPane.Show();
            libPane.FormBorderStyle = FormBorderStyle.None;
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Hide();
        }

        private void borrower_btn_Click(object sender, EventArgs e)
        {

            B_Books b_Books = new B_Books();   
            addUserControl(b_Books);
            libPane.Hide();
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Hide();
        }

        private void bookreturn_btn_Click(object sender, EventArgs e)
        {
            libPane.Hide();
            borrowPane.Hide();
            bookreturnPane.Show();
            bookreturnPane.FormBorderStyle = FormBorderStyle.None;
            bookinventPane.Hide();
        }

        private void bookinvent_btn_Click(object sender, EventArgs e)
        {
            libPane.Hide();
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Show();
            bookinventPane.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
