namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class LoginForm
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
            LogintBox = new TextBox();
            PasstBox = new TextBox();
            Loginlbl = new Label();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogintBox
            // 
            LogintBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogintBox.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point);
            LogintBox.Location = new Point(67, 190);
            LogintBox.Margin = new Padding(2);
            LogintBox.Name = "LogintBox";
            LogintBox.PlaceholderText = "Username";
            LogintBox.Size = new Size(258, 32);
            LogintBox.TabIndex = 0;
            LogintBox.TextChanged += textBox1_TextChanged;
            // 
            // PasstBox
            // 
            PasstBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasstBox.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point);
            PasstBox.Location = new Point(67, 230);
            PasstBox.Margin = new Padding(2);
            PasstBox.Name = "PasstBox";
            PasstBox.PlaceholderText = "Password";
            PasstBox.Size = new Size(258, 32);
            PasstBox.TabIndex = 1;
            PasstBox.UseSystemPasswordChar = true;
            PasstBox.TextChanged += PasstBox_TextChanged;
            // 
            // Loginlbl
            // 
            Loginlbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Loginlbl.AutoSize = true;
            Loginlbl.Font = new Font("Microsoft Sans Serif", 17.8559971F, FontStyle.Bold, GraphicsUnit.Point);
            Loginlbl.ForeColor = SystemColors.HotTrack;
            Loginlbl.Location = new Point(152, 151);
            Loginlbl.Margin = new Padding(2, 0, 2, 0);
            Loginlbl.Name = "Loginlbl";
            Loginlbl.Size = new Size(92, 29);
            Loginlbl.TabIndex = 2;
            Loginlbl.Text = "LOGIN";
            Loginlbl.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(67, 276);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(257, 27);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.InitialImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(120, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 324);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Loginlbl);
            Controls.Add(PasstBox);
            Controls.Add(LogintBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogintBox;
        private TextBox PasstBox;
        private Label Loginlbl;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}