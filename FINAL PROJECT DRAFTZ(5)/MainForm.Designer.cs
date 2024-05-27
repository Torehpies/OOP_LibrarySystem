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
            manageAcc = new CustomButton();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            welcomeLbl = new Label();
            userLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            logoutButton = new CustomButton();
            bookinvent_btn = new CustomButton();
            bookreturn_btn = new CustomButton();
            borrower_btn = new CustomButton();
            library_btn = new CustomButton();
            main_pnl.SuspendLayout();
            navigation_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            navigation_pnl.Controls.Add(manageAcc);
            navigation_pnl.Controls.Add(label2);
            navigation_pnl.Controls.Add(pictureBox1);
            navigation_pnl.Controls.Add(welcomeLbl);
            navigation_pnl.Controls.Add(userLabel);
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
            // manageAcc
            // 
            manageAcc.AccessibleName = "";
            manageAcc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            manageAcc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            manageAcc.BackColor = Color.FromArgb(74, 78, 105);
            manageAcc.BackgroundColor = Color.FromArgb(74, 78, 105);
            manageAcc.BorderColor = Color.FromArgb(242, 233, 228);
            manageAcc.BorderRadius = 20;
            manageAcc.BorderSize = 0;
            manageAcc.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            manageAcc.FlatAppearance.BorderSize = 0;
            manageAcc.FlatStyle = FlatStyle.Flat;
            manageAcc.Font = new Font("Quicksand Medium", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            manageAcc.ForeColor = Color.White;
            manageAcc.Location = new Point(1011, 38);
            manageAcc.Margin = new Padding(0);
            manageAcc.Name = "manageAcc";
            manageAcc.Size = new Size(91, 40);
            manageAcc.TabIndex = 11;
            manageAcc.Text = "Accounts";
            manageAcc.TextColor = Color.White;
            manageAcc.UseVisualStyleBackColor = false;
            manageAcc.Click += manageAcc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(573, 5);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 9;
            label2.Text = "|   VOOX";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.vooxSmallIcon3;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(545, 6);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLbl.ForeColor = SystemColors.ButtonHighlight;
            welcomeLbl.Location = new Point(29, 22);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(84, 24);
            welcomeLbl.TabIndex = 7;
            welcomeLbl.Text = "Welcome,";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userLabel.ForeColor = SystemColors.ButtonHighlight;
            userLabel.Location = new Point(29, 46);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(87, 24);
            userLabel.TabIndex = 6;
            userLabel.Text = "username";
            userLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            logoutButton.Font = new Font("Quicksand Medium", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(1102, 38);
            logoutButton.Margin = new Padding(0);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 40);
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
            bookinvent_btn.Location = new Point(798, 38);
            bookinvent_btn.Name = "bookinvent_btn";
            bookinvent_btn.RightToLeft = RightToLeft.Yes;
            bookinvent_btn.Size = new Size(191, 41);
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
            bookreturn_btn.Location = new Point(599, 38);
            bookreturn_btn.Name = "bookreturn_btn";
            bookreturn_btn.Size = new Size(191, 41);
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
            borrower_btn.Location = new Point(400, 38);
            borrower_btn.Name = "borrower_btn";
            borrower_btn.Size = new Size(191, 41);
            borrower_btn.TabIndex = 1;
            borrower_btn.Text = "BORROW HISTORY";
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
            library_btn.Location = new Point(201, 38);
            library_btn.Name = "library_btn";
            library_btn.Size = new Size(191, 41);
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
            navigation_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label userLabel;
        private Label welcomeLbl;
        private PictureBox pictureBox1;
        private Label label2;
        private CustomButton manageAcc;
    }
}