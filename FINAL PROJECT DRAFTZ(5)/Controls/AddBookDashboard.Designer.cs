using CustomControls.RJControls;
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
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button2 = new CustomButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new CustomButton();
            AddBookPicture = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddBookPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 213, 206);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(AddBookPicture);
            panel1.Location = new Point(16, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 648);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(98, 471);
            label7.Name = "label7";
            label7.Size = new Size(102, 26);
            label7.TabIndex = 16;
            label7.Text = "COPIES";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(295, 461);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(215, 36);
            textBox7.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(75, 403);
            label6.Name = "label6";
            label6.Size = new Size(147, 26);
            label6.TabIndex = 14;
            label6.Text = "PUBLISHER";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 336);
            label1.Name = "label1";
            label1.Size = new Size(144, 26);
            label1.TabIndex = 13;
            label1.Text = "CATEGORY";
            label1.Click += label1_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(295, 393);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 36);
            textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(295, 326);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 36);
            textBox5.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(102, 102, 102);
            button2.BackgroundColor = Color.FromArgb(102, 102, 102);
            button2.BorderColor = Color.PaleVioletRed;
            button2.BorderRadius = 22;
            button2.BorderSize = 0;
            button2.FlatAppearance.BorderColor = Color.FromArgb(102, 102, 102);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(712, 535);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(133, 76);
            button2.TabIndex = 10;
            button2.Text = "SAVE";
            button2.TextColor = Color.Transparent;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 202);
            label5.Name = "label5";
            label5.Size = new Size(222, 26);
            label5.TabIndex = 9;
            label5.Text = "DATE OF PUBLISH";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(90, 273);
            label4.Name = "label4";
            label4.Size = new Size(110, 26);
            label4.TabIndex = 8;
            label4.Text = "AUTHOR";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(109, 71);
            label3.Name = "label3";
            label3.Size = new Size(74, 26);
            label3.TabIndex = 7;
            label3.Text = "TITLE";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(295, 126);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 36);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(295, 61);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 36);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 192);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 36);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 136);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 3;
            label2.Text = "ISBN";
            label2.Click += label2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 263);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 36);
            textBox1.TabIndex = 2;
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
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(641, 437);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 48);
            button1.TabIndex = 1;
            button1.Text = "UPLOAD";
            button1.TextColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddBookPicture
            // 
            AddBookPicture.BackColor = Color.White;
            AddBookPicture.Location = new Point(569, 32);
            AddBookPicture.Margin = new Padding(3, 4, 3, 4);
            AddBookPicture.Name = "AddBookPicture";
            AddBookPicture.Size = new Size(276, 397);
            AddBookPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            AddBookPicture.TabIndex = 0;
            AddBookPicture.TabStop = false;
            AddBookPicture.Click += pictureBox1_Click;
            // 
            // AddBookDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBookDashboard";
            Size = new Size(915, 709);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddBookPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CustomButton button1;
        private PictureBox AddBookPicture;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private CustomButton button2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
    }
}
