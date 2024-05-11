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
using MySql.Data.MySqlClient;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
        }

        private void enterId_btn_Click(object sender, EventArgs e)
        {
            string id = id_txtbox.Text;

            DisplayBorrowerInfo(id);
        }

        private void DisplayBorrowerInfo(string id)
        {
            string borrowerName = "";
            string details = "";
            string borrowedBookCounts = "";
            string lastReturn = "";

            try
            {
                Bookreturndb.DisplayBorrowerInfo(id, out borrowerName, out details, out borrowedBookCounts, out lastReturn);

                namelbl.Text = borrowerName;
                detailslbl.Text = details;
                bbcountlbl.Text = borrowedBookCounts;
                lastreturnlbl.Text = lastReturn;
                Dsplay_namebrwer.Text = borrowerName;
                Dsplay_detailsbrwer.Text = details;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving borrower info: " + ex.Message);
            }
        }

        private void BookReturn_Load(object sender, EventArgs e)
        {
            borrowedbooks_tbl.Columns.Add("Title", 80);
            borrowedbooks_tbl.Columns.Add("Author", 80);
            borrowedbooks_tbl.Columns.Add("Due Date", 80);
            borrowedbooks_tbl.Columns.Add("Return", 80);
        }
    }
}
