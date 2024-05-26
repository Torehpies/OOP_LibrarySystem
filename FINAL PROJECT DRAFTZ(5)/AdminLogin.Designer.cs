


using CustomControls.RJControls;

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
            loginButton = new CustomButton();
            cancelButton = new CustomButton();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Adminuser
            // 
            Adminuser.BorderStyle = BorderStyle.None;
            Adminuser.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adminuser.Location = new Point(6, 42);
            Adminuser.MinimumSize = new Size(299, 25);
            Adminuser.Name = "Adminuser";
            Adminuser.PlaceholderText = "Username";
            Adminuser.Size = new Size(299, 25);
            Adminuser.TabIndex = 0;
            // 
            // Adminpass
            // 
            Adminpass.BorderStyle = BorderStyle.None;
            Adminpass.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adminpass.Location = new Point(6, 71);
            Adminpass.MinimumSize = new Size(299, 25);
            Adminpass.Name = "Adminpass";
            Adminpass.PlaceholderText = "Password";
            Adminpass.Size = new Size(299, 25);
            Adminpass.TabIndex = 1;
            Adminpass.UseSystemPasswordChar = true;
            Adminpass.TextChanged += Adminpass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 2;
            label1.Text = "Admin Login";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(34, 34, 59);
            loginButton.BackgroundColor = Color.FromArgb(34, 34, 59);
            loginButton.BorderColor = Color.FromArgb(34, 34, 59);
            loginButton.BorderRadius = 15;
            loginButton.BorderSize = 2;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(242, 233, 228);
            loginButton.Location = new Point(82, 138);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 30);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.TextColor = Color.FromArgb(242, 233, 228);
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Transparent;
            cancelButton.BackgroundColor = Color.Transparent;
            cancelButton.BorderColor = Color.FromArgb(34, 34, 59);
            cancelButton.BorderRadius = 15;
            cancelButton.BorderSize = 2;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(34, 34, 59);
            cancelButton.Location = new Point(82, 169);
            cancelButton.Margin = new Padding(0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 30);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.FromArgb(34, 34, 59);
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(306, 283);
            Controls.Add(checkBox1);
            Controls.Add(cancelButton);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(Adminpass);
            Controls.Add(Adminuser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Adminuser;
        private TextBox Adminpass;
        private Label label1;
        private CustomButton loginButton;
        private CustomButton cancelButton;
        private CheckBox checkBox1;
    }
}