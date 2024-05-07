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
            if (Usertbox1.Text == null || passwordtbox.Text == null || passwordtbox1.Text == null)
            {
                MessageBox.Show("Fill the following fields.");
                return;
            }

            
            if (passwordtbox.Text != passwordtbox1.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }

           
            Database addData = new Database();
            if (addData.checkAccount(Usertbox1.Text))
            {
                MessageBox.Show("Account already exists");
                return;
            }

            string passwordHash = null;
            passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordtbox.Text, 11);
            addData.addAccount(Usertbox1.Text, passwordHash);
            this.Hide();

            MessageBox.Show("Account: " + Usertbox1.Text + " is created.");
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();


        }
    }
}
