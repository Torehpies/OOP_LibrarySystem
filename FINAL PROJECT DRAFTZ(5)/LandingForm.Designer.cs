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
            ReturningLabel = new Button();
            LibraryLabel = new Button();
            BorrowerListLabel = new Button();
            label1 = new Label();
            contentPanel = new Panel();
            libraryPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 85, 121);
            panel1.Controls.Add(ReturningLabel);
            panel1.Controls.Add(LibraryLabel);
            panel1.Controls.Add(BorrowerListLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 720);
            panel1.TabIndex = 1;
            // 
            // ReturningLabel
            // 
            ReturningLabel.FlatAppearance.BorderSize = 0;
            ReturningLabel.FlatStyle = FlatStyle.Flat;
            ReturningLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturningLabel.ForeColor = Color.FromArgb(255, 251, 235);
            ReturningLabel.Location = new Point(3, 263);
            ReturningLabel.Name = "ReturningLabel";
            ReturningLabel.Size = new Size(144, 32);
            ReturningLabel.TabIndex = 4;
            ReturningLabel.Text = "BOOK RETURNING";
            ReturningLabel.TextAlign = ContentAlignment.TopCenter;
            ReturningLabel.Click += ReturningLabel_Click;
            // 
            // LibraryLabel
            // 
            LibraryLabel.FlatAppearance.BorderSize = 0;
            LibraryLabel.FlatStyle = FlatStyle.Flat;
            LibraryLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LibraryLabel.ForeColor = Color.FromArgb(255, 251, 235);
            LibraryLabel.Location = new Point(3, 193);
            LibraryLabel.Name = "LibraryLabel";
            LibraryLabel.Size = new Size(144, 29);
            LibraryLabel.TabIndex = 3;
            LibraryLabel.Text = "LIBRARY";
            LibraryLabel.TextAlign = ContentAlignment.TopCenter;
            LibraryLabel.Click += LibraryLabel_Click;
            // 
            // BorrowerListLabel
            // 
            BorrowerListLabel.FlatAppearance.BorderSize = 0;
            BorrowerListLabel.FlatStyle = FlatStyle.Flat;
            BorrowerListLabel.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowerListLabel.ForeColor = Color.FromArgb(255, 251, 235);
            BorrowerListLabel.Location = new Point(3, 228);
            BorrowerListLabel.Name = "BorrowerListLabel";
            BorrowerListLabel.Size = new Size(144, 29);
            BorrowerListLabel.TabIndex = 2;
            BorrowerListLabel.Text = "BORROWER LIST";
            BorrowerListLabel.TextAlign = ContentAlignment.TopCenter;
            BorrowerListLabel.Click += BorrowerListLabel_Click;
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
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.Ivory;
            contentPanel.Controls.Add(libraryPanel);
            contentPanel.Location = new Point(150, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.Size = new Size(930, 720);
            contentPanel.TabIndex = 2;
            // 
            // libraryPanel
            // 
            libraryPanel.AutoScroll = true;
            libraryPanel.BackColor = Color.Transparent;
            libraryPanel.Dock = DockStyle.Fill;
            libraryPanel.FlowDirection = FlowDirection.TopDown;
            libraryPanel.Location = new Point(20, 20);
            libraryPanel.Margin = new Padding(0);
            libraryPanel.Name = "libraryPanel";
            libraryPanel.Size = new Size(890, 680);
            libraryPanel.TabIndex = 0;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Ivory;
            ClientSize = new Size(1080, 720);
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(30, 40);
            MinimumSize = new Size(1080, 720);
            Name = "LandingForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Form7";
            panel1.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ReturningLabel;
        private Button LibraryLabel;
        private Button BorrowerListLabel;
        private Label label1;
        private Panel contentPanel;
        private FlowLayoutPanel libraryPanel;
    }
}