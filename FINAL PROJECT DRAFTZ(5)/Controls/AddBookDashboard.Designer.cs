using CustomControls.RJControls;
using System.Windows.Forms;
namespace FINAL_PROJECT_DRAFTZ_5_.Controls
{
    partial class AddBookDashboard
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
            panel1 = new Panel();
            dateText = new DateTimePicker();
            bookNoText = new CustomTextbox();
            label7 = new Label();
            publisherText = new CustomTextbox();
            label6 = new Label();
            categoryText = new CustomTextbox();
            label1 = new Label();
            button2 = new CustomButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            isbnText = new CustomTextbox();
            titleText = new CustomTextbox();
            label2 = new Label();
            authorText = new CustomTextbox();
            button1 = new CustomButton();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 213, 206);
            panel1.Controls.Add(dateText);
            panel1.Controls.Add(bookNoText);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(publisherText);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(categoryText);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(isbnText);
            panel1.Controls.Add(titleText);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(authorText);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 648);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // dateText
            // 
            dateText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateText.Location = new Point(235, 190);
            dateText.MinimumSize = new Size(300, 30);
            dateText.Name = "dateText";
            dateText.Size = new Size(300, 30);
            dateText.TabIndex = 17;
            // 
            // bookNoText
            // 
            bookNoText.BackColor = SystemColors.Window;
            bookNoText.BorderColor = Color.FromArgb(102, 102, 102);
            bookNoText.BorderFocusColor = SystemColors.ActiveCaptionText;
            bookNoText.BorderRadius = 18;
            bookNoText.BorderSize = 2;
            bookNoText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookNoText.ForeColor = Color.FromArgb(64, 64, 64);
            bookNoText.Location = new Point(235, 442);
            bookNoText.Margin = new Padding(4);
            bookNoText.MinimumSize = new Size(300, 30);
            bookNoText.Multiline = true;
            bookNoText.Name = "bookNoText";
            bookNoText.Padding = new Padding(10, 7, 10, 7);
            bookNoText.PasswordChar = false;
            bookNoText.PlaceholderColor = Color.DarkGray;
            bookNoText.PlaceholderText = "";
            bookNoText.Size = new Size(300, 36);
            bookNoText.TabIndex = 16;
            bookNoText.Texts = "";
            bookNoText.UnderlinedStyle = false;
            bookNoText.TextChanged += bookNoText_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(128, 442);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 16;
            label7.Text = "COPIES";
            // 
            // publisherText
            // 
            publisherText.BackColor = SystemColors.Window;
            publisherText.BorderColor = Color.FromArgb(102, 102, 102);
            publisherText.BorderFocusColor = SystemColors.ActiveCaptionText;
            publisherText.BorderRadius = 18;
            publisherText.BorderSize = 2;
            publisherText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publisherText.ForeColor = Color.FromArgb(64, 64, 64);
            publisherText.Location = new Point(235, 379);
            publisherText.Margin = new Padding(4);
            publisherText.MinimumSize = new Size(300, 30);
            publisherText.Multiline = true;
            publisherText.Name = "publisherText";
            publisherText.Padding = new Padding(10, 7, 10, 7);
            publisherText.PasswordChar = false;
            publisherText.PlaceholderColor = Color.DarkGray;
            publisherText.PlaceholderText = "";
            publisherText.Size = new Size(300, 36);
            publisherText.TabIndex = 14;
            publisherText.Texts = "";
            publisherText.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(91, 379);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 14;
            label6.Text = "PUBLISHER";
            // 
            // categoryText
            // 
            categoryText.BackColor = SystemColors.Window;
            categoryText.BorderColor = Color.FromArgb(102, 102, 102);
            categoryText.BorderFocusColor = SystemColors.ActiveCaptionText;
            categoryText.BorderRadius = 18;
            categoryText.BorderSize = 2;
            categoryText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryText.ForeColor = Color.FromArgb(64, 64, 64);
            categoryText.Location = new Point(235, 316);
            categoryText.Margin = new Padding(4);
            categoryText.MinimumSize = new Size(300, 30);
            categoryText.Multiline = true;
            categoryText.Name = "categoryText";
            categoryText.Padding = new Padding(10, 7, 10, 7);
            categoryText.PasswordChar = false;
            categoryText.PlaceholderColor = Color.DarkGray;
            categoryText.PlaceholderText = "";
            categoryText.Size = new Size(300, 36);
            categoryText.TabIndex = 12;
            categoryText.Texts = "";
            categoryText.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 316);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 13;
            label1.Text = "CATEGORY";
            label1.Click += label1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaptionText;
            button2.BackgroundColor = SystemColors.InactiveCaptionText;
            button2.BorderColor = Color.PaleVioletRed;
            button2.BorderRadius = 32;
            button2.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(640, 479);
            button2.Name = "button2";
            button2.Size = new Size(150, 63);
            button2.TabIndex = 10;
            button2.Text = "SAVE";
            button2.TextColor = Color.White;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 190);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 9;
            label5.Text = "DATE OF PUBLISH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(114, 253);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 8;
            label4.Text = "AUTHOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(141, 64);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 7;
            label3.Text = "TITLE";
            // 
            // isbnText
            // 
            isbnText.BackColor = SystemColors.Window;
            isbnText.BorderColor = Color.FromArgb(102, 102, 102);
            isbnText.BorderFocusColor = SystemColors.ActiveCaptionText;
            isbnText.BorderRadius = 18;
            isbnText.BorderSize = 2;
            isbnText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnText.ForeColor = Color.FromArgb(64, 64, 64);
            isbnText.Location = new Point(235, 127);
            isbnText.Margin = new Padding(3, 4, 3, 4);
            isbnText.MinimumSize = new Size(300, 30);
            isbnText.Multiline = true;
            isbnText.Name = "isbnText";
            isbnText.Padding = new Padding(10, 7, 10, 7);
            isbnText.PasswordChar = false;
            isbnText.PlaceholderColor = Color.DarkGray;
            isbnText.PlaceholderText = "";
            isbnText.Size = new Size(300, 36);
            isbnText.TabIndex = 6;
            isbnText.Texts = "";
            isbnText.UnderlinedStyle = false;
            isbnText.TextChanged += textBox4_TextChanged;
            // 
            // titleText
            // 
            titleText.BackColor = SystemColors.Window;
            titleText.BorderColor = Color.FromArgb(102, 102, 102);
            titleText.BorderFocusColor = SystemColors.ActiveCaptionText;
            titleText.BorderRadius = 18;
            titleText.BorderSize = 2;
            titleText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleText.ForeColor = Color.FromArgb(64, 64, 64);
            titleText.Location = new Point(235, 64);
            titleText.Margin = new Padding(4);
            titleText.MinimumSize = new Size(300, 30);
            titleText.Multiline = true;
            titleText.Name = "titleText";
            titleText.Padding = new Padding(10, 7, 10, 7);
            titleText.PasswordChar = false;
            titleText.PlaceholderColor = Color.DarkGray;
            titleText.PlaceholderText = "";
            titleText.Size = new Size(300, 36);
            titleText.TabIndex = 5;
            titleText.Texts = "";
            titleText.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 127);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 3;
            label2.Text = "ISBN";
            // 
            // authorText
            // 
            authorText.BackColor = SystemColors.Window;
            authorText.BorderColor = Color.FromArgb(102, 102, 102);
            authorText.BorderFocusColor = SystemColors.ActiveCaptionText;
            authorText.BorderRadius = 18;
            authorText.BorderSize = 2;
            authorText.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorText.ForeColor = Color.FromArgb(64, 64, 64);
            authorText.Location = new Point(235, 253);
            authorText.Margin = new Padding(4);
            authorText.MinimumSize = new Size(300, 30);
            authorText.Multiline = true;
            authorText.Name = "authorText";
            authorText.Padding = new Padding(10, 7, 10, 7);
            authorText.PasswordChar = false;
            authorText.PlaceholderColor = Color.DarkGray;
            authorText.PlaceholderText = "";
            authorText.Size = new Size(300, 36);
            authorText.TabIndex = 2;
            authorText.Texts = "";
            authorText.UnderlinedStyle = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(102, 102, 102);
            button1.BackgroundColor = Color.FromArgb(102, 102, 102);
            button1.BorderColor = Color.PaleVioletRed;
            button1.BorderRadius = 22;
            button1.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(102, 102, 102);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(626, 400);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 41);
            button1.TabIndex = 1;
            button1.Text = "UPLOAD PHOTO";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.InitialImage = Properties.Resources.a_brief_history_of_time;
            pictureBox.Location = new Point(604, 64);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(222, 329);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // AddBookDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddBookDashboard";
            Size = new Size(882, 559);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CustomButton button1;
        private PictureBox pictureBox;
        private Label label2;
        private CustomTextbox authorText;
        private Label label5;
        private Label label4;
        private Label label3;
        private CustomTextbox isbnText;
        private CustomTextbox titleText;
        private CustomButton button2;
        private CustomTextbox categoryText;
        private Label label1;
        private CustomTextbox publisherText;
        private Label label6;
        private CustomTextbox bookNoText;
        private Label label7;
        private DateTimePicker dateText;
    }
}