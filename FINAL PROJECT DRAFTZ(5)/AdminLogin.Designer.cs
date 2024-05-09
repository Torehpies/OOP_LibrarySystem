


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
            loginButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // Adminuser
            // 
            Adminuser.BorderStyle = BorderStyle.None;
            Adminuser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Adminuser.Location = new Point(50, 61);
            Adminuser.Name = "Adminuser";
            Adminuser.PlaceholderText = "Username";
            Adminuser.Size = new Size(182, 22);
            Adminuser.TabIndex = 0;
            // 
            // Adminpass
            // 
            Adminpass.BorderStyle = BorderStyle.None;
            Adminpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Adminpass.Location = new Point(50, 90);
            Adminpass.Name = "Adminpass";
            Adminpass.PlaceholderText = "Password";
            Adminpass.Size = new Size(182, 22);
            Adminpass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 28);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 2;
            label1.Text = "Admin Login";
            // 
            // button1
            // 
            loginButton.BackColor = Color.FromArgb(34, 34, 59);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(242, 233, 228);
            loginButton.Location = new Point(61, 117);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 30);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_click;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(62, 149);
            cancelButton.Margin = new Padding(0);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(158, 30);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(278, 199);
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
        private Button loginButton;
        private Button cancelButton;
    }
}