using CustomControls.RJControls;

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
            detailsbtn = new CustomButton();
            addbtn = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)bookPic).BeginInit();
            SuspendLayout();
            // 
            // bookYear
            // 
            bookYear.AutoSize = true;
            bookYear.Font = new Font("Quicksand Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bookYear.Location = new Point(79, 211);
            bookYear.Name = "bookYear";
            bookYear.Size = new Size(41, 23);
            bookYear.TabIndex = 19;
            bookYear.Text = "2018";
            // 
            // bookPic
            // 
            bookPic.Image = Properties.Resources.how_to_write_a_lot;
            bookPic.Location = new Point(34, 12);
            bookPic.Name = "bookPic";
            bookPic.Size = new Size(126, 153);
            bookPic.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPic.TabIndex = 17;
            bookPic.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.Font = new Font("Quicksand SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bookTitle.ForeColor = Color.FromArgb(37, 23, 73);
            bookTitle.Location = new Point(1, 168);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(192, 53);
            bookTitle.TabIndex = 18;
            bookTitle.Text = "How to Write a LotHow to Write a LotHow to Write a Lot";
            bookTitle.TextAlign = ContentAlignment.TopCenter;
            bookTitle.UseCompatibleTextRendering = true;
            bookTitle.Click += bookTitle_Click;
            // 
            // detailsbtn
            // 
            detailsbtn.BackColor = Color.FromArgb(38, 49, 89);
            detailsbtn.BackgroundColor = Color.FromArgb(38, 49, 89);
            detailsbtn.BorderColor = Color.PaleVioletRed;
            detailsbtn.BorderRadius = 18;
            detailsbtn.BorderSize = 0;
            detailsbtn.Cursor = Cursors.Hand;
            detailsbtn.FlatAppearance.BorderSize = 0;
            detailsbtn.FlatStyle = FlatStyle.Flat;
            detailsbtn.Font = new Font("Quicksand", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            detailsbtn.ForeColor = Color.FromArgb(255, 251, 235);
            detailsbtn.Location = new Point(28, 232);
            detailsbtn.Margin = new Padding(0);
            detailsbtn.Name = "detailsbtn";
            detailsbtn.Size = new Size(80, 40);
            detailsbtn.TabIndex = 20;
            detailsbtn.Text = "DETAILS";
            detailsbtn.TextColor = Color.FromArgb(255, 251, 235);
            detailsbtn.UseVisualStyleBackColor = false;
            detailsbtn.Click += borrowBtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(38, 49, 89);
            addbtn.BackgroundColor = Color.FromArgb(38, 49, 89);
            addbtn.BorderColor = Color.PaleVioletRed;
            addbtn.BorderRadius = 18;
            addbtn.BorderSize = 0;
            addbtn.Cursor = Cursors.Hand;
            addbtn.FlatAppearance.BorderSize = 0;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = Color.FromArgb(255, 251, 235);
            addbtn.Location = new Point(114, 232);
            addbtn.Margin = new Padding(0);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(50, 40);
            addbtn.TabIndex = 21;
            addbtn.Text = "+";
            addbtn.TextColor = Color.FromArgb(255, 251, 235);
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += button1_Click;
            // 
            // BookContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            Controls.Add(addbtn);
            Controls.Add(detailsbtn);
            Controls.Add(bookYear);
            Controls.Add(bookPic);
            Controls.Add(bookTitle);
            Margin = new Padding(0);
            Name = "BookContainer";
            Size = new Size(192, 279);
            ((System.ComponentModel.ISupportInitialize)bookPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookYear;
        private PictureBox bookPic;
        private Label bookTitle;
        private CustomButton detailsbtn;
        private CustomButton addbtn;
    }
}
