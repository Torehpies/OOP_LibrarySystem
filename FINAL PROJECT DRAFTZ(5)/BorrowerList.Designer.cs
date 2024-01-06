namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class BorrowerList
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
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "", "1234", "cs" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "", "aaa", "aaa", "" }, -1);
            tabPage2 = new TabPage();
            TeacherListView = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            tabPage1 = new TabPage();
            StudentListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TeacherListView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(448, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teacher Borrower List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TeacherListView
            // 
            TeacherListView.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            TeacherListView.FullRowSelect = true;
            TeacherListView.GridLines = true;
            TeacherListView.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            TeacherListView.Location = new Point(3, 0);
            TeacherListView.Name = "TeacherListView";
            TeacherListView.Size = new Size(439, 333);
            TeacherListView.TabIndex = 4;
            TeacherListView.UseCompatibleStateImageBehavior = false;
            TeacherListView.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Name";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Employee ID";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Department";
            columnHeader7.Width = 100;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(StudentListView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(448, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student Borrower List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // StudentListView
            // 
            StudentListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            StudentListView.FullRowSelect = true;
            StudentListView.GridLines = true;
            StudentListView.Location = new Point(3, 3);
            StudentListView.Name = "StudentListView";
            StudentListView.Size = new Size(442, 337);
            StudentListView.TabIndex = 3;
            StudentListView.UseCompatibleStateImageBehavior = false;
            StudentListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Student ID";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Year Level";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Section";
            columnHeader4.Width = 100;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(456, 365);
            tabControl1.TabIndex = 2;
            // 
            // BorrowerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "BorrowerList";
            Size = new Size(748, 503);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private ListView TeacherListView;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TabPage tabPage1;
        private ListView StudentListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TabControl tabControl1;
    }
}
