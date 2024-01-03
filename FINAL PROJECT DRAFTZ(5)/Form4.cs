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
    public partial class BorrowerListForm : Form
    {
        private static FormHomepage instance;
        public BorrowerListForm()
        {
            InitializeComponent();
        }

        private void BorrowerListForm_Load(object sender, EventArgs e)
        {
            LibraryLabel.Click += LibraryLabel_Click;
        }

        private void LibraryLabel_Click(object sender, EventArgs e)
        {

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
    }
}
