namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class LandingForm
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
            ReturningLabel = new Label();
            LibraryLabel = new Label();
            BorrowerListLabel = new Label();
            label1 = new Label();
            bookPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(73, 85, 121);
            panel1.Controls.Add(ReturningLabel);
            panel1.Controls.Add(LibraryLabel);
            panel1.Controls.Add(BorrowerListLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 428);
            panel1.TabIndex = 1;
            // 
            // ReturningLabel
            // 
            ReturningLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturningLabel.ForeColor = Color.FromArgb(255, 251, 235);
            ReturningLabel.Location = new Point(3, 263);
            ReturningLabel.Name = "ReturningLabel";
            ReturningLabel.Size = new Size(144, 21);
            ReturningLabel.TabIndex = 4;
            ReturningLabel.Text = "BOOK RETURNING";
            ReturningLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LibraryLabel
            // 
            LibraryLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LibraryLabel.ForeColor = Color.White;
            LibraryLabel.Location = new Point(3, 193);
            LibraryLabel.Name = "LibraryLabel";
            LibraryLabel.Size = new Size(144, 20);
            LibraryLabel.TabIndex = 3;
            LibraryLabel.Text = "LIBRARY";
            LibraryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BorrowerListLabel
            // 
            BorrowerListLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowerListLabel.ForeColor = Color.FromArgb(255, 251, 235);
            BorrowerListLabel.Location = new Point(3, 228);
            BorrowerListLabel.Name = "BorrowerListLabel";
            BorrowerListLabel.Size = new Size(144, 21);
            BorrowerListLabel.TabIndex = 2;
            BorrowerListLabel.Text = "BORROWER LIST";
            BorrowerListLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(38, 49, 89);
            label1.Font = new Font("Cooper Black", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 251, 235);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 73);
            label1.TabIndex = 0;
            label1.Text = "B";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookPanel
            // 
            bookPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookPanel.BackColor = Color.Olive;
            bookPanel.Location = new Point(166, 12);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new Size(633, 434);
            bookPanel.TabIndex = 2;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(bookPanel);
            Controls.Add(panel1);
            Name = "LandingForm";
            Text = "Form7";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label ReturningLabel;
        private Label LibraryLabel;
        private Label BorrowerListLabel;
        private Label label1;
        private Panel bookPanel;
    }
}