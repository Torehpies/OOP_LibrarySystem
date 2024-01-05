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
            CancelButton = new Button();
            BookTitleReturningTextBox = new TextBox();
            DateReturnedTextBox = new TextBox();
            DateBorrowedTextBox = new TextBox();
            label1 = new Label();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(38, 49, 89);
            SubmitButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.ForeColor = Color.FromArgb(255, 251, 235);
            SubmitButton.Location = new Point(341, 281);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(122, 56);
            SubmitButton.TabIndex = 14;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(38, 49, 89);
            CancelButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.FromArgb(255, 251, 235);
            CancelButton.Location = new Point(154, 281);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(122, 56);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "CANCEL";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // BookTitleReturningTextBox
            // 
            BookTitleReturningTextBox.Location = new Point(154, 161);
            BookTitleReturningTextBox.Name = "BookTitleReturningTextBox";
            BookTitleReturningTextBox.PlaceholderText = "Book Title";
            BookTitleReturningTextBox.Size = new Size(309, 23);
            BookTitleReturningTextBox.TabIndex = 12;
            // 
            // DateReturnedTextBox
            // 
            DateReturnedTextBox.Location = new Point(154, 241);
            DateReturnedTextBox.Name = "DateReturnedTextBox";
            DateReturnedTextBox.PlaceholderText = "Date Returned";
            DateReturnedTextBox.Size = new Size(309, 23);
            DateReturnedTextBox.TabIndex = 11;
            // 
            // DateBorrowedTextBox
            // 
            DateBorrowedTextBox.Location = new Point(154, 201);
            DateBorrowedTextBox.Name = "DateBorrowedTextBox";
            DateBorrowedTextBox.PlaceholderText = "Due Date";
            DateBorrowedTextBox.Size = new Size(309, 23);
            DateBorrowedTextBox.TabIndex = 10;
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
            // NameTextBox
            // 
            NameTextBox.Location = new Point(154, 121);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Name";
            NameTextBox.Size = new Size(309, 23);
            NameTextBox.TabIndex = 8;
            // 
            // BookReturning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(SubmitButton);
            Controls.Add(CancelButton);
            Controls.Add(BookTitleReturningTextBox);
            Controls.Add(DateReturnedTextBox);
            Controls.Add(DateBorrowedTextBox);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Name = "BookReturning";
            Size = new Size(617, 411);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button CancelButton;
        private TextBox BookTitleReturningTextBox;
        private TextBox DateReturnedTextBox;
        private TextBox DateBorrowedTextBox;
        private Label label1;
        private TextBox NameTextBox;
    }
}
