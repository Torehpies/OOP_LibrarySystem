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
            users = new ListView();
            title_column = new ColumnHeader();
            author_column = new ColumnHeader();
            quantity = new ColumnHeader();
            borrowDate_column = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // users
            // 
            users.CheckBoxes = true;
            users.Columns.AddRange(new ColumnHeader[] { title_column, author_column, quantity, borrowDate_column });
            users.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            users.FullRowSelect = true;
            users.GridLines = true;
            users.Location = new Point(132, 118);
            users.Name = "users";
            users.Size = new Size(880, 348);
            users.TabIndex = 2;
            users.UseCompatibleStateImageBehavior = false;
            users.View = View.Details;
            users.SelectedIndexChanged += borrowedbooks_tbl_SelectedIndexChanged;
            // 
            // title_column
            // 
            title_column.Text = "Username";
            title_column.Width = 320;
            // 
            // author_column
            // 
            author_column.Text = "Last Login";
            author_column.TextAlign = HorizontalAlignment.Center;
            author_column.Width = 320;
            // 
            // quantity
            // 
            quantity.Text = "Created";
            quantity.TextAlign = HorizontalAlignment.Center;
            quantity.Width = 100;
            // 
            // borrowDate_column
            // 
            borrowDate_column.Text = "Type";
            borrowDate_column.TextAlign = HorizontalAlignment.Center;
            borrowDate_column.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(132, 472);
            button1.Name = "button1";
            button1.Size = new Size(149, 61);
            button1.TabIndex = 3;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // AccountManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(1170, 570);
            Controls.Add(button1);
            Controls.Add(users);
            Name = "AccountManager";
            Text = "AccountManager";
            ResumeLayout(false);
        }

        #endregion

        private ListView users;
        private ColumnHeader title_column;
        private ColumnHeader author_column;
        private ColumnHeader quantity;
        private ColumnHeader borrowDate_column;
        private Button button1;
    }
}