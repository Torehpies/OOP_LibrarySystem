using System.Windows.Forms;
using CustomControls.RJControls;
using FINAL_PROJECT_DRAFTZ_5_;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookReturn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            errorMsg = new Label();
            detailslbl = new Label();
            namelbl = new Label();
            panel2 = new RoundedPanel();
            borrowedbooks_tbl = new ListView();
            title_column = new ColumnHeader();
            author_column = new ColumnHeader();
            borrowDate_column = new ColumnHeader();
            dueDate_column = new ColumnHeader();
            bbcountslbl = new Label();
            Dsplay_borrowedbooks = new Label();
            confirm_btn = new CustomButton();
            enterId_btn = new CustomButton();
            Dsplay_Id = new Label();
            id_txtbox = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 233, 228);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 570);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 213, 206);
            panel5.Controls.Add(errorMsg);
            panel5.Controls.Add(detailslbl);
            panel5.Controls.Add(namelbl);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(bbcountslbl);
            panel5.Controls.Add(Dsplay_borrowedbooks);
            panel5.Controls.Add(confirm_btn);
            panel5.Controls.Add(enterId_btn);
            panel5.Controls.Add(Dsplay_Id);
            panel5.Controls.Add(id_txtbox);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1170, 570);
            panel5.TabIndex = 8;
            // 
            // errorMsg
            // 
            errorMsg.AutoSize = true;
            errorMsg.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorMsg.Location = new Point(653, 26);
            errorMsg.Name = "errorMsg";
            errorMsg.Size = new Size(53, 24);
            errorMsg.TabIndex = 10;
            errorMsg.Text = "label1";
            // 
            // detailslbl
            // 
            detailslbl.AutoSize = true;
            detailslbl.Font = new Font("Quicksand Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            detailslbl.Location = new Point(422, 79);
            detailslbl.Name = "detailslbl";
            detailslbl.Size = new Size(0, 35);
            detailslbl.TabIndex = 9;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Quicksand Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            namelbl.Location = new Point(42, 79);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(0, 35);
            namelbl.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 153, 153);
            panel2.BorderColor = Color.FromArgb(153, 153, 153);
            panel2.BorderRadius = 20;
            panel2.BorderSize = 2;
            panel2.Controls.Add(borrowedbooks_tbl);
            panel2.Location = new Point(32, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 398);
            panel2.TabIndex = 7;
            // 
            // borrowedbooks_tbl
            // 
            borrowedbooks_tbl.CheckBoxes = true;
            borrowedbooks_tbl.Columns.AddRange(new ColumnHeader[] { title_column, author_column, borrowDate_column, dueDate_column });
            borrowedbooks_tbl.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borrowedbooks_tbl.FullRowSelect = true;
            borrowedbooks_tbl.GridLines = true;
            borrowedbooks_tbl.Location = new Point(33, 26);
            borrowedbooks_tbl.Name = "borrowedbooks_tbl";
            borrowedbooks_tbl.Size = new Size(1044, 348);
            borrowedbooks_tbl.TabIndex = 1;
            borrowedbooks_tbl.UseCompatibleStateImageBehavior = false;
            borrowedbooks_tbl.View = View.Details;
            borrowedbooks_tbl.ItemChecked += Borrowedbooks_tbl_ItemChecked;
            // 
            // title_column
            // 
            title_column.Text = "Title";
            title_column.Width = 320;
            // 
            // author_column
            // 
            author_column.Text = "Author";
            author_column.TextAlign = HorizontalAlignment.Center;
            author_column.Width = 320;
            // 
            // borrowDate_column
            // 
            borrowDate_column.Text = "Borrow Date";
            borrowDate_column.TextAlign = HorizontalAlignment.Center;
            borrowDate_column.Width = 200;
            // 
            // dueDate_column
            // 
            dueDate_column.Text = "Due Date";
            dueDate_column.TextAlign = HorizontalAlignment.Center;
            dueDate_column.Width = 200;
            // 
            // bbcountslbl
            // 
            bbcountslbl.AutoSize = true;
            bbcountslbl.Font = new Font("Quicksand Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bbcountslbl.Location = new Point(1028, 83);
            bbcountslbl.Name = "bbcountslbl";
            bbcountslbl.Size = new Size(0, 35);
            bbcountslbl.TabIndex = 4;
            // 
            // Dsplay_borrowedbooks
            // 
            Dsplay_borrowedbooks.AutoSize = true;
            Dsplay_borrowedbooks.Font = new Font("Quicksand Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_borrowedbooks.Location = new Point(794, 80);
            Dsplay_borrowedbooks.Name = "Dsplay_borrowedbooks";
            Dsplay_borrowedbooks.Size = new Size(209, 35);
            Dsplay_borrowedbooks.TabIndex = 2;
            Dsplay_borrowedbooks.Text = "Borrowed Books:";
            // 
            // confirm_btn
            // 
            confirm_btn.BackColor = Color.FromArgb(102, 102, 102);
            confirm_btn.BackgroundColor = Color.FromArgb(102, 102, 102);
            confirm_btn.BorderColor = Color.PaleVioletRed;
            confirm_btn.BorderRadius = 22;
            confirm_btn.BorderSize = 0;
            confirm_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            confirm_btn.FlatAppearance.BorderSize = 0;
            confirm_btn.FlatStyle = FlatStyle.Flat;
            confirm_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_btn.ForeColor = Color.White;
            confirm_btn.Location = new Point(994, 526);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(126, 44);
            confirm_btn.TabIndex = 2;
            confirm_btn.Text = "CONFIRM";
            confirm_btn.TextColor = Color.White;
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // enterId_btn
            // 
            enterId_btn.BackColor = Color.FromArgb(102, 102, 102);
            enterId_btn.BackgroundColor = Color.FromArgb(102, 102, 102);
            enterId_btn.BorderColor = Color.PaleVioletRed;
            enterId_btn.BorderRadius = 22;
            enterId_btn.BorderSize = 0;
            enterId_btn.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            enterId_btn.FlatAppearance.BorderSize = 0;
            enterId_btn.FlatStyle = FlatStyle.Flat;
            enterId_btn.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            enterId_btn.ForeColor = Color.White;
            enterId_btn.Location = new Point(505, 16);
            enterId_btn.Name = "enterId_btn";
            enterId_btn.Size = new Size(118, 43);
            enterId_btn.TabIndex = 5;
            enterId_btn.Text = "ENTER";
            enterId_btn.TextColor = Color.White;
            enterId_btn.UseVisualStyleBackColor = false;
            enterId_btn.Click += enterId_btn_Click;
            // 
            // Dsplay_Id
            // 
            Dsplay_Id.AutoSize = true;
            Dsplay_Id.Font = new Font("Quicksand Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Dsplay_Id.Location = new Point(87, 22);
            Dsplay_Id.Name = "Dsplay_Id";
            Dsplay_Id.Size = new Size(88, 30);
            Dsplay_Id.TabIndex = 6;
            Dsplay_Id.Text = "Input Id:";
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(181, 25);
            id_txtbox.Multiline = true;
            id_txtbox.Name = "id_txtbox";
            id_txtbox.Size = new Size(308, 26);
            id_txtbox.TabIndex = 4;
            id_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // BookReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 570);
            Controls.Add(panel1);
            Name = "BookReturn";
            Text = "BookReturn";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel5;
        private Label Dsplay_borrowedbooks;
        private CustomButton confirm_btn;
        private Label bbcountslbl;
        private ListView borrowedbooks_tbl;
        private ColumnHeader title_column;
        private ColumnHeader author_column;
        private ColumnHeader dueDate_column;
        private Label Dsplay_Id;
        private CustomButton enterId_btn;
        private TextBox id_txtbox;
        private Label namelbl;
        private RoundedPanel panel2;
        private Label detailslbl;
        private ColumnHeader borrowDate_column;
        private Label errorMsg;
    }
}
