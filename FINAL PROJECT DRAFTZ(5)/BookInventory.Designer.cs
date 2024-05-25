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
            AddBookPanelMain = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddBookBtn
            // 
            AddBookBtn.BackColor = Color.MistyRose;
            AddBookBtn.Location = new Point(32, 63);
            AddBookBtn.Margin = new Padding(3, 4, 3, 4);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(249, 83);
            AddBookBtn.TabIndex = 1;
            AddBookBtn.Text = "ADD BOOK";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += button1_Click_1;
            // 
            // AddBookPanelMain
            // 
            AddBookPanelMain.BackColor = Color.Transparent;
            AddBookPanelMain.Location = new Point(336, 116);
            AddBookPanelMain.Margin = new Padding(3, 4, 3, 4);
            AddBookPanelMain.Name = "AddBookPanelMain";
            AddBookPanelMain.Size = new Size(883, 648);
            AddBookPanelMain.TabIndex = 2;
            AddBookPanelMain.Paint += AddBookPanelMain_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddBookBtn);
            panel1.Location = new Point(14, 116);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 648);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(589, 12);
            label1.Name = "label1";
            label1.Size = new Size(411, 62);
            label1.TabIndex = 0;
            label1.Text = "BOOK INVENTORY";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 92);
            panel2.TabIndex = 4;
            // 
            // BookInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1255, 769);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(AddBookPanelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookInventory";
            Text = "BookInventory";
            Load += BookInventory_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddBookBtn;
        private Panel AddBookPanelMain;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}