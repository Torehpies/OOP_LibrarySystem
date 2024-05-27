namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class AccountManager
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
            borrowedbooks_tbl = new ListView();
            title_column = new ColumnHeader();
            author_column = new ColumnHeader();
            quantity = new ColumnHeader();
            borrowDate_column = new ColumnHeader();
            dueDate_column = new ColumnHeader();
            confirm_btn = new CustomControls.RJControls.CustomButton();
            customButton1 = new CustomControls.RJControls.CustomButton();
            SuspendLayout();
            // 
            // borrowedbooks_tbl
            // 
            borrowedbooks_tbl.CheckBoxes = true;
            borrowedbooks_tbl.Columns.AddRange(new ColumnHeader[] { title_column, author_column, quantity, borrowDate_column, dueDate_column });
            borrowedbooks_tbl.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            borrowedbooks_tbl.FullRowSelect = true;
            borrowedbooks_tbl.GridLines = true;
            borrowedbooks_tbl.Location = new Point(63, 109);
            borrowedbooks_tbl.Name = "borrowedbooks_tbl";
            borrowedbooks_tbl.Size = new Size(1044, 348);
            borrowedbooks_tbl.TabIndex = 4;
            borrowedbooks_tbl.UseCompatibleStateImageBehavior = false;
            borrowedbooks_tbl.View = View.Details;
            // 
            // title_column
            // 
            title_column.Text = "ID";
            title_column.Width = 320;
            // 
            // author_column
            // 
            author_column.Text = "Username";
            author_column.TextAlign = HorizontalAlignment.Center;
            author_column.Width = 320;
            // 
            // quantity
            // 
            quantity.Text = "Last Login";
            quantity.TextAlign = HorizontalAlignment.Center;
            quantity.Width = 100;
            // 
            // borrowDate_column
            // 
            borrowDate_column.Text = "Created";
            borrowDate_column.TextAlign = HorizontalAlignment.Center;
            borrowDate_column.Width = 150;
            // 
            // dueDate_column
            // 
            dueDate_column.Text = "Type";
            dueDate_column.TextAlign = HorizontalAlignment.Center;
            dueDate_column.Width = 150;
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
            confirm_btn.Location = new Point(981, 471);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(126, 44);
            confirm_btn.TabIndex = 8;
            confirm_btn.Text = "Remove";
            confirm_btn.TextColor = Color.White;
            confirm_btn.UseVisualStyleBackColor = false;
            confirm_btn.Click += confirm_btn_Click_1;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(102, 102, 102);
            customButton1.BackgroundColor = Color.FromArgb(102, 102, 102);
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 22;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderColor = Color.FromArgb(242, 233, 228);
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(63, 471);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(158, 44);
            customButton1.TabIndex = 9;
            customButton1.Text = "Import Students";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(1170, 570);
            Controls.Add(customButton1);
            Controls.Add(confirm_btn);
            Controls.Add(borrowedbooks_tbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountManager";
            Text = "AccountManager";
            ResumeLayout(false);
        }

        #endregion
        private ListView borrowedbooks_tbl;
        private ColumnHeader title_column;
        private ColumnHeader author_column;
        private ColumnHeader quantity;
        private ColumnHeader borrowDate_column;
        private ColumnHeader dueDate_column;
        private CustomControls.RJControls.CustomButton confirm_btn;
        private CustomControls.RJControls.CustomButton customButton1;
    }
}