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
    public partial class Book1Form : Form
    {
        public Book1Form()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            Form frm1 = new BorrowingForm();
            frm1.ShowDialog();
        }
    }
}
