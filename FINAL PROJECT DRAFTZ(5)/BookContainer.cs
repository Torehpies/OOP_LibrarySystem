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
    public partial class BookContainer : UserControl
    {
        public BookContainer()
        {
            InitializeComponent();
            //MouseEnter += MyUserControl_MouseEnter;
            //MouseLeave += MyUserControl_MouseLeave;
        }

       

        private void Book1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for MouseEnter
        private void MyUserControl_MouseEnter(object sender, EventArgs e)
        {
            // Set the visibility of the button to true when the mouse enters the user control
            borrowBtn.Visible = true;
        }

        // Event handler for MouseLeave
        private void MyUserControl_MouseLeave(object sender, EventArgs e)
        {
            // Set the visibility of the button to false when the mouse leaves the user control
            borrowBtn.Visible = false;
        }
    }
}
