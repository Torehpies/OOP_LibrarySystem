﻿namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BorrowerDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idPrompt = new Label();
            label1 = new Label();
            idTextbox = new CustomTextbox();
            nameLabel = new Label();
            detailsLabel = new Label();
            idLabel = new Label();
            confirmButton = new CustomControls.RJControls.CustomButton();
            panel1 = new Panel();
            cancelButton = new CustomControls.RJControls.CustomButton();
            warningText = new Label();
            checkIDBtn = new CustomControls.RJControls.CustomButton();
            SuspendLayout();
            // 
            // idPrompt
            // 
            idPrompt.AutoSize = true;
            idPrompt.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            idPrompt.Location = new Point(10, 87);
            idPrompt.Name = "idPrompt";
            idPrompt.Size = new Size(113, 23);
            idPrompt.TabIndex = 0;
            idPrompt.Text = "Borrower's ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(34, 34, 59);
            label1.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 233, 228);
            label1.Location = new Point(105, 17);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 1;
            label1.Text = "Borrower Details";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idTextbox
            // 
            idTextbox.BackColor = SystemColors.Window;
            idTextbox.BorderColor = Color.FromArgb(70, 70, 70);
            idTextbox.BorderFocusColor = Color.FromArgb(34, 34, 59);
            idTextbox.BorderRadius = 18;
            idTextbox.BorderSize = 2;
            idTextbox.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idTextbox.ForeColor = Color.FromArgb(64, 64, 64);
            idTextbox.Location = new Point(122, 79);
            idTextbox.Margin = new Padding(4);
            idTextbox.Multiline = false;
            idTextbox.Name = "idTextbox";
            idTextbox.Padding = new Padding(10, 7, 10, 7);
            idTextbox.PasswordChar = false;
            idTextbox.PlaceholderColor = Color.DarkGray;
            idTextbox.PlaceholderText = "";
            idTextbox.Size = new Size(159, 38);
            idTextbox.TabIndex = 2;
            idTextbox.Texts = "";
            idTextbox.UnderlinedStyle = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(164, 128);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(66, 28);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Visible = false;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            detailsLabel.Location = new Point(160, 157);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(74, 28);
            detailsLabel.TabIndex = 4;
            detailsLabel.Text = "Details";
            detailsLabel.Visible = false;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.Location = new Point(122, 186);
            idLabel.MinimumSize = new Size(150, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(150, 28);
            idLabel.TabIndex = 5;
            idLabel.Text = "Borrower's ID";
            idLabel.TextAlign = ContentAlignment.MiddleCenter;
            idLabel.Visible = false;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Bottom;
            confirmButton.BackColor = Color.FromArgb(34, 34, 59);
            confirmButton.BackgroundColor = Color.FromArgb(34, 34, 59);
            confirmButton.BorderColor = Color.PaleVioletRed;
            confirmButton.BorderRadius = 20;
            confirmButton.BorderSize = 0;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(102, 157);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(190, 40);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Confirm Checkout";
            confirmButton.TextColor = Color.White;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Visible = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 34, 59);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 62);
            panel1.TabIndex = 7;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom;
            cancelButton.BackColor = Color.FromArgb(242, 233, 228);
            cancelButton.BackgroundColor = Color.FromArgb(242, 233, 228);
            cancelButton.BorderColor = Color.FromArgb(34, 34, 59);
            cancelButton.BorderRadius = 20;
            cancelButton.BorderSize = 3;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.FromArgb(34, 34, 59);
            cancelButton.Location = new Point(102, 157);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(190, 40);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.FromArgb(34, 34, 59);
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // warningText
            // 
            warningText.AutoSize = true;
            warningText.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            warningText.ForeColor = Color.DarkRed;
            warningText.Location = new Point(96, 123);
            warningText.MinimumSize = new Size(200, 24);
            warningText.Name = "warningText";
            warningText.Size = new Size(200, 24);
            warningText.TabIndex = 9;
            warningText.Text = "Member doesn't exists";
            warningText.TextAlign = ContentAlignment.MiddleCenter;
            warningText.Visible = false;
            // 
            // checkIDBtn
            // 
            checkIDBtn.Anchor = AnchorStyles.Bottom;
            checkIDBtn.BackColor = Color.FromArgb(34, 34, 59);
            checkIDBtn.BackgroundColor = Color.FromArgb(34, 34, 59);
            checkIDBtn.BorderColor = Color.PaleVioletRed;
            checkIDBtn.BorderRadius = 18;
            checkIDBtn.BorderSize = 0;
            checkIDBtn.FlatAppearance.BorderSize = 0;
            checkIDBtn.FlatStyle = FlatStyle.Flat;
            checkIDBtn.Font = new Font("Quicksand", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkIDBtn.ForeColor = Color.White;
            checkIDBtn.Location = new Point(288, 80);
            checkIDBtn.Name = "checkIDBtn";
            checkIDBtn.Size = new Size(98, 37);
            checkIDBtn.TabIndex = 10;
            checkIDBtn.Text = "Check ID";
            checkIDBtn.TextColor = Color.White;
            checkIDBtn.UseVisualStyleBackColor = false;
            checkIDBtn.Click += checkIDBtn_Click;
            // 
            // BorrowerDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            Controls.Add(checkIDBtn);
            Controls.Add(warningText);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(idLabel);
            Controls.Add(detailsLabel);
            Controls.Add(nameLabel);
            Controls.Add(idTextbox);
            Controls.Add(label1);
            Controls.Add(idPrompt);
            Controls.Add(panel1);
            Name = "BorrowerDetails";
            Size = new Size(395, 328);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idPrompt;
        private Label label1;
        private CustomTextbox idTextbox;
        private Label nameLabel;
        private Label detailsLabel;
        private Label idLabel;
        private CustomControls.RJControls.CustomButton confirmButton;
        private Panel panel1;
        private CustomControls.RJControls.CustomButton cancelButton;
        private Label warningText;
        private CustomControls.RJControls.CustomButton checkIDBtn;
    }
}