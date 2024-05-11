namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class B_Books
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader8, columnHeader9, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Location = new Point(11, 58);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(1101, 528);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ISBN";
            columnHeader6.Width = 220;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Title";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Author";
            columnHeader9.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Borrowers Name";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Borrow Date";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 6;
            columnHeader3.Text = "Return Date";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 5;
            columnHeader4.Text = "Due Date";
            columnHeader4.Width = 170;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(11, 20);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 20);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 233, 228);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(275, 20);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(76, 20);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // B_Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 173, 167);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Margin = new Padding(2);
            Name = "B_Books";
            Size = new Size(1130, 600);
            Load += B_Books_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private TextBox textBox1;
        private Button button1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}
