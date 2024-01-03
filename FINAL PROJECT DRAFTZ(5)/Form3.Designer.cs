namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookReturningForm
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
            NameTextBox = new TextBox();
            label1 = new Label();
            DateBorrowedTextBox = new TextBox();
            DateReturnedTextBox = new TextBox();
            BookTitleReturningTextBox = new TextBox();
            CancelButton = new Button();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 80);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Name";
            NameTextBox.Size = new Size(309, 23);
            NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Demi Cond", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(218, 34);
            label1.TabIndex = 1;
            label1.Text = "BOOK RETURNING";
            // 
            // DateBorrowedTextBox
            // 
            DateBorrowedTextBox.Location = new Point(12, 160);
            DateBorrowedTextBox.Name = "DateBorrowedTextBox";
            DateBorrowedTextBox.PlaceholderText = "Due Date";
            DateBorrowedTextBox.Size = new Size(309, 23);
            DateBorrowedTextBox.TabIndex = 2;
            // 
            // DateReturnedTextBox
            // 
            DateReturnedTextBox.Location = new Point(12, 200);
            DateReturnedTextBox.Name = "DateReturnedTextBox";
            DateReturnedTextBox.PlaceholderText = "Date Returned";
            DateReturnedTextBox.Size = new Size(309, 23);
            DateReturnedTextBox.TabIndex = 4;
            // 
            // BookTitleReturningTextBox
            // 
            BookTitleReturningTextBox.Location = new Point(12, 120);
            BookTitleReturningTextBox.Name = "BookTitleReturningTextBox";
            BookTitleReturningTextBox.PlaceholderText = "Book Title";
            BookTitleReturningTextBox.Size = new Size(309, 23);
            BookTitleReturningTextBox.TabIndex = 5;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(38, 49, 89);
            CancelButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.FromArgb(255, 251, 235);
            CancelButton.Location = new Point(12, 240);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(122, 56);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "CANCEL";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(38, 49, 89);
            SubmitButton.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitButton.ForeColor = Color.FromArgb(255, 251, 235);
            SubmitButton.Location = new Point(199, 240);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(122, 56);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = false;
            // 
            // BookReturningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 235);
            ClientSize = new Size(338, 321);
            Controls.Add(SubmitButton);
            Controls.Add(CancelButton);
            Controls.Add(BookTitleReturningTextBox);
            Controls.Add(DateReturnedTextBox);
            Controls.Add(DateBorrowedTextBox);
            Controls.Add(label1);
            Controls.Add(NameTextBox);
            Name = "BookReturningForm";
            Text = "BOOK RETURNING FORM";
            Load += BookReturningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private Label label1;
        private TextBox DateBorrowedTextBox;
        private TextBox DateReturnedTextBox;
        private TextBox BookTitleReturningTextBox;
        private Button CancelButton;
        private Button SubmitButton;
    }
}