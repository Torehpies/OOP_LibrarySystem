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
        public BookInventory()
        {
            InitializeComponent();
        }

        private void BookInventory_Load(object sender, EventArgs e)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("C:\\fonts\\Jura-VariableFont_wght.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(fontCollection.Families[0], 15, FontStyle.Bold);
            }
        }
    }
}
