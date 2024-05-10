namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookDetails
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
            picture = new PictureBox();
            publishedLabel = new Label();
            BorrowButton = new Button();
            publisherLabel = new Label();
            titleLabel = new Label();
            categoryLabel = new Label();
            isbn13Label = new Label();
            authorLabel = new Label();
            isbn10Label = new Label();
            panel1 = new Panel();
            statusLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Image = Properties.Resources.how_to_write_a_lot;
            picture.Location = new Point(3, 17);
            picture.Name = "picture";
            picture.Size = new Size(225, 285);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // publishedLabel
            // 
            publishedLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publishedLabel.ForeColor = Color.FromArgb(73, 85, 121);
            publishedLabel.Location = new Point(244, 268);
            publishedLabel.Name = "publishedLabel";
            publishedLabel.Size = new Size(303, 26);
            publishedLabel.TabIndex = 21;
            publishedLabel.Text = "PUBLISHED: 2018 ";
            // 
            // BorrowButton
            // 
            BorrowButton.BackColor = Color.FromArgb(38, 49, 89);
            BorrowButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowButton.ForeColor = Color.FromArgb(255, 251, 235);
            BorrowButton.Location = new Point(3, 318);
            BorrowButton.Name = "BorrowButton";
            BorrowButton.Size = new Size(225, 56);
            BorrowButton.TabIndex = 7;
            BorrowButton.Text = "BORROW";
            BorrowButton.UseVisualStyleBackColor = false;
            BorrowButton.Click += BorrowButton_Click;
            // 
            // publisherLabel
            // 
            publisherLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publisherLabel.ForeColor = Color.FromArgb(73, 85, 121);
            publisherLabel.Location = new Point(244, 242);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(324, 26);
            publisherLabel.TabIndex = 20;
            publisherLabel.Text = "PUBLISHER: American Psychological Association";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(38, 49, 89);
            titleLabel.Location = new Point(244, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(345, 69);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "How to Write a Lot: A Practical Guide to Productive Academic Writing";
            // 
            // categoryLabel
            // 
            categoryLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.FromArgb(73, 85, 121);
            categoryLabel.Location = new Point(244, 216);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(303, 26);
            categoryLabel.TabIndex = 19;
            categoryLabel.Text = "CATEGORY: Academic";
            // 
            // isbn13Label
            // 
            isbn13Label.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbn13Label.ForeColor = Color.FromArgb(73, 85, 121);
            isbn13Label.Location = new Point(244, 138);
            isbn13Label.Name = "isbn13Label";
            isbn13Label.Size = new Size(303, 17);
            isbn13Label.TabIndex = 15;
            isbn13Label.Text = "ISBN-13:  9781433829789";
            // 
            // authorLabel
            // 
            authorLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorLabel.ForeColor = Color.FromArgb(73, 85, 121);
            authorLabel.Location = new Point(244, 190);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(303, 26);
            authorLabel.TabIndex = 18;
            authorLabel.Text = "AUTHOR: Paul J. Silvia";
            // 
            // isbn10Label
            // 
            isbn10Label.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbn10Label.ForeColor = Color.FromArgb(73, 85, 121);
            isbn10Label.Location = new Point(244, 164);
            isbn10Label.Name = "isbn10Label";
            isbn10Label.Size = new Size(303, 17);
            isbn10Label.TabIndex = 16;
            isbn10Label.Text = "ISBN-10:  1433829789";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(picture);
            panel1.Controls.Add(publishedLabel);
            panel1.Controls.Add(BorrowButton);
            panel1.Controls.Add(publisherLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(isbn13Label);
            panel1.Controls.Add(authorLabel);
            panel1.Controls.Add(isbn10Label);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(660, 390);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.Ivory;
            statusLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Underline, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.FromArgb(73, 85, 121);
            statusLabel.Location = new Point(244, 100);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(173, 29);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "STATUS: ";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Navy;
            exitButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ButtonHighlight;
            exitButton.Location = new Point(5, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 29);
            exitButton.TabIndex = 24;
            exitButton.Text = "<- BACK";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(700, 430);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Name = "BookDetails";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private Label publishedLabel;
        private Button BorrowButton;
        private Label publisherLabel;
        private Label titleLabel;
        private Label categoryLabel;
        private Label isbn13Label;
        private Label authorLabel;
        private Label isbn10Label;
        private Panel panel1;
        private Button exitButton;
        private Label statusLabel;
    }
}
