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
    public partial class LoginForm : Form
    {
        bool noAccount = false;
        private AddAccount addAccPane;
        private AdminLogin adminLogin;
        
        public LoginForm()
        {
            InitializeComponent();
            if (!LoginDatabase.isUsersEmpty())
            {
                disableLogin();
                noAccount = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void disableLogin()
        {
            createAccount.Location = new System.Drawing.Point(707, 320);
            loginButton.Visible = false;
            PasstBox.Visible = false;
            LogintBox.Visible = false;
        }

        private void enableLogin()
        {
            createAccount.Location = new System.Drawing.Point(707, 415);
            loginButton.Visible = true;
            PasstBox.Visible = true;
            LogintBox.Visible = true;
            containerPanel.Visible = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (LogintBox.Text.Length == 0 || PasstBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill in the entries");
                return;
            }

            String username = LogintBox.Text;
            String password = PasstBox.Text;

            if (LoginDatabase.checkLogin(username, password))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            //this.Hide();
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            containerPanel.Visible = true;
            if (noAccount)
            {
                addAccPane = new AddAccount() { TopLevel = false, TopMost = true, Dock = DockStyle.None };
                containerPanel.Controls.Add(addAccPane);
                addAccPane.Show();
            }
            else
            {
                adminLogin = new AdminLogin() { TopLevel = false, TopMost = true, Dock = DockStyle.None };
                containerPanel.Controls.Add(adminLogin);
                adminLogin.Show();
            }
            enableLogin();
        }
    }
}