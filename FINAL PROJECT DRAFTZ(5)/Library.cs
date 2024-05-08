using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            
            
        }

        private void Library_Load(object sender, EventArgs e)
        {
            populateItems();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        string[] testvalues = { "genrey", "ako", "ikaw", "monggi", "testing" };

        private void populateItems()
        {
            BookContainer[] card = new BookContainer[5];
            for (int i = 0; i < 5; i++)
            {
                card[i] = new BookContainer();
                card[i].Title = testvalues[i];
                card[i].Year = "taena mo";
                flowLayoutPanel1.Controls.Add(card[i]);
            }
        }


    }
}
