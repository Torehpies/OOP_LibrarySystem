using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Usertbox1.Text.Length == 0 || passwordtbox.Text.Length == 0 || passwordtbox1.Text.Length == 0)
            {
                MessageBox.Show("Fill the following fields.");
                return;
            }
            
            if (passwordtbox.Text != passwordtbox1.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }
         
            if (LoginDatabase.checkAccount(Usertbox1.Text))
            {
                MessageBox.Show("Account already exists");
                return;
            }

            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordtbox.Text, 11);
            LoginDatabase.addAccount(Usertbox1.Text, passwordHash);

            MessageBox.Show("Account: " + Usertbox1.Text + " is created.");
            this.Parent.Visible = false;
        }
    }
}
