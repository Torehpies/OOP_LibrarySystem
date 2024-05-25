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
            addbtn = new CustomButton();
            availLabel = new CustomButton();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)bookPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // bookYear
            // 
            bookYear.AutoSize = true;
            bookYear.Font = new Font("Quicksand Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bookYear.Location = new Point(68, 209);
            bookYear.Name = "bookYear";
            bookYear.Size = new Size(41, 23);
            bookYear.TabIndex = 19;
            bookYear.Text = "2018";
            //bookYear.Click += bookYear_Click;
            // 
            // bookPic
            // 
            bookPic.Image = Properties.Resources.how_to_write_a_lot;
            bookPic.Location = new Point(23, 12);
            bookPic.Name = "bookPic";
            bookPic.Size = new Size(126, 153);
            bookPic.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPic.TabIndex = 17;
            bookPic.TabStop = false;
            bookPic.Click += bookPic_Click;
            // 
            // bookTitle
            // 
            bookTitle.AutoEllipsis = true;
            bookTitle.Font = new Font("Quicksand SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bookTitle.ForeColor = Color.FromArgb(37, 23, 73);
            bookTitle.Location = new Point(0, 168);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(172, 53);
            bookTitle.TabIndex = 18;
            bookTitle.Text = "How to Write a LotHow to Write a LotHow to Write a Lot";
            bookTitle.TextAlign = ContentAlignment.TopCenter;
            bookTitle.UseCompatibleTextRendering = true;
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
            addbtn.Font = new Font("Quicksand", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = Color.FromArgb(255, 251, 235);
            addbtn.Location = new Point(104, 232);
            addbtn.Margin = new Padding(0);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(50, 40);
            addbtn.TabIndex = 21;
            addbtn.Text = "+";
            addbtn.TextColor = Color.FromArgb(255, 251, 235);
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // availLabel
            // 
            availLabel.BackColor = Color.FromArgb(38, 49, 89);
            availLabel.BackgroundColor = Color.FromArgb(38, 49, 89);
            availLabel.BorderColor = Color.PaleVioletRed;
            availLabel.BorderRadius = 18;
            availLabel.BorderSize = 0;
            availLabel.Cursor = Cursors.Hand;
            availLabel.FlatAppearance.BorderSize = 0;
            availLabel.FlatStyle = FlatStyle.Flat;
            availLabel.Font = new Font("Quicksand", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            availLabel.ForeColor = Color.FromArgb(255, 251, 235);
            availLabel.Location = new Point(18, 232);
            availLabel.Margin = new Padding(0);
            availLabel.Name = "availLabel";
            availLabel.Size = new Size(80, 40);
            availLabel.TabIndex = 20;
            availLabel.Text = "DETAILS";
            availLabel.TextColor = Color.FromArgb(255, 251, 235);
            availLabel.UseVisualStyleBackColor = false;
            availLabel.Click += detailsbtn_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(117, 243);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(32, 23);
            numericUpDown2.TabIndex = 22;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BookContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            Controls.Add(numericUpDown2);
            Controls.Add(addbtn);
            Controls.Add(availLabel);
            Controls.Add(bookYear);
            Controls.Add(bookPic);
            Controls.Add(bookTitle);
            Margin = new Padding(15, 15, 0, 0);
            Name = "BookContainer";
            Size = new Size(175, 279);
            ((System.ComponentModel.ISupportInitialize)bookPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookYear;
        private PictureBox bookPic;
        private Label bookTitle;
        private CustomButton addbtn;
        public NumericUpDown numericUpDown2;
        public CustomButton availLabel;
    }
}
