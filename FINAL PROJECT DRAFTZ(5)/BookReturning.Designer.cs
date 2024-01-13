namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookReturning
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitButton = new Button();
            label1 = new Label();
            FirstNameTB = new TextBox();
            LastNameTB = new TextBox();
            BookListCB = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            BorrowedLB = new Label();
            ReturnedLB = new Label();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(38, 49, 89);
            SubmitButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.ForeColor = Color.FromArgb(255, 251, 235);
            SubmitButton.Location = new Point(294, 274);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(122, 56);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Demi Cond", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(154, 74);
            label1.Name = "label1";
            label1.Size = new Size(218, 34);
            label1.TabIndex = 9;
            label1.Text = "BOOK RETURNING";
            // 
            // FirstNameTB
            // 
            FirstNameTB.Location = new Point(154, 121);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.PlaceholderText = "First Name";
            FirstNameTB.Size = new Size(203, 23);
            FirstNameTB.TabIndex = 8;
            // 
            // LastNameTB
            // 
            LastNameTB.Location = new Point(363, 121);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.PlaceholderText = "Last Name";
            LastNameTB.Size = new Size(203, 23);
            LastNameTB.TabIndex = 15;
            // 
            // BookListCB
            // 
            BookListCB.AutoCompleteMode = AutoCompleteMode.Append;
            BookListCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            BookListCB.FormattingEnabled = true;
            BookListCB.Location = new Point(154, 150);
            BookListCB.Name = "BookListCB";
            BookListCB.Size = new Size(412, 23);
            BookListCB.TabIndex = 16;
            BookListCB.Text = "Choose Book";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(277, 185);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(289, 23);
            dateTimePicker2.TabIndex = 18;
            // 
            // BorrowedLB
            // 
            BorrowedLB.AutoSize = true;
            BorrowedLB.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowedLB.ForeColor = Color.FromArgb(73, 85, 121);
            BorrowedLB.Location = new Point(154, 185);
            BorrowedLB.Name = "BorrowedLB";
            BorrowedLB.Size = new Size(117, 21);
            BorrowedLB.TabIndex = 19;
            BorrowedLB.Text = "DATE BORROWED:";
            BorrowedLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReturnedLB
            // 
            ReturnedLB.AutoSize = true;
            ReturnedLB.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnedLB.ForeColor = Color.FromArgb(73, 85, 121);
            ReturnedLB.Location = new Point(154, 220);
            ReturnedLB.Name = "ReturnedLB";
            ReturnedLB.Size = new Size(110, 21);
            ReturnedLB.TabIndex = 20;
            ReturnedLB.Text = "DATE RETURNED:";
            ReturnedLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BookReturning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(ReturnedLB);
            Controls.Add(BorrowedLB);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(BookListCB);
            Controls.Add(LastNameTB);
            Controls.Add(SubmitButton);
            Controls.Add(label1);
            Controls.Add(FirstNameTB);
            Name = "BookReturning";
            Size = new Size(1043, 452);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private TextBox BookTitleReturningTextBox;
        private TextBox DateReturnedTextBox;
        private TextBox DateBorrowedTextBox;
        private Label label1;
        private TextBox FirstNameTB;
        private TextBox LastNameTB;
        private ComboBox BookListCB;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label BorrowedLB;
        private Label ReturnedLB;
    }
}
