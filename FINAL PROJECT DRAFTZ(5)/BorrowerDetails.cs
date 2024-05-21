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
    public partial class BorrowerDetails : UserControl
    {
        public BorrowerDetails()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            Refresh();
        }

        private void inputIdMode()
        {
            confirmButton.Visible = false;
            cancelButton.Location = new Point(cancelButton.Location.Y - 76, cancelButton.Location.Y);
        }

        private void confirmBorrowMode()
        {
            confirmButton.Visible = true;
            confirmButton.Location = new Point(confirmButton.Location.Y + 76, confirmButton.Location.Y);
            cancelButton.Location = new Point(cancelButton.Location.Y + 76, cancelButton.Location.Y);
        }

  
    }
}
