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

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class BookInventory : Form
    {
        Controls.AddBookDashboard abDashboard = new Controls.AddBookDashboard();
        public BookInventory()
        {
            InitializeComponent();
            abDashboard.Visible = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            abDashboard.Visible = true;
            AddBookPanelMain.Controls.Clear();
            AddBookPanelMain.Controls.Add(abDashboard);
            abDashboard.Dock = DockStyle.Fill;

        }

        private void AddBookPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookInventory_Load(object sender, EventArgs e)
        {
            AddBookPanelMain.Controls.Clear();
            AddBookPanelMain.Controls.Add(abDashboard);
            abDashboard.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryEdit openLibrary = new LibraryEdit();
            openLibrary.ShowDialog();
        }
    }
}
