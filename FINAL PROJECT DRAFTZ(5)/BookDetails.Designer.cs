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
            authorLabel = new Label();
            isbn10Label = new Label();
            panel1 = new Panel();
            statusLabel = new Label();
            exitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            picture.Click += picture_Click;
            // 
            // publishedLabel
            // 
            publishedLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publishedLabel.ForeColor = Color.FromArgb(73, 85, 121);
            publishedLabel.Location = new Point(334, 281);
            publishedLabel.Name = "publishedLabel";
            publishedLabel.Size = new Size(303, 20);
            publishedLabel.TabIndex = 21;
            publishedLabel.Text = "2018 ";
            publishedLabel.Click += publishedLabel_Click;
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
            publisherLabel.Location = new Point(333, 244);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(324, 26);
            publisherLabel.TabIndex = 20;
            publisherLabel.Text = "American Psychological Association";
            publisherLabel.Click += publisherLabel_Click;
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
            titleLabel.Click += titleLabel_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.FromArgb(73, 85, 121);
            categoryLabel.Location = new Point(334, 207);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(303, 26);
            categoryLabel.TabIndex = 19;
            categoryLabel.Text = "Academic";
            categoryLabel.Click += categoryLabel_Click;
            // 
            // authorLabel
            // 
            authorLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorLabel.ForeColor = Color.FromArgb(73, 85, 121);
            authorLabel.Location = new Point(333, 172);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(303, 21);
            authorLabel.TabIndex = 18;
            authorLabel.Text = "Paul J. Silvia";
            authorLabel.Click += authorLabel_Click;
            // 
            // isbn10Label
            // 
            isbn10Label.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbn10Label.ForeColor = Color.FromArgb(73, 85, 121);
            isbn10Label.Location = new Point(334, 144);
            isbn10Label.Name = "isbn10Label";
            isbn10Label.Size = new Size(303, 21);
            isbn10Label.TabIndex = 16;
            isbn10Label.Text = "1433829789";
            isbn10Label.Click += isbn10Label_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(picture);
            panel1.Controls.Add(publishedLabel);
            panel1.Controls.Add(BorrowButton);
            panel1.Controls.Add(publisherLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(authorLabel);
            panel1.Controls.Add(isbn10Label);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(670, 390);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(244, 144);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 23;
            label1.Text = "ISBN: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 85, 121);
            label2.Location = new Point(244, 172);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 24;
            label2.Text = "AUTHOR:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(73, 85, 121);
            label3.Location = new Point(244, 207);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 25;
            label3.Text = "CATEGORY:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(73, 85, 121);
            label4.Location = new Point(244, 244);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 26;
            label4.Text = "PUBLISHER:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(73, 85, 121);
            label5.Location = new Point(243, 281);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 27;
            label5.Text = "PUBLISHED:";
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
            panel1.PerformLayout();
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
        private Label authorLabel;
        private Label isbn10Label;
        private Panel panel1;
        private Button exitButton;
        private Label statusLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
