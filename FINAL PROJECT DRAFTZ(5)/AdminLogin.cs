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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginButton_click(object sender, EventArgs e)
        {
            if (Adminuser.Text.Length == 0 || Adminpass.Text.Length == 0)
            {
                MessageBox.Show("Please fill in the entries");
                return;
            }

            if (!LoginDatabase.checkLogin(Adminuser.Text, Adminpass.Text, true))
            {
                MessageBox.Show("Wrong username or password");
                return;
            }

            this.Parent.Controls.Remove(this);
            //Control container = this.Parent;
            //container.Controls.Remove(this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
