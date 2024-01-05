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
            BookDateLabel1 = new Label();
            Book1 = new PictureBox();
            BookLabel1 = new Label();
            borrowBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Book1).BeginInit();
            SuspendLayout();
            // 
            // BookDateLabel1
            // 
            BookDateLabel1.AutoSize = true;
            BookDateLabel1.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BookDateLabel1.Location = new Point(13, 171);
            BookDateLabel1.Name = "BookDateLabel1";
            BookDateLabel1.Size = new Size(45, 20);
            BookDateLabel1.TabIndex = 19;
            BookDateLabel1.Text = "2018";
            // 
            // Book1
            // 
            Book1.Image = Properties.Resources.how_to_write_a_lot;
            Book1.Location = new Point(30, 3);
            Book1.Name = "Book1";
            Book1.Size = new Size(98, 134);
            Book1.SizeMode = PictureBoxSizeMode.StretchImage;
            Book1.TabIndex = 17;
            Book1.TabStop = false;
            Book1.Click += Book1_Click;
            // 
            // BookLabel1
            // 
            BookLabel1.AutoEllipsis = true;
            BookLabel1.Font = new Font("Franklin Gothic Demi Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BookLabel1.ForeColor = Color.FromArgb(37, 23, 73);
            BookLabel1.Location = new Point(13, 140);
            BookLabel1.Name = "BookLabel1";
            BookLabel1.Size = new Size(133, 31);
            BookLabel1.TabIndex = 18;
            BookLabel1.Text = "How to Write a Lot";
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
            // 
            // BookContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            Controls.Add(borrowBtn);
            Controls.Add(BookDateLabel1);
            Controls.Add(Book1);
            Controls.Add(BookLabel1);
            Name = "BookContainer";
            Size = new Size(159, 245);
            ((System.ComponentModel.ISupportInitialize)Book1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookDateLabel1;
        private PictureBox Book1;
        private Label BookLabel1;
        private Button borrowBtn;
    }
}
