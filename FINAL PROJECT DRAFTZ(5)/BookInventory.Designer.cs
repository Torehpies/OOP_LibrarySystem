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
            button1 = new Button();
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
            AddBookBtn.Location = new Point(28, 47);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(218, 62);
            AddBookBtn.TabIndex = 1;
            AddBookBtn.Text = "ADD BOOK";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += button1_Click_1;
            // 
            // AddBookPanelMain
            // 
            AddBookPanelMain.BackColor = Color.Transparent;
            AddBookPanelMain.Location = new Point(294, 87);
            AddBookPanelMain.Name = "AddBookPanelMain";
            AddBookPanelMain.Size = new Size(773, 486);
            AddBookPanelMain.TabIndex = 2;
            AddBookPanelMain.Paint += AddBookPanelMain_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(102, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(AddBookBtn);
            panel1.Location = new Point(12, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 486);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(515, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 50);
            label1.TabIndex = 0;
            label1.Text = "BOOK INVENTORY";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1074, 69);
            panel2.TabIndex = 4;
            // 
            // BookInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1098, 577);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(AddBookPanelMain);
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
        private Button button1;
    }
}