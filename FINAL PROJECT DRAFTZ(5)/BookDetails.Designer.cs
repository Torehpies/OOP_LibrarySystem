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
            components = new System.ComponentModel.Container();
            picture = new PictureBox();
            publishedLabel = new Label();
            BorrowButton = new Button();
            publisherLabel = new Label();
            titleLabel = new Label();
            categoryLabel = new Label();
            authorLabel = new Label();
            isbn10Label = new Label();
            panel1 = new Panel();
            button1 = new Button();
            totalcopies = new Label();
            label7 = new Label();
            label6 = new Label();
            availablecopies = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            statusLabel = new Label();
            borrownumber = new NumericUpDown();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrownumber).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Image = Properties.Resources.how_to_write_a_lot;
            picture.Location = new Point(3, 24);
            picture.Name = "picture";
            picture.Size = new Size(225, 285);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            picture.Click += picture_Click;
            picture.MouseHover += picture_MouseHover;
            // 
            // publishedLabel
            // 
            publishedLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publishedLabel.ForeColor = Color.FromArgb(73, 85, 121);
            publishedLabel.Location = new Point(398, 241);
            publishedLabel.Name = "publishedLabel";
            publishedLabel.Size = new Size(228, 20);
            publishedLabel.TabIndex = 21;
            publishedLabel.Click += publishedLabel_Click;
            // 
            // BorrowButton
            // 
            BorrowButton.BackColor = Color.FromArgb(38, 49, 89);
            BorrowButton.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowButton.ForeColor = Color.FromArgb(255, 251, 235);
            BorrowButton.Location = new Point(3, 329);
            BorrowButton.Name = "BorrowButton";
            BorrowButton.Size = new Size(225, 56);
            BorrowButton.TabIndex = 7;
            BorrowButton.Text = "ADD TO CHECKOUT";
            BorrowButton.UseVisualStyleBackColor = false;
            BorrowButton.Click += BorrowButton_Click;
            // 
            // publisherLabel
            // 
            publisherLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publisherLabel.ForeColor = Color.FromArgb(73, 85, 121);
            publisherLabel.Location = new Point(398, 214);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new Size(229, 26);
            publisherLabel.TabIndex = 20;
            publisherLabel.Click += publisherLabel_Click;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(38, 49, 89);
            titleLabel.Location = new Point(245, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(413, 83);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "How to Write a Lot: A Practical Guide to Productive Academic Writing";
            titleLabel.Click += titleLabel_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.FromArgb(73, 85, 121);
            categoryLabel.Location = new Point(398, 184);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(228, 21);
            categoryLabel.TabIndex = 19;
            categoryLabel.Click += categoryLabel_Click;
            // 
            // authorLabel
            // 
            authorLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorLabel.ForeColor = Color.FromArgb(73, 85, 121);
            authorLabel.Location = new Point(398, 155);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(229, 21);
            authorLabel.TabIndex = 18;
            authorLabel.Click += authorLabel_Click;
            // 
            // isbn10Label
            // 
            isbn10Label.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbn10Label.ForeColor = Color.FromArgb(73, 85, 121);
            isbn10Label.Location = new Point(398, 127);
            isbn10Label.Name = "isbn10Label";
            isbn10Label.Size = new Size(228, 21);
            isbn10Label.TabIndex = 16;
            isbn10Label.Click += isbn10Label_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(totalcopies);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(availablecopies);
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
            panel1.Size = new Size(670, 398);
            panel1.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 49, 89);
            button1.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(255, 251, 235);
            button1.Location = new Point(52, 280);
            button1.Name = "button1";
            button1.Size = new Size(137, 38);
            button1.TabIndex = 32;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += picture_Click;
            // 
            // totalcopies
            // 
            totalcopies.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalcopies.ForeColor = Color.FromArgb(73, 85, 121);
            totalcopies.Location = new Point(398, 298);
            totalcopies.Name = "totalcopies";
            totalcopies.Size = new Size(229, 20);
            totalcopies.TabIndex = 31;
            totalcopies.Click += totalcopies_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(73, 85, 121);
            label7.Location = new Point(244, 297);
            label7.Name = "label7";
            label7.Size = new Size(122, 24);
            label7.TabIndex = 30;
            label7.Text = "TOTAL COPIES:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(73, 85, 121);
            label6.Location = new Point(244, 272);
            label6.Name = "label6";
            label6.Size = new Size(152, 24);
            label6.TabIndex = 29;
            label6.Text = "AVAILABLE COPIES:";
            // 
            // availablecopies
            // 
            availablecopies.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            availablecopies.ForeColor = Color.FromArgb(73, 85, 121);
            availablecopies.Location = new Point(398, 273);
            availablecopies.Name = "availablecopies";
            availablecopies.Size = new Size(229, 20);
            availablecopies.TabIndex = 28;
            availablecopies.Click += availablecopies_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(73, 85, 121);
            label5.Location = new Point(243, 241);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 27;
            label5.Text = "PUBLISHED:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(73, 85, 121);
            label4.Location = new Point(244, 214);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 26;
            label4.Text = "PUBLISHER:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(73, 85, 121);
            label3.Location = new Point(244, 184);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 25;
            label3.Text = "CATEGORY:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 85, 121);
            label2.Location = new Point(244, 155);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 24;
            label2.Text = "AUTHOR:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(245, 127);
            label1.Name = "label1";
            label1.Size = new Size(53, 24);
            label1.TabIndex = 23;
            label1.Text = "ISBN: ";
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.FromArgb(73, 85, 121);
            statusLabel.Location = new Point(244, 100);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(173, 29);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "STATUS: ";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // borrownumber
            // 
            borrownumber.BorderStyle = BorderStyle.None;
            borrownumber.Location = new Point(234, 341);
            borrownumber.Name = "borrownumber";
            borrownumber.Size = new Size(47, 19);
            borrownumber.TabIndex = 24;
            borrownumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            borrownumber.Visible = false;
            borrownumber.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Navy;
            exitButton.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(73, 85, 121);
            label8.Location = new Point(245, 14);
            label8.Name = "label8";
            label8.Size = new Size(39, 21);
            label8.TabIndex = 33;
            label8.Text = "Title:";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(700, 430);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(panel1);
            Name = "BookDetails";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += populateDetails;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borrownumber).EndInit();
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
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        
        private NumericUpDown borrownumber;
        private Label availablecopies;
        private Label label6;
        private Label totalcopies;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}
