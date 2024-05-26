using CustomControls.RJControls;

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
            button1 = new CustomButton();
            accountType = new ComboBox();
            label1 = new Label();
            cancelButton = new CustomButton();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Usertbox1
            // 
            Usertbox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Usertbox1.BorderStyle = BorderStyle.None;
            Usertbox1.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Usertbox1.Location = new Point(3, 44);
            Usertbox1.Margin = new Padding(0);
            Usertbox1.MinimumSize = new Size(258, 25);
            Usertbox1.Name = "Usertbox1";
            Usertbox1.PlaceholderText = "Username";
            Usertbox1.Size = new Size(299, 25);
            Usertbox1.TabIndex = 0;
            // 
            // passwordtbox
            // 
            passwordtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtbox.BorderStyle = BorderStyle.None;
            passwordtbox.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtbox.Location = new Point(3, 76);
            passwordtbox.Margin = new Padding(0);
            passwordtbox.MinimumSize = new Size(258, 25);
            passwordtbox.Name = "passwordtbox";
            passwordtbox.PlaceholderText = "Password";
            passwordtbox.Size = new Size(299, 25);
            passwordtbox.TabIndex = 1;
            passwordtbox.UseSystemPasswordChar = true;
            // 
            // passwordtbox1
            // 
            passwordtbox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtbox1.BorderStyle = BorderStyle.None;
            passwordtbox1.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtbox1.Location = new Point(3, 109);
            passwordtbox1.Margin = new Padding(0);
            passwordtbox1.MinimumSize = new Size(258, 25);
            passwordtbox1.Name = "passwordtbox1";
            passwordtbox1.PlaceholderText = "Confirm Password";
            passwordtbox1.Size = new Size(299, 25);
            passwordtbox1.TabIndex = 2;
            passwordtbox1.UseSystemPasswordChar = true;
            passwordtbox1.TextChanged += passwordtbox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 34, 59);
            button1.BackgroundColor = Color.FromArgb(34, 34, 59);
            button1.BorderColor = Color.FromArgb(34, 34, 59);
            button1.BorderRadius = 15;
            button1.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(242, 233, 228);
            button1.Location = new Point(77, 197);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 4;
            button1.Text = "Add Account";
            button1.TextColor = Color.FromArgb(242, 233, 228);
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // accountType
            // 
            accountType.DisplayMember = "Admin";
            accountType.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            accountType.FormattingEnabled = true;
            accountType.Items.AddRange(new object[] { "Admin", "Standard" });
            accountType.Location = new Point(3, 158);
            accountType.MinimumSize = new Size(121, 0);
            accountType.Name = "accountType";
            accountType.Size = new Size(121, 31);
            accountType.TabIndex = 3;
            accountType.ValueMember = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 10);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 8;
            label1.Text = "Create New Account";
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
            cancelButton.Location = new Point(77, 228);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 30);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.FromArgb(34, 34, 59);
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 138);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(306, 283);
            Controls.Add(checkBox1);
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
        private CustomButton button1;
        private ComboBox accountType;
        private Label label1;
        private CustomButton cancelButton;
        private CheckBox checkBox1;
    }
}