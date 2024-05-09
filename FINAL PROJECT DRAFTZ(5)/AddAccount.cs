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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
            if (!LoginDatabase.isUsersEmpty())
            {
                accountType.Hide();
                label1.Text = "Create Admin Account";
            }
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
            bool isAdmin = accountType.Text.Equals("Admin") ? true : false;

            LoginDatabase.addAccount(Usertbox1.Text, passwordHash, isAdmin);

            MessageBox.Show("Account: " + Usertbox1.Text + " is created.");
            ClearTextBoxes(Parent.Controls);
            Parent.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Parent.Controls);
            this.Parent.Visible = false;
        }

        private void ClearTextBoxes(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                ClearTextBoxes(c.Controls);
        }
    }
}
