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
            bookNoText = new TextBox();
            label7 = new Label();
            publisherText = new TextBox();
            label6 = new Label();
            categoryText = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            isbnText = new TextBox();
            titleText = new TextBox();
            label2 = new Label();
            authorText = new TextBox();
            button1 = new Button();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 611);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // dateText
            // 
            dateText.Location = new Point(395, 231);
            dateText.Name = "dateText";
            dateText.Size = new Size(189, 23);
            dateText.TabIndex = 17;
            // 
            // bookNoText
            // 
            bookNoText.Location = new Point(395, 445);
            bookNoText.Multiline = true;
            bookNoText.Name = "bookNoText";
            bookNoText.Size = new Size(189, 28);
            bookNoText.TabIndex = 16;
            bookNoText.Text = "(Number of books in Inventory)";
            bookNoText.TextChanged += bookNoText_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(235, 448);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 15;
            label7.Text = "COPIES";
            // 
            // publisherText
            // 
            publisherText.Location = new Point(395, 393);
            publisherText.Multiline = true;
            publisherText.Name = "publisherText";
            publisherText.Size = new Size(189, 28);
            publisherText.TabIndex = 14;
            publisherText.Text = "(ex. Seiffer Publishing House)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(222, 396);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 13;
            label6.Text = "PUBLISHER";
            // 
            // categoryText
            // 
            categoryText.Location = new Point(395, 337);
            categoryText.Multiline = true;
            categoryText.Name = "categoryText";
            categoryText.Size = new Size(189, 28);
            categoryText.TabIndex = 12;
            categoryText.Text = "(ex. Horror)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 340);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 11;
            label1.Text = "CATEGORY";
            label1.Click += label1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(739, 448);
            button2.Name = "button2";
            button2.Size = new Size(150, 63);
            button2.TabIndex = 10;
            button2.Text = "SAVE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(174, 231);
            label5.Name = "label5";
            label5.Size = new Size(203, 25);
            label5.TabIndex = 9;
            label5.Text = "DATE OF PUBLISH";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(235, 285);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 8;
            label4.Text = "AUTHOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(235, 126);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 7;
            label3.Text = "TITLE";
            // 
            // isbnText
            // 
            isbnText.Location = new Point(395, 175);
            isbnText.Multiline = true;
            isbnText.Name = "isbnText";
            isbnText.Size = new Size(189, 28);
            isbnText.TabIndex = 6;
            isbnText.Text = "(ex. 13692345678)";
            isbnText.TextChanged += textBox4_TextChanged;
            // 
            // titleText
            // 
            titleText.Location = new Point(395, 123);
            titleText.Multiline = true;
            titleText.Name = "titleText";
            titleText.Size = new Size(189, 28);
            titleText.TabIndex = 5;
            titleText.Text = "(ex. The Lion King)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(245, 178);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 3;
            label2.Text = "ISBN";
            label2.Click += label2_Click_1;
            // 
            // authorText
            // 
            authorText.Location = new Point(395, 282);
            authorText.Multiline = true;
            authorText.Name = "authorText";
            authorText.Size = new Size(189, 28);
            authorText.TabIndex = 2;
            authorText.Text = "(ex. Martin Luther King)";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(723, 361);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 1;
            button1.Text = "UPLOAD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.InitialImage = Properties.Resources.a_brief_history_of_time;
            pictureBox.Location = new Point(683, 87);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(189, 268);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox1_Click;
            // 
            // AddBookDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddBookDashboard";
            Size = new Size(1209, 611);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox;
        private Label label2;
        private TextBox authorText;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox isbnText;
        private TextBox titleText;
        private Button button2;
        private TextBox categoryText;
        private Label label1;
        private TextBox publisherText;
        private Label label6;
        private TextBox bookNoText;
        private Label label7;
        private DateTimePicker dateText;
    }
}
