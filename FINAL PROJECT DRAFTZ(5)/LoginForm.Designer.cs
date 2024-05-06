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
            lbl1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // LogintBox
            // 
            LogintBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogintBox.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point);
            LogintBox.Location = new Point(86, 266);
            LogintBox.Name = "LogintBox";
            LogintBox.PlaceholderText = "Username";
            LogintBox.Size = new Size(330, 39);
            LogintBox.TabIndex = 0;
            LogintBox.TextChanged += textBox1_TextChanged;
            // 
            // PasstBox
            // 
            PasstBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasstBox.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Regular, GraphicsUnit.Point);
            PasstBox.Location = new Point(86, 322);
            PasstBox.Name = "PasstBox";
            PasstBox.PlaceholderText = "Password";
            PasstBox.Size = new Size(330, 39);
            PasstBox.TabIndex = 1;
            PasstBox.TextChanged += PasstBox_TextChanged;
            // 
            // Loginlbl
            // 
            Loginlbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Loginlbl.AutoSize = true;
            Loginlbl.Font = new Font("Rubik", 17.8559971F, FontStyle.Bold, GraphicsUnit.Point);
            Loginlbl.ForeColor = SystemColors.HotTrack;
            Loginlbl.Location = new Point(196, 211);
            Loginlbl.Name = "Loginlbl";
            Loginlbl.Size = new Size(113, 37);
            Loginlbl.TabIndex = 2;
            Loginlbl.Text = "LOGIN";
            Loginlbl.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 116);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 3;
            label1.Click += label1_Click_1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Impact", 20.16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(162, 143);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(186, 43);
            lbl1.TabIndex = 4;
            lbl1.Text = "Wla pa lugo";
            lbl1.Click += label2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.792F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(86, 387);
            button1.Name = "button1";
            button1.Size = new Size(330, 38);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 454);
            Controls.Add(button1);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Controls.Add(Loginlbl);
            Controls.Add(PasstBox);
            Controls.Add(LogintBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogintBox;
        private TextBox PasstBox;
        private Label Loginlbl;
        private Label label1;
        private Label lbl1;
        private Button button1;
    }
}