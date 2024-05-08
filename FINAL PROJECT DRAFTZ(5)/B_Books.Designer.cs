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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader7 });
            listView1.GridLines = true;
            listView1.Location = new Point(0, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(1341, 566);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "BookID";
            columnHeader6.Width = 220;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Author";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Borrowers Id";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Borrowers Name";
            columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Borrowed date";
            columnHeader5.Width = 160;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Return Date";
            columnHeader7.Width = 160;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 29);
            textBox1.TabIndex = 1;
            // 
            // B_Books
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Name = "B_Books";
            Size = new Size(1341, 633);
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
    }
}
