namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class StudentFillUp
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
            addStudent1 = new AddStudent();
            SuspendLayout();
            // 
            // addStudent1
            // 
            addStudent1.Location = new Point(0, -1);
            addStudent1.Name = "addStudent1";
            addStudent1.Size = new Size(883, 559);
            addStudent1.TabIndex = 0;
            // 
            // StudentFillUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 233, 228);
            ClientSize = new Size(883, 559);
            Controls.Add(addStudent1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentFillUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentFillUp";
            ResumeLayout(false);
        }

        #endregion

        private AddStudent addStudent1;
    }
}