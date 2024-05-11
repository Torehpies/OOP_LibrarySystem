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
        public bool noAccount = false;

        public LoginForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(RoundEdge.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            containerPanel.Controls.Add(new AdminLogin() { TopLevel = false, TopMost = true, Dock = DockStyle.None });
            containerPanel.Controls.Add(new AddAccount() { TopLevel = false, TopMost = true, Dock = DockStyle.None });
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

            if (LoginDatabase.checkLogin(username, password, false))
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
        }

        private void createAcc_Click(object sender, EventArgs e)
        {
            containerPanel.Visible = true;
            if (noAccount)
            {
                containerPanel.Controls[1].Show();
                containerPanel.Controls[0].Hide();
                enableLogin();
                noAccount = false;
                return;
            }
            containerPanel.Controls[0].Show();
            containerPanel.Controls[1].Hide();
        }

    }
}