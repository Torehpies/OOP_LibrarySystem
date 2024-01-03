namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class Book1Form
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
            pictureBox1 = new PictureBox();
            BorrowButton = new Button();
            label2 = new Label();
            BookLabel1 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.how_to_write_a_lot;
            pictureBox1.Location = new Point(3, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Demi Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(38, 49, 89);
            label2.Location = new Point(244, 17);
            label2.Name = "label2";
            label2.Size = new Size(345, 69);
            label2.TabIndex = 8;
            label2.Text = "How to Write a Lot: A Practical Guide to Productive Academic Writing";
            // 
            // BookLabel1
            // 
            BookLabel1.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookLabel1.ForeColor = Color.FromArgb(73, 85, 121);
            BookLabel1.Location = new Point(244, 117);
            BookLabel1.Name = "BookLabel1";
            BookLabel1.Size = new Size(303, 17);
            BookLabel1.TabIndex = 15;
            BookLabel1.Text = "ISBN-13:  9781433829789";
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(244, 143);
            label1.Name = "label1";
            label1.Size = new Size(303, 17);
            label1.TabIndex = 16;
            label1.Text = "ISBN-10:  1433829789";
            // 
            // label4
            // 
            label4.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(73, 85, 121);
            label4.Location = new Point(244, 169);
            label4.Name = "label4";
            label4.Size = new Size(303, 26);
            label4.TabIndex = 18;
            label4.Text = "AUTHOR: Paul J. Silvia";
            // 
            // label3
            // 
            label3.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(73, 85, 121);
            label3.Location = new Point(244, 195);
            label3.Name = "label3";
            label3.Size = new Size(303, 26);
            label3.TabIndex = 19;
            label3.Text = "CATEGORY: Academic";
            // 
            // label5
            // 
            label5.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(73, 85, 121);
            label5.Location = new Point(244, 221);
            label5.Name = "label5";
            label5.Size = new Size(324, 26);
            label5.TabIndex = 20;
            label5.Text = "PUBLISHER: American Psychological Association";
            // 
            // label6
            // 
            label6.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(73, 85, 121);
            label6.Location = new Point(244, 247);
            label6.Name = "label6";
            label6.Size = new Size(303, 26);
            label6.TabIndex = 21;
            label6.Text = "PUBLISHED: 2018 ";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(BorrowButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BookLabel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 383);
            panel1.TabIndex = 22;
            // 
            // Book1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(688, 418);
            Controls.Add(panel1);
            Name = "Book1Form";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BorrowButton;
        private Label label2;
        private Label BookLabel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Panel panel1;
    }
}