namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BookInventory
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
            libraryeditpanel = new Panel();
            AddBookBtn = new CustomControls.RJControls.CustomButton();
            addBookDashboard1 = new Controls.AddBookDashboard();
            libraryeditpanel.SuspendLayout();
            SuspendLayout();
            // 
            // libraryeditpanel
            // 
            libraryeditpanel.BackColor = Color.DarkGray;
            libraryeditpanel.Controls.Add(addBookDashboard1);
            libraryeditpanel.Controls.Add(AddBookBtn);
            libraryeditpanel.Location = new Point(-2, -2);
            libraryeditpanel.Name = "libraryeditpanel";
            libraryeditpanel.Size = new Size(1186, 609);
            libraryeditpanel.TabIndex = 5;
            // 
            // AddBookBtn
            // 
            AddBookBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBookBtn.BackColor = Color.FromArgb(34, 34, 59);
            AddBookBtn.BackgroundColor = Color.FromArgb(34, 34, 59);
            AddBookBtn.BorderColor = Color.PaleVioletRed;
            AddBookBtn.BorderRadius = 38;
            AddBookBtn.BorderSize = 0;
            AddBookBtn.Cursor = Cursors.Hand;
            AddBookBtn.FlatAppearance.BorderColor = Color.Black;
            AddBookBtn.FlatAppearance.BorderSize = 0;
            AddBookBtn.FlatStyle = FlatStyle.Flat;
            AddBookBtn.Font = new Font("Quicksand SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookBtn.ForeColor = Color.White;
            AddBookBtn.Image = Properties.Resources.plus_icon__1_;
            AddBookBtn.Location = new Point(1081, 485);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(76, 76);
            AddBookBtn.TabIndex = 9;
            AddBookBtn.TextColor = Color.White;
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += button1_Click_1;
            // 
            // addBookDashboard1
            // 
            addBookDashboard1.BackColor = Color.Transparent;
            addBookDashboard1.Location = new Point(151, 23);
            addBookDashboard1.Name = "addBookDashboard1";
            addBookDashboard1.Size = new Size(883, 559);
            addBookDashboard1.TabIndex = 2;
            addBookDashboard1.Visible = false;
            addBookDashboard1.Load += addBookDashboard1_Load;
            // 
            // BookInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1186, 609);
            Controls.Add(libraryeditpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookInventory";
            Text = "BookInventory";
            Load += BookInventory_Load;
            libraryeditpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel libraryeditpanel;
        private Controls.AddBookDashboard addBookDashboard1;
        private CustomControls.RJControls.CustomButton AddBookBtn;
    }
}