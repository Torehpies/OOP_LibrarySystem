﻿namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BorrowerListForm
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
            label1 = new Label();
            panel1 = new Panel();
            LibraryLabel = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Demi Cond", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(192, 39);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 1;
            label1.Text = "BORROWER LIST";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 85, 121);
            panel1.Controls.Add(LibraryLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 342);
            panel1.TabIndex = 2;
            // 
            // LibraryLabel
            // 
            LibraryLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LibraryLabel.ForeColor = Color.FromArgb(255, 251, 235);
            LibraryLabel.Location = new Point(3, 153);
            LibraryLabel.Name = "LibraryLabel";
            LibraryLabel.Size = new Size(144, 23);
            LibraryLabel.TabIndex = 5;
            LibraryLabel.Text = "LIBRARY";
            LibraryLabel.TextAlign = ContentAlignment.TopCenter;
            LibraryLabel.Click += LibraryLabel_Click;
            LibraryLabel.MouseEnter += LibraryLabel_MouseEnter;
            LibraryLabel.MouseLeave += LibraryLabel_MouseLeave;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(38, 49, 89);
            label2.Font = new Font("Cooper Black", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 251, 235);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 73);
            label2.TabIndex = 3;
            label2.Text = "B";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BorrowerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 235);
            ClientSize = new Size(623, 371);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "BorrowerListForm";
            Text = "BORROWER LIST";
            Load += BorrowerListForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label LibraryLabel;
    }
}