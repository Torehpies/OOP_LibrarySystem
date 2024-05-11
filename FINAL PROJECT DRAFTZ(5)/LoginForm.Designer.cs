using CustomControls.RJControls;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LogintBox = new TextBox();
            PasstBox = new TextBox();
            label1 = new Label();
            loginButton = new CustomButton();
            createAccount = new CustomButton();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            containerPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LogintBox
            // 
            LogintBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogintBox.BorderStyle = BorderStyle.None;
            LogintBox.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogintBox.Location = new Point(618, 299);
            LogintBox.Margin = new Padding(2);
            LogintBox.MinimumSize = new Size(299, 25);
            LogintBox.Name = "LogintBox";
            LogintBox.PlaceholderText = "Username";
            LogintBox.Size = new Size(299, 25);
            LogintBox.TabIndex = 0;
            // 
            // PasstBox
            // 
            PasstBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasstBox.BorderStyle = BorderStyle.None;
            PasstBox.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasstBox.Location = new Point(618, 330);
            PasstBox.Margin = new Padding(2);
            PasstBox.MinimumSize = new Size(299, 25);
            PasstBox.Name = "PasstBox";
            PasstBox.PasswordChar = '*';
            PasstBox.PlaceholderText = "Password";
            PasstBox.Size = new Size(299, 25);
            PasstBox.TabIndex = 1;
            PasstBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(34, 34, 59);
            loginButton.BackgroundColor = Color.FromArgb(34, 34, 59);
            loginButton.BorderColor = Color.PaleVioletRed;
            loginButton.BorderRadius = 15;
            loginButton.BorderSize = 0;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.Snow;
            loginButton.Location = new Point(692, 366);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 30);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.TextColor = Color.Snow;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // createAccount
            // 
            createAccount.BackColor = Color.Transparent;
            createAccount.BackgroundColor = Color.Transparent;
            createAccount.BorderColor = Color.FromArgb(34, 34, 59);
            createAccount.BorderRadius = 15;
            createAccount.BorderSize = 2;
            createAccount.Cursor = Cursors.Hand;
            createAccount.FlatAppearance.BorderSize = 0;
            createAccount.FlatStyle = FlatStyle.Flat;
            createAccount.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            createAccount.ForeColor = SystemColors.ActiveCaptionText;
            createAccount.Location = new Point(692, 398);
            createAccount.Margin = new Padding(2);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(150, 30);
            createAccount.TabIndex = 3;
            createAccount.Text = "Create Account";
            createAccount.TextColor = SystemColors.ActiveCaptionText;
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += createAcc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(242, 233, 228);
            label2.Location = new Point(713, 258);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 8;
            label2.Text = "VOOX";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-39, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 590);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.voox_logo;
            pictureBox2.Location = new Point(692, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // containerPanel
            // 
            containerPanel.Location = new Point(618, 266);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(306, 283);
            containerPanel.TabIndex = 10;
            containerPanel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(984, 561);
            Controls.Add(containerPanel);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(createAccount);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(PasstBox);
            Controls.Add(LogintBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VOOX | LOGIN";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogintBox;
        private TextBox PasstBox;
        private Label label1;
        private CustomButton loginButton;
        private CustomButton createAccount;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel containerPanel;
    }
}