namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class Library
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchBox = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            enterId_btn = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1146, 548);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(12, 46);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(250, 23);
            searchBox.TabIndex = 1;
            searchBox.Text = "Search";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // enterId_btn
            // 
            enterId_btn.BackColor = Color.FromArgb(102, 102, 102);
            enterId_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            enterId_btn.FlatStyle = FlatStyle.Flat;
            enterId_btn.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            enterId_btn.ForeColor = Color.White;
            enterId_btn.Location = new Point(268, 42);
            enterId_btn.Name = "enterId_btn";
            enterId_btn.Size = new Size(75, 27);
            enterId_btn.TabIndex = 6;
            enterId_btn.Text = "Search";
            enterId_btn.UseVisualStyleBackColor = false;
            enterId_btn.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(102, 102, 102);
            button4.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(349, 42);
            button4.Name = "button4";
            button4.Size = new Size(75, 27);
            button4.TabIndex = 7;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(102, 102, 102);
            button5.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1083, 51);
            button5.Name = "button5";
            button5.Size = new Size(75, 27);
            button5.TabIndex = 8;
            button5.Text = "Checkout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button3_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1170, 634);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(enterId_btn);
            Controls.Add(searchBox);
            Controls.Add(flowLayoutPanel1);
            Name = "Library";
            Text = "Library";
            Load += Library_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox searchBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button enterId_btn;
        private Button button4;
        private Button button5;
    }
}