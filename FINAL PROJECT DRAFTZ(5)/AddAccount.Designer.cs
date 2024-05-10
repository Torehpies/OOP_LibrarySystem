namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class AddAccount
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
            Usertbox1 = new TextBox();
            passwordtbox = new TextBox();
            passwordtbox1 = new TextBox();
            button1 = new Button();
            accountType = new ComboBox();
            label1 = new Label();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // Usertbox1
            // 
            Usertbox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Usertbox1.BorderStyle = BorderStyle.None;
            Usertbox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usertbox1.Location = new Point(6, 44);
            Usertbox1.Margin = new Padding(0);
            Usertbox1.MinimumSize = new Size(258, 32);
            Usertbox1.Name = "Usertbox1";
            Usertbox1.PlaceholderText = "Username";
            Usertbox1.Size = new Size(299, 32);
            Usertbox1.TabIndex = 0;
            // 
            // passwordtbox
            // 
            passwordtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtbox.BorderStyle = BorderStyle.None;
            passwordtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtbox.Location = new Point(6, 80);
            passwordtbox.Margin = new Padding(0);
            passwordtbox.MinimumSize = new Size(258, 32);
            passwordtbox.Name = "passwordtbox";
            passwordtbox.PlaceholderText = "Password";
            passwordtbox.Size = new Size(299, 32);
            passwordtbox.TabIndex = 1;
            passwordtbox.UseSystemPasswordChar = true;
            // 
            // passwordtbox1
            // 
            passwordtbox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtbox1.BorderStyle = BorderStyle.None;
            passwordtbox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtbox1.Location = new Point(6, 116);
            passwordtbox1.Margin = new Padding(0);
            passwordtbox1.MinimumSize = new Size(258, 32);
            passwordtbox1.Name = "passwordtbox1";
            passwordtbox1.PlaceholderText = "Confirm Password";
            passwordtbox1.Size = new Size(299, 32);
            passwordtbox1.TabIndex = 2;
            passwordtbox1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 34, 59);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(242, 233, 228);
            button1.Location = new Point(75, 182);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(160, 30);
            button1.TabIndex = 4;
            button1.Text = "Add Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // accountType
            // 
            accountType.DisplayMember = "Admin";
            accountType.FormattingEnabled = true;
            accountType.Items.AddRange(new object[] { "Admin", "Standard" });
            accountType.Location = new Point(6, 154);
            accountType.Name = "accountType";
            accountType.Size = new Size(121, 23);
            accountType.TabIndex = 3;
            accountType.ValueMember = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 10);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 8;
            label1.Text = "Create New Account";
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(34, 34, 59);
            cancelButton.Location = new Point(76, 216);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(158, 30);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(306, 283);
            Controls.Add(cancelButton);
            Controls.Add(label1);
            Controls.Add(accountType);
            Controls.Add(button1);
            Controls.Add(passwordtbox1);
            Controls.Add(passwordtbox);
            Controls.Add(Usertbox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAccount";
            Text = "AddAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Usertbox1;
        private TextBox passwordtbox;
        private TextBox passwordtbox1;
        private Button button1;
        private ComboBox accountType;
        private Label label1;
        private Button cancelButton;
    }
}