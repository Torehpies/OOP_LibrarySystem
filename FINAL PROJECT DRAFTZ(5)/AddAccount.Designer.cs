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
            SuspendLayout();
            // 
            // Usertbox1
            // 
            Usertbox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Usertbox1.BorderStyle = BorderStyle.None;
            Usertbox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usertbox1.Location = new Point(11, 11);
            Usertbox1.Margin = new Padding(2);
            Usertbox1.MinimumSize = new Size(258, 32);
            Usertbox1.Name = "Usertbox1";
            Usertbox1.PlaceholderText = "Username";
            Usertbox1.Size = new Size(258, 32);
            Usertbox1.TabIndex = 2;
            // 
            // passwordtbox
            // 
            passwordtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtbox.BorderStyle = BorderStyle.None;
            passwordtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtbox.Location = new Point(11, 57);
            passwordtbox.Margin = new Padding(2);
            passwordtbox.MinimumSize = new Size(258, 32);
            passwordtbox.Name = "passwordtbox";
            passwordtbox.PlaceholderText = "Password";
            passwordtbox.Size = new Size(258, 32);
            passwordtbox.TabIndex = 3;
            // 
            // passwordtbox1
            // 
            passwordtbox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtbox1.BorderStyle = BorderStyle.None;
            passwordtbox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtbox1.Location = new Point(11, 102);
            passwordtbox1.Margin = new Padding(2);
            passwordtbox1.MinimumSize = new Size(258, 32);
            passwordtbox1.Name = "passwordtbox1";
            passwordtbox1.PlaceholderText = "Confirm Password";
            passwordtbox1.Size = new Size(258, 32);
            passwordtbox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(11, 151);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(257, 27);
            button1.TabIndex = 6;
            button1.Text = "Add Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(278, 184);
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
    }
}