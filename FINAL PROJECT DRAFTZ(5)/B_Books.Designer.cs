﻿namespace FINAL_PROJECT_DRAFTZ_5_
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
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            sortCombo = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.BackgroundImageTiled = true;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader8, columnHeader9, columnHeader1, columnHeader2, columnHeader4, columnHeader3 });
            listView1.GridLines = true;
            listView1.Location = new Point(41, 93);
            listView1.Name = "listView1";
            listView1.Size = new Size(1100, 500);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ISBN";
            columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Title";
            columnHeader8.Width = 195;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Author";
            columnHeader9.Width = 125;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Borrowers Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Borrow Date";
            columnHeader2.Width = 125;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Due Date";
            columnHeader4.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Return Date";
            columnHeader3.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(242, 233, 228);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(542, 41);
            button1.Name = "button1";
            button1.Size = new Size(98, 31);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sortCombo
            // 
            sortCombo.FormattingEnabled = true;
            sortCombo.Items.AddRange(new object[] { "RETURNED BOOKS", "BORROWED BOOKS", "ALL" });
            sortCombo.Location = new Point(374, 41);
            sortCombo.Name = "sortCombo";
            sortCombo.Size = new Size(162, 31);
            sortCombo.TabIndex = 3;
            sortCombo.Text = "Sort by...";
            sortCombo.SelectedIndexChanged += selectedIndexChange;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(41, 41);
            textBox1.MinimumSize = new Size(327, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "(ex. Juan Dela Cruz)";
            textBox1.Size = new Size(327, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // B_Books
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 173, 167);
            Controls.Add(sortCombo);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Font = new Font("Quicksand", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "B_Books";
            Size = new Size(1186, 633);
            Load += B_Books_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private Button button1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ComboBox sortCombo;
        private TextBox textBox1;
        private ColumnHeader columnHeader3;
    }
}
