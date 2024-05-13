using System.Windows.Forms;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookReturn
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
            panel1 = new Panel();
            panel5 = new Panel();
            Dsplay_detailsbrwer = new Label();
            cancel_btn = new Button();
            confirm_btn = new Button();
            Dsplay_namebrwer = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            borrowedbooks_tbl = new ListView();
            title_column = new ColumnHeader();
            author_column = new ColumnHeader();
            dueDate_column = new ColumnHeader();
            Dsplay_return = new Label();
            Dsplay_due = new Label();
            Dsplay_author = new Label();
            Dsplay_title = new Label();
            Dsplay_borrowedbooks = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            lastreturnlbl = new Label();
            bbcountlbl = new Label();
            detailslbl = new Label();
            namelbl = new Label();
            Dsplay_lstreturn = new Label();
            Dsplay_bookcount = new Label();
            Dsplay_details = new Label();
            Dsplay_name = new Label();
            Dsplay_borrowerinfo = new Label();
            panel2 = new Panel();
            Dsplay_Id = new Label();
            enterId_btn = new Button();
            id_txtbox = new TextBox();
            Dsplay_bookreturn = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 233, 228);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 591);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(Dsplay_detailsbrwer);
            panel5.Controls.Add(cancel_btn);
            panel5.Controls.Add(confirm_btn);
            panel5.Controls.Add(Dsplay_namebrwer);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(530, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(614, 591);
            panel5.TabIndex = 8;
            // 
            // Dsplay_detailsbrwer
            // 
            Dsplay_detailsbrwer.AutoSize = true;
            Dsplay_detailsbrwer.Font = new Font("Quicksand SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_detailsbrwer.Location = new Point(489, 56);
            Dsplay_detailsbrwer.Name = "Dsplay_detailsbrwer";
            Dsplay_detailsbrwer.Size = new Size(0, 31);
            Dsplay_detailsbrwer.TabIndex = 4;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(102, 102, 102);
            cancel_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_btn.ForeColor = Color.White;
            cancel_btn.Location = new Point(303, 547);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(126, 44);
            cancel_btn.TabIndex = 3;
            cancel_btn.Text = "CANCEL";
            cancel_btn.UseVisualStyleBackColor = false;
            // 
            // confirm_btn
            // 
            confirm_btn.BackColor = Color.FromArgb(102, 102, 102);
            confirm_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            confirm_btn.FlatStyle = FlatStyle.Flat;
            confirm_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_btn.ForeColor = Color.White;
            confirm_btn.Location = new Point(465, 547);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(126, 44);
            confirm_btn.TabIndex = 2;
            confirm_btn.Text = "CONFIRM";
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // Dsplay_namebrwer
            // 
            Dsplay_namebrwer.AutoSize = true;
            Dsplay_namebrwer.Font = new Font("Quicksand SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_namebrwer.Location = new Point(35, 56);
            Dsplay_namebrwer.Name = "Dsplay_namebrwer";
            Dsplay_namebrwer.Size = new Size(0, 31);
            Dsplay_namebrwer.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 213, 206);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(Dsplay_return);
            panel6.Controls.Add(Dsplay_due);
            panel6.Controls.Add(Dsplay_author);
            panel6.Controls.Add(Dsplay_title);
            panel6.Controls.Add(Dsplay_borrowedbooks);
            panel6.Location = new Point(12, 93);
            panel6.Name = "panel6";
            panel6.Size = new Size(590, 442);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.BackColor = Color.FromArgb(225, 213, 206);
            panel7.Controls.Add(borrowedbooks_tbl);
            panel7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel7.Location = new Point(0, 107);
            panel7.Name = "panel7";
            panel7.Size = new Size(590, 335);
            panel7.TabIndex = 7;
            // 
            // borrowedbooks_tbl
            // 
            borrowedbooks_tbl.CheckBoxes = true;
            borrowedbooks_tbl.Columns.AddRange(new ColumnHeader[] { title_column, author_column, dueDate_column });
            borrowedbooks_tbl.Dock = DockStyle.Fill;
            borrowedbooks_tbl.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borrowedbooks_tbl.GridLines = true;
            borrowedbooks_tbl.Location = new Point(0, 0);
            borrowedbooks_tbl.Name = "borrowedbooks_tbl";
            borrowedbooks_tbl.Size = new Size(590, 335);
            borrowedbooks_tbl.TabIndex = 1;
            borrowedbooks_tbl.UseCompatibleStateImageBehavior = false;
            borrowedbooks_tbl.View = View.Details;
            // 
            // title_column
            // 
            title_column.Text = "Title";
            title_column.TextAlign = HorizontalAlignment.Center;
            title_column.Width = 190;
            // 
            // author_column
            // 
            author_column.Text = "Author";
            author_column.TextAlign = HorizontalAlignment.Center;
            author_column.Width = 190;
            // 
            // dueDate_column
            // 
            dueDate_column.Text = "Due Date";
            dueDate_column.TextAlign = HorizontalAlignment.Center;
            dueDate_column.Width = 190;
            // 
            // Dsplay_return
            // 
            Dsplay_return.AutoSize = true;
            Dsplay_return.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_return.Location = new Point(453, 65);
            Dsplay_return.Name = "Dsplay_return";
            Dsplay_return.Size = new Size(74, 24);
            Dsplay_return.TabIndex = 6;
            Dsplay_return.Text = "RETURN";
            // 
            // Dsplay_due
            // 
            Dsplay_due.AutoSize = true;
            Dsplay_due.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_due.Location = new Point(310, 65);
            Dsplay_due.Name = "Dsplay_due";
            Dsplay_due.Size = new Size(84, 24);
            Dsplay_due.TabIndex = 5;
            Dsplay_due.Text = "DUE DATE";
            // 
            // Dsplay_author
            // 
            Dsplay_author.AutoSize = true;
            Dsplay_author.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_author.Location = new Point(163, 65);
            Dsplay_author.Name = "Dsplay_author";
            Dsplay_author.Size = new Size(76, 24);
            Dsplay_author.TabIndex = 4;
            Dsplay_author.Text = "AUTHOR";
            // 
            // Dsplay_title
            // 
            Dsplay_title.AutoSize = true;
            Dsplay_title.Font = new Font("Quicksand Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_title.Location = new Point(39, 65);
            Dsplay_title.Name = "Dsplay_title";
            Dsplay_title.Size = new Size(52, 24);
            Dsplay_title.TabIndex = 3;
            Dsplay_title.Text = "TITLE";
            // 
            // Dsplay_borrowedbooks
            // 
            Dsplay_borrowedbooks.AutoSize = true;
            Dsplay_borrowedbooks.Font = new Font("Quicksand", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_borrowedbooks.Location = new Point(183, 11);
            Dsplay_borrowedbooks.Name = "Dsplay_borrowedbooks";
            Dsplay_borrowedbooks.Size = new Size(234, 40);
            Dsplay_borrowedbooks.TabIndex = 2;
            Dsplay_borrowedbooks.Text = "Borrowed Books";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 51, 51);
            panel4.Location = new Point(9, 279);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 2);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 233, 228);
            panel3.Controls.Add(lastreturnlbl);
            panel3.Controls.Add(bbcountlbl);
            panel3.Controls.Add(detailslbl);
            panel3.Controls.Add(namelbl);
            panel3.Controls.Add(Dsplay_lstreturn);
            panel3.Controls.Add(Dsplay_bookcount);
            panel3.Controls.Add(Dsplay_details);
            panel3.Controls.Add(Dsplay_name);
            panel3.Controls.Add(Dsplay_borrowerinfo);
            panel3.Location = new Point(0, 289);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 302);
            panel3.TabIndex = 6;
            // 
            // lastreturnlbl
            // 
            lastreturnlbl.AutoSize = true;
            lastreturnlbl.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastreturnlbl.Location = new Point(219, 247);
            lastreturnlbl.Name = "lastreturnlbl";
            lastreturnlbl.Size = new Size(0, 28);
            lastreturnlbl.TabIndex = 14;
            // 
            // bbcountlbl
            // 
            bbcountlbl.AutoSize = true;
            bbcountlbl.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bbcountlbl.Location = new Point(303, 205);
            bbcountlbl.Name = "bbcountlbl";
            bbcountlbl.RightToLeft = RightToLeft.Yes;
            bbcountlbl.Size = new Size(0, 28);
            bbcountlbl.TabIndex = 13;
            // 
            // detailslbl
            // 
            detailslbl.AutoSize = true;
            detailslbl.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            detailslbl.Location = new Point(149, 166);
            detailslbl.Name = "detailslbl";
            detailslbl.Size = new Size(0, 28);
            detailslbl.TabIndex = 12;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Quicksand SemiBold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            namelbl.Location = new Point(143, 126);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(0, 28);
            namelbl.TabIndex = 11;
            // 
            // Dsplay_lstreturn
            // 
            Dsplay_lstreturn.AutoSize = true;
            Dsplay_lstreturn.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_lstreturn.Location = new Point(64, 244);
            Dsplay_lstreturn.Name = "Dsplay_lstreturn";
            Dsplay_lstreturn.Size = new Size(155, 30);
            Dsplay_lstreturn.TabIndex = 10;
            Dsplay_lstreturn.Text = "Last Returned:";
            // 
            // Dsplay_bookcount
            // 
            Dsplay_bookcount.AutoSize = true;
            Dsplay_bookcount.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_bookcount.Location = new Point(64, 202);
            Dsplay_bookcount.Name = "Dsplay_bookcount";
            Dsplay_bookcount.Size = new Size(237, 30);
            Dsplay_bookcount.TabIndex = 9;
            Dsplay_bookcount.Text = "Borrowed Books Count:";
            // 
            // Dsplay_details
            // 
            Dsplay_details.AutoSize = true;
            Dsplay_details.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_details.Location = new Point(64, 163);
            Dsplay_details.Name = "Dsplay_details";
            Dsplay_details.Size = new Size(84, 30);
            Dsplay_details.TabIndex = 8;
            Dsplay_details.Text = "Details:";
            // 
            // Dsplay_name
            // 
            Dsplay_name.AutoSize = true;
            Dsplay_name.Font = new Font("Quicksand SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_name.Location = new Point(64, 123);
            Dsplay_name.Name = "Dsplay_name";
            Dsplay_name.Size = new Size(75, 30);
            Dsplay_name.TabIndex = 7;
            Dsplay_name.Text = "Name:";
            // 
            // Dsplay_borrowerinfo
            // 
            Dsplay_borrowerinfo.AutoSize = true;
            Dsplay_borrowerinfo.Font = new Font("Quicksand", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_borrowerinfo.Location = new Point(16, 26);
            Dsplay_borrowerinfo.Name = "Dsplay_borrowerinfo";
            Dsplay_borrowerinfo.Size = new Size(307, 55);
            Dsplay_borrowerinfo.TabIndex = 6;
            Dsplay_borrowerinfo.Text = "Borrower's Info:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 233, 228);
            panel2.Controls.Add(Dsplay_Id);
            panel2.Controls.Add(enterId_btn);
            panel2.Controls.Add(id_txtbox);
            panel2.Controls.Add(Dsplay_bookreturn);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 273);
            panel2.TabIndex = 0;
            // 
            // Dsplay_Id
            // 
            Dsplay_Id.AutoSize = true;
            Dsplay_Id.Font = new Font("Quicksand Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_Id.Location = new Point(155, 114);
            Dsplay_Id.Name = "Dsplay_Id";
            Dsplay_Id.Size = new Size(88, 30);
            Dsplay_Id.TabIndex = 6;
            Dsplay_Id.Text = "Input Id:";
            // 
            // enterId_btn
            // 
            enterId_btn.BackColor = Color.FromArgb(102, 102, 102);
            enterId_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            enterId_btn.FlatStyle = FlatStyle.Flat;
            enterId_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            enterId_btn.ForeColor = Color.White;
            enterId_btn.Location = new Point(357, 145);
            enterId_btn.Name = "enterId_btn";
            enterId_btn.Size = new Size(118, 43);
            enterId_btn.TabIndex = 5;
            enterId_btn.Text = "ENTER";
            enterId_btn.UseVisualStyleBackColor = false;
            enterId_btn.Click += enterId_btn_Click;
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(30, 153);
            id_txtbox.Multiline = true;
            id_txtbox.Name = "id_txtbox";
            id_txtbox.Size = new Size(308, 26);
            id_txtbox.TabIndex = 4;
            id_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Dsplay_bookreturn
            // 
            Dsplay_bookreturn.AutoSize = true;
            Dsplay_bookreturn.Font = new Font("Quicksand", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_bookreturn.Location = new Point(84, 9);
            Dsplay_bookreturn.Name = "Dsplay_bookreturn";
            Dsplay_bookreturn.Size = new Size(348, 55);
            Dsplay_bookreturn.TabIndex = 3;
            Dsplay_bookreturn.Text = "BOOK RETURNING";
            // 
            // BookReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 591);
            Controls.Add(panel1);
            Name = "BookReturn";
            Text = "BookReturn";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button enterId_btn;
        private TextBox id_txtbox;
        private Label Dsplay_bookreturn;
        private Panel panel3;
        private Panel panel4;
        private Label Dsplay_borrowerinfo;
        private Label Dsplay_details;
        private Label Dsplay_name;
        private Label Dsplay_lstreturn;
        private Label Dsplay_bookcount;
        private Label Dsplay_Id;
        private Panel panel5;
        private Label Dsplay_namebrwer;
        private Panel panel6;
        private Label Dsplay_return;
        private Label Dsplay_due;
        private Label Dsplay_author;
        private Label Dsplay_title;
        private Label Dsplay_borrowedbooks;
        private Panel panel7;
        private Button cancel_btn;
        private Button confirm_btn;
        private Label Dsplay_detailsbrwer;
        private Label namelbl;
        private Label lastreturnlbl;
        private Label bbcountlbl;
        private Label detailslbl;
        private ListView borrowedbooks_tbl;
        private ColumnHeader title_column;
        private ColumnHeader author_column;
        private ColumnHeader dueDate_column;
    }
}