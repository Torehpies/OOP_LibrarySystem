namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BorrowedList
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
            b_Books1 = new B_Books();
            SuspendLayout();
            // 
            // b_Books1
            // 
            b_Books1.BackColor = Color.FromArgb(201, 173, 167);
            b_Books1.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_Books1.Location = new Point(0, 0);
            b_Books1.Name = "b_Books1";
            b_Books1.Size = new Size(1130, 600);
            b_Books1.TabIndex = 0;
            // 
            // BorrowedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 600);
            Controls.Add(b_Books1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowedList";
            Text = "BorrowedList";
            ResumeLayout(false);
        }

        #endregion

        private B_Books b_Books1;
    }
}