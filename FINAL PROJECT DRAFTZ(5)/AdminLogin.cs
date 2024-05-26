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
            this.Parent.Controls[0].Hide();
            this.Parent.Controls[1].Show();
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

        private void Adminpass_TextChanged(object sender, EventArgs e)
        {

        }

        

        bool hidden = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hidden)
            {
                Adminpass.UseSystemPasswordChar = true;
                hidden = false;
            }
            else
            {
                Adminpass.UseSystemPasswordChar = false;
                hidden = true;
            }

        }
    }
}
