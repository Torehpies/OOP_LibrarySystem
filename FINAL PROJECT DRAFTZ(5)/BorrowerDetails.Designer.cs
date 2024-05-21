namespace FINAL_PROJECT_DRAFTZ_5_
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
            customTextbox1 = new CustomTextbox();
            nameLabel = new Label();
            detailsLabel = new Label();
            idLabel = new Label();
            confirmButton = new CustomControls.RJControls.CustomButton();
            panel1 = new Panel();
            cancelButton = new CustomControls.RJControls.CustomButton();
            SuspendLayout();
            // 
            // idPrompt
            // 
            idPrompt.AutoSize = true;
            idPrompt.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idPrompt.Location = new Point(20, 87);
            idPrompt.Name = "idPrompt";
            idPrompt.Size = new Size(116, 24);
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
            // customTextbox1
            // 
            customTextbox1.BackColor = SystemColors.Window;
            customTextbox1.BorderColor = Color.FromArgb(34, 34, 59);
            customTextbox1.BorderFocusColor = Color.HotPink;
            customTextbox1.BorderRadius = 15;
            customTextbox1.BorderSize = 2;
            customTextbox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customTextbox1.ForeColor = Color.FromArgb(64, 64, 64);
            customTextbox1.Location = new Point(143, 84);
            customTextbox1.Margin = new Padding(4);
            customTextbox1.Multiline = false;
            customTextbox1.Name = "customTextbox1";
            customTextbox1.Padding = new Padding(10, 7, 10, 7);
            customTextbox1.PasswordChar = false;
            customTextbox1.PlaceholderColor = Color.DarkGray;
            customTextbox1.PlaceholderText = "";
            customTextbox1.Size = new Size(223, 31);
            customTextbox1.TabIndex = 2;
            customTextbox1.Texts = "";
            customTextbox1.UnderlinedStyle = false;
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
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.Location = new Point(130, 186);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(134, 28);
            idLabel.TabIndex = 5;
            idLabel.Text = "Borrower's ID";
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
            confirmButton.Location = new Point(102, 233);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(190, 40);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Confirm Checkout";
            confirmButton.TextColor = Color.White;
            confirmButton.UseVisualStyleBackColor = false;
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
            cancelButton.Location = new Point(102, 277);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(190, 40);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.FromArgb(34, 34, 59);
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // BorrowerDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(idLabel);
            Controls.Add(detailsLabel);
            Controls.Add(nameLabel);
            Controls.Add(customTextbox1);
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
        private CustomTextbox customTextbox1;
        private Label nameLabel;
        private Label detailsLabel;
        private Label idLabel;
        private CustomControls.RJControls.CustomButton confirmButton;
        private Panel panel1;
        private CustomControls.RJControls.CustomButton cancelButton;
    }
}
