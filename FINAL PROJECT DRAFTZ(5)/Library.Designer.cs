using CustomControls.RJControls;

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
            enterId_btn = new CustomButton();
            button4 = new CustomButton();
            cartButton = new CustomButton();
            checkout1 = new Checkout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1186, 548);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Quicksand SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchBox.Location = new Point(12, 16);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(250, 26);
            searchBox.TabIndex = 1;
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
            enterId_btn.BackColor = Color.FromArgb(34, 34, 59);
            enterId_btn.BackgroundColor = Color.FromArgb(34, 34, 59);
            enterId_btn.BorderColor = Color.PaleVioletRed;
            enterId_btn.BorderRadius = 15;
            enterId_btn.BorderSize = 0;
            enterId_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            enterId_btn.FlatAppearance.BorderSize = 0;
            enterId_btn.FlatStyle = FlatStyle.Flat;
            enterId_btn.Font = new Font("Quicksand SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            enterId_btn.ForeColor = Color.White;
            enterId_btn.Image = Properties.Resources.magnifying_glass__1_;
            enterId_btn.Location = new Point(268, 14);
            enterId_btn.Name = "enterId_btn";
            enterId_btn.Size = new Size(55, 30);
            enterId_btn.TabIndex = 6;
            enterId_btn.TextColor = Color.White;
            enterId_btn.UseVisualStyleBackColor = false;
            enterId_btn.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 34, 59);
            button4.BackgroundColor = Color.FromArgb(34, 34, 59);
            button4.BorderColor = Color.PaleVioletRed;
            button4.BorderRadius = 15;
            button4.BorderSize = 0;
            button4.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Quicksand SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(326, 14);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 7;
            button4.Text = "Reset";
            button4.TextColor = Color.White;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button2_Click;
            // 
            // cartButton
            // 
            cartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cartButton.BackColor = Color.FromArgb(34, 34, 59);
            cartButton.BackgroundColor = Color.FromArgb(34, 34, 59);
            cartButton.BorderColor = Color.PaleVioletRed;
            cartButton.BorderRadius = 38;
            cartButton.BorderSize = 0;
            cartButton.Cursor = Cursors.Hand;
            cartButton.FlatAppearance.BorderColor = Color.Black;
            cartButton.FlatAppearance.BorderSize = 0;
            cartButton.FlatStyle = FlatStyle.Flat;
            cartButton.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cartButton.ForeColor = Color.White;
            cartButton.Image = Properties.Resources.shopping_cart;
            cartButton.Location = new Point(1056, 489);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(76, 76);
            cartButton.TabIndex = 8;
            cartButton.TextColor = Color.White;
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += button3_Click;
            // 
            // checkout1
            // 
            checkout1.BackColor = Color.FromArgb(201, 173, 167);
            checkout1.Location = new Point(25, 25);
            checkout1.Name = "checkout1";
            checkout1.Size = new Size(1136, 559);
            checkout1.TabIndex = 9;
            checkout1.Visible = false;
            checkout1.Load += checkout1_Load;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(1186, 609);
            Controls.Add(cartButton);
            Controls.Add(checkout1);
            Controls.Add(button4);
            Controls.Add(enterId_btn);
            Controls.Add(searchBox);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private CustomButton enterId_btn;
        private CustomButton button4;
        private CustomButton cartButton;
        private Checkout checkout1;
    }
}