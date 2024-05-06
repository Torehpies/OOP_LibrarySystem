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
            Database addData = new Database();
            string passwordHash = null;
            if (passwordtbox.Text == passwordtbox1.Text)
            {
                passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(passwordtbox.Text, 11);
                addData.addAccount(Usertbox1.Text, passwordHash);
                this.Hide();

                MessageBox.Show("Account: " + Usertbox1.Text + " is created.");
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

            }


        }
    }
}
