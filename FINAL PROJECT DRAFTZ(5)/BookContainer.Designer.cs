namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookContainer
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
            bookYear = new Label();
            bookPic = new PictureBox();
            bookTitle = new Label();
            borrowBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)bookPic).BeginInit();
            SuspendLayout();
            // 
            // bookYear
            // 
            bookYear.AutoSize = true;
            bookYear.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookYear.Location = new Point(13, 171);
            bookYear.Name = "bookYear";
            bookYear.Size = new Size(45, 20);
            bookYear.TabIndex = 19;
            bookYear.Text = "2018";
            // 
            // bookPic
            // 
            bookPic.Image = Properties.Resources.how_to_write_a_lot;
            bookPic.Location = new Point(30, 3);
            bookPic.Name = "bookPic";
            bookPic.Size = new Size(98, 134);
            bookPic.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPic.TabIndex = 17;
            bookPic.TabStop = false;
            bookPic.Click += Book1_Click;
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.Font = new Font("Franklin Gothic Demi Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitle.ForeColor = Color.FromArgb(37, 23, 73);
            bookTitle.Location = new Point(13, 140);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(133, 31);
            bookTitle.TabIndex = 18;
            bookTitle.Text = "How to Write a Lot";
            // 
            // borrowBtn
            // 
            borrowBtn.BackColor = Color.FromArgb(38, 49, 89);
            borrowBtn.Cursor = Cursors.Hand;
            borrowBtn.FlatStyle = FlatStyle.Flat;
            borrowBtn.Font = new Font("Franklin Gothic Book", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            borrowBtn.ForeColor = Color.FromArgb(255, 251, 235);
            borrowBtn.Location = new Point(35, 194);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(86, 35);
            borrowBtn.TabIndex = 20;
            borrowBtn.Text = "BORROW";
            borrowBtn.UseVisualStyleBackColor = false;
            borrowBtn.Click += borrowBtn_Click;
            // 
            // BookContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            Controls.Add(borrowBtn);
            Controls.Add(bookYear);
            Controls.Add(bookPic);
            Controls.Add(bookTitle);
            Name = "BookContainer";
            Size = new Size(159, 245);
            ((System.ComponentModel.ISupportInitialize)bookPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookYear;
        private PictureBox bookPic;
        private Label bookTitle;
        private Button borrowBtn;
    }
}
