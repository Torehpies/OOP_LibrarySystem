

namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adminuser = new TextBox();
            Adminpass = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Adminuser
            // 
            Adminuser.Location = new Point(274, 158);
            Adminuser.Name = "Adminuser";
            Adminuser.Size = new Size(232, 23);
            Adminuser.TabIndex = 0;
            Adminuser.Text = "Username";
            // 
            // Adminpass
            // 
            Adminpass.Location = new Point(274, 187);
            Adminpass.Name = "Adminpass";
            Adminpass.Size = new Size(232, 23);
            Adminpass.TabIndex = 1;
            Adminpass.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 125);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Admin Login";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(259, 225);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(257, 27);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Adminpass);
            Controls.Add(Adminuser);
            Name = "AdminLogin";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Adminuser.Text.Length == 0 ||  Adminpass.Text.Length == 0)
            {
                MessageBox.Show("Please fill in the entries");
                return;
            }

            String username = Adminuser.Text;
            String password = Adminpass.Text;

            Database loginChecker = new Database();

            if (loginChecker.checkLogin(username, password))
            {
                this.Hide();
                AddAccount success = new AddAccount();
                success.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Account match in our Database");
            }
        }



        #endregion

        private TextBox Adminuser;
        private TextBox Adminpass;
        private Label label1;
        private Button button1;
    }
}