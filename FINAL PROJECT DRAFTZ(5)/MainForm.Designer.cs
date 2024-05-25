using CustomControls.RJControls;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            main_pnl = new Panel();
            container_pnl = new Panel();
            navigation_pnl = new Panel();
            button2 = new Button();
            button1 = new Button();
            logoutButton = new CustomButton();
            bookinvent_btn = new CustomButton();
            bookreturn_btn = new CustomButton();
            borrower_btn = new CustomButton();
            library_btn = new CustomButton();
            main_pnl.SuspendLayout();
            navigation_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // main_pnl
            // 
            main_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            main_pnl.BackColor = Color.FromArgb(242, 233, 228);
            main_pnl.Controls.Add(container_pnl);
            main_pnl.Controls.Add(navigation_pnl);
            main_pnl.Location = new Point(0, 0);
            main_pnl.Name = "main_pnl";
            main_pnl.Size = new Size(1186, 700);
            main_pnl.TabIndex = 0;
            // 
            // container_pnl
            // 
            container_pnl.Location = new Point(0, 91);
            container_pnl.Margin = new Padding(5);
            container_pnl.Name = "container_pnl";
            container_pnl.Size = new Size(1186, 609);
            container_pnl.TabIndex = 1;
            // 
            // navigation_pnl
            // 
            navigation_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navigation_pnl.BackColor = Color.FromArgb(74, 78, 105);
            navigation_pnl.Controls.Add(button2);
            navigation_pnl.Controls.Add(button1);
            navigation_pnl.Controls.Add(logoutButton);
            navigation_pnl.Controls.Add(bookinvent_btn);
            navigation_pnl.Controls.Add(bookreturn_btn);
            navigation_pnl.Controls.Add(borrower_btn);
            navigation_pnl.Controls.Add(library_btn);
            navigation_pnl.Location = new Point(0, 0);
            navigation_pnl.Name = "navigation_pnl";
            navigation_pnl.Size = new Size(1186, 93);
            navigation_pnl.TabIndex = 0;
            navigation_pnl.Paint += navigation_pnl_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1146, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 5;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1114, 1);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 4;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(74, 78, 105);
            logoutButton.BackgroundColor = Color.FromArgb(74, 78, 105);
            logoutButton.BorderColor = Color.FromArgb(242, 233, 228);
            logoutButton.BorderRadius = 20;
            logoutButton.BorderSize = 0;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Quicksand SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(985, 43);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(93, 40);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.TextColor = Color.White;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // bookinvent_btn
            // 
            bookinvent_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookinvent_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookinvent_btn.BackColor = Color.FromArgb(74, 78, 105);
            bookinvent_btn.BackgroundColor = Color.FromArgb(74, 78, 105);
            bookinvent_btn.BorderColor = Color.FromArgb(242, 233, 228);
            bookinvent_btn.BorderRadius = 20;
            bookinvent_btn.BorderSize = 2;
            bookinvent_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            bookinvent_btn.FlatStyle = FlatStyle.Flat;
            bookinvent_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookinvent_btn.ForeColor = Color.White;
            bookinvent_btn.Location = new Point(770, 43);
            bookinvent_btn.Name = "bookinvent_btn";
            bookinvent_btn.RightToLeft = RightToLeft.Yes;
            bookinvent_btn.Size = new Size(191, 40);
            bookinvent_btn.TabIndex = 3;
            bookinvent_btn.Text = "BOOK INVENTORY";
            bookinvent_btn.TextColor = Color.White;
            bookinvent_btn.UseVisualStyleBackColor = false;
            bookinvent_btn.Click += bookinvent_btn_Click;
            // 
            // bookreturn_btn
            // 
            bookreturn_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookreturn_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookreturn_btn.BackColor = Color.FromArgb(74, 78, 105);
            bookreturn_btn.BackgroundColor = Color.FromArgb(74, 78, 105);
            bookreturn_btn.BorderColor = Color.FromArgb(242, 233, 228);
            bookreturn_btn.BorderRadius = 20;
            bookreturn_btn.BorderSize = 2;
            bookreturn_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            bookreturn_btn.FlatStyle = FlatStyle.Flat;
            bookreturn_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookreturn_btn.ForeColor = Color.White;
            bookreturn_btn.Location = new Point(550, 43);
            bookreturn_btn.Name = "bookreturn_btn";
            bookreturn_btn.Size = new Size(191, 40);
            bookreturn_btn.TabIndex = 2;
            bookreturn_btn.Text = "BOOK RETURNING";
            bookreturn_btn.TextColor = Color.White;
            bookreturn_btn.UseVisualStyleBackColor = false;
            bookreturn_btn.Click += bookreturn_btn_Click;
            // 
            // borrower_btn
            // 
            borrower_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            borrower_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            borrower_btn.BackColor = Color.FromArgb(74, 78, 105);
            borrower_btn.BackgroundColor = Color.FromArgb(74, 78, 105);
            borrower_btn.BorderColor = Color.FromArgb(242, 233, 228);
            borrower_btn.BorderRadius = 20;
            borrower_btn.BorderSize = 2;
            borrower_btn.FlatAppearance.BorderColor = Color.FromArgb(74, 78, 105);
            borrower_btn.FlatStyle = FlatStyle.Flat;
            borrower_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            borrower_btn.ForeColor = Color.White;
            borrower_btn.Location = new Point(323, 43);
            borrower_btn.Name = "borrower_btn";
            borrower_btn.Size = new Size(191, 40);
            borrower_btn.TabIndex = 1;
            borrower_btn.Text = "BORROWED BOOKS";
            borrower_btn.TextColor = Color.White;
            borrower_btn.UseVisualStyleBackColor = false;
            borrower_btn.Click += borrower_btn_Click;
            // 
            // library_btn
            // 
            library_btn.AccessibleName = "";
            library_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            library_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            library_btn.BackColor = Color.FromArgb(74, 78, 105);
            library_btn.BackgroundColor = Color.FromArgb(74, 78, 105);
            library_btn.BorderColor = Color.FromArgb(242, 233, 228);
            library_btn.BorderRadius = 20;
            library_btn.BorderSize = 2;
            library_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            library_btn.FlatAppearance.BorderSize = 2;
            library_btn.FlatStyle = FlatStyle.Flat;
            library_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            library_btn.ForeColor = Color.White;
            library_btn.Location = new Point(101, 43);
            library_btn.Name = "library_btn";
            library_btn.Size = new Size(191, 40);
            library_btn.TabIndex = 0;
            library_btn.Text = "LIBRARY";
            library_btn.TextColor = Color.White;
            library_btn.UseVisualStyleBackColor = false;
            library_btn.Click += library_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 700);
            Controls.Add(main_pnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            main_pnl.ResumeLayout(false);
            navigation_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel main_pnl;
        private Panel navigation_pnl;
        private CustomButton library_btn;
        private CustomButton bookinvent_btn;
        private CustomButton bookreturn_btn;
        private CustomButton borrower_btn;
        private Panel container_pnl;
        private CustomControls.RJControls.CustomButton logoutButton;
        private Button button2;
        private Button button1;
    }
}