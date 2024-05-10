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
            label1 = new Label();
            button1 = new Button();
            AddBookPanelMain = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(497, 49);
            label1.Name = "label1";
            label1.Size = new Size(328, 50);
            label1.TabIndex = 0;
            label1.Text = "BOOK RETURNING";
            // 
            // button1
            // 
            button1.Location = new Point(30, 223);
            button1.Name = "button1";
            button1.Size = new Size(218, 62);
            button1.TabIndex = 1;
            button1.Text = "ADD BOOK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AddBookPanelMain
            // 
            AddBookPanelMain.Location = new Point(266, 128);
            AddBookPanelMain.Name = "AddBookPanelMain";
            AddBookPanelMain.Size = new Size(773, 533);
            AddBookPanelMain.TabIndex = 2;
            AddBookPanelMain.Paint += AddBookPanelMain_Paint;
            // 
            // BookInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 673);
            Controls.Add(AddBookPanelMain);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "BookInventory";
            Text = "BookInventory";
            Load += BookInventory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel AddBookPanelMain;
    }
}