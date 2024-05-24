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
            AddBookBtn = new Button();
            libraryeditpanel = new Panel();
            addBookDashboard1 = new Controls.AddBookDashboard();
            libraryeditpanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddBookBtn
            // 
            AddBookBtn.BackColor = Color.MistyRose;
            AddBookBtn.Location = new Point(977, 552);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(170, 47);
            AddBookBtn.TabIndex = 1;
            AddBookBtn.Text = "ADD BOOK";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += button1_Click_1;
            // 
            // libraryeditpanel
            // 
            libraryeditpanel.Controls.Add(AddBookBtn);
            libraryeditpanel.Controls.Add(addBookDashboard1);
            libraryeditpanel.Location = new Point(12, 12);
            libraryeditpanel.Name = "libraryeditpanel";
            libraryeditpanel.Size = new Size(1161, 613);
            libraryeditpanel.TabIndex = 5;
            // 
            // addBookDashboard1
            // 
            addBookDashboard1.Location = new Point(111, 28);
            addBookDashboard1.Name = "addBookDashboard1";
            addBookDashboard1.Size = new Size(925, 547);
            addBookDashboard1.TabIndex = 2;
            addBookDashboard1.Load += addBookDashboard1_Load;
            // 
            // BookInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1171, 623);
            Controls.Add(libraryeditpanel);
            Name = "BookInventory";
            Text = "BookInventory";
            Load += BookInventory_Load;
            libraryeditpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button AddBookBtn;
        private Panel libraryeditpanel;
        private Controls.AddBookDashboard addBookDashboard1;
    }
}