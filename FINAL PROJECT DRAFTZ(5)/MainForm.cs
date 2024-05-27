using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class MainForm : Form
    {
        private Library libPane;
        private BorrowedList borrowPane;
        private BookReturn bookreturnPane;
        private BookInventory bookinventPane;
        private AccountManager accountsPane;

        public MainForm()
        {
            InitializeComponent();

            userLabel.Text = LoginDatabase.currentUsername;
            string username = LoginDatabase.currentUsername;
            if (LoginDatabase.isAdmin(username))
            {
                manageAcc.Visible = true;
            } else
            {
                manageAcc.Visible = false;
            }


            Region = Region.FromHrgn(RoundEdge.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            libPane = new Library() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            borrowPane = new BorrowedList() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            bookreturnPane = new BookReturn() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            bookinventPane = new BookInventory() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            accountsPane = new AccountManager() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };

            // Add panes to container panel
            container_pnl.Controls.Add(libPane);
            container_pnl.Controls.Add(borrowPane);
            container_pnl.Controls.Add(bookreturnPane);
            container_pnl.Controls.Add(bookinventPane);
            container_pnl.Controls.Add(accountsPane);

            // Hide BorrowedList initially
            libPane.Show();
            libPane.FormBorderStyle = FormBorderStyle.None;
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Hide();
            accountsPane.Hide();

        }

        private void library_btn_Click(object sender, EventArgs e)
        {
            // Reload yung mga kailangan ireload
            Library.Instance.populateItems();

            //borrowPane.Show();
            library_btn.BackColor = ColorTranslator.FromHtml("#F2E9E4");
            borrower_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            bookreturn_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            bookinvent_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");

            library_btn.ForeColor = ColorTranslator.FromHtml("#000000");
            borrower_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            bookreturn_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            bookinvent_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            libPane.Show();
            libPane.FormBorderStyle = FormBorderStyle.None;
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Hide();
            accountsPane.Hide();
        }

        private void borrower_btn_Click(object sender, EventArgs e)
        {
            //B_Books borrow = new B_Books();

            B_Books borrow = borrowPane.Controls[0] as B_Books;
            borrow.LoadUsersData();

            library_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            borrower_btn.BackColor = ColorTranslator.FromHtml("#F2E9E4");
            bookreturn_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            bookinvent_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");

            library_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            borrower_btn.ForeColor = ColorTranslator.FromHtml("#000000");
            bookreturn_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            bookinvent_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            libPane.Hide();
            borrowPane.Show();
            bookreturnPane.Hide();
            bookinventPane.Hide();
            accountsPane.Hide();
        }

        private void bookreturn_btn_Click(object sender, EventArgs e)
        {
            library_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            borrower_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            bookreturn_btn.BackColor = ColorTranslator.FromHtml("#F2E9E4");
            bookinvent_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");

            library_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            borrower_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            bookreturn_btn.ForeColor = ColorTranslator.FromHtml("#000000");
            bookinvent_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

            libPane.Hide();
            borrowPane.Hide();
            bookreturnPane.Show();
            bookreturnPane.FormBorderStyle = FormBorderStyle.None;
            bookinventPane.Hide();
            accountsPane.Hide();
        }

        private void bookinvent_btn_Click(object sender, EventArgs e)
        {
            library_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            borrower_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            bookreturn_btn.BackColor = ColorTranslator.FromHtml("#4A4E69");
            bookinvent_btn.BackColor = ColorTranslator.FromHtml("#F2E9E4");

            library_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            borrower_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            bookreturn_btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            bookinvent_btn.ForeColor = ColorTranslator.FromHtml("#000000");

            libPane.Hide();
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Show();
            bookinventPane.FormBorderStyle = FormBorderStyle.None;
            accountsPane.Hide();
        }

        private void manageAcc_Click(object sender, EventArgs e)
        {
            libPane.Hide();
            borrowPane.Hide();
            bookreturnPane.Hide();
            bookinventPane.Hide();
            accountsPane.Show();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void navigation_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
