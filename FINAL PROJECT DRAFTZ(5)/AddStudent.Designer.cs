namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class AddStudent
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
            panel2 = new Panel();
            label8 = new Label();
            type = new TextBox();
            label1 = new Label();
            button2 = new CustomControls.RJControls.CustomButton();
            label4 = new Label();
            label3 = new Label();
            details = new TextBox();
            name = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            cancelBtn = new CustomControls.RJControls.CustomButton();
            label5 = new Label();
            id = new TextBox();
            department = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 78, 105);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 48);
            panel2.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(12, 7);
            label8.Name = "label8";
            label8.Size = new Size(202, 31);
            label8.TabIndex = 18;
            label8.Text = "ADD NEW MEMBER";
            // 
            // type
            // 
            type.BackColor = SystemColors.Window;
            type.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            type.ForeColor = Color.FromArgb(64, 64, 64);
            type.Location = new Point(345, 356);
            type.Margin = new Padding(4);
            type.MinimumSize = new Size(300, 30);
            type.Multiline = true;
            type.Name = "type";
            type.PlaceholderText = "(ex. Student)";
            type.Size = new Size(300, 36);
            type.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 356);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 13;
            label1.Text = "TYPE";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 34, 59);
            button2.BackgroundColor = Color.FromArgb(34, 34, 59);
            button2.BorderColor = Color.PaleVioletRed;
            button2.BorderRadius = 20;
            button2.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(366, 435);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 5;
            button2.Text = "SAVE";
            button2.TextColor = Color.White;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(186, 297);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(137, 28);
            label4.TabIndex = 8;
            label4.Text = "DEPARTMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(251, 173);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 7;
            label3.Text = "NAME";
            // 
            // details
            // 
            details.BackColor = SystemColors.Window;
            details.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            details.ForeColor = Color.FromArgb(64, 64, 64);
            details.Location = new Point(345, 236);
            details.Margin = new Padding(3, 4, 3, 4);
            details.MinimumSize = new Size(300, 30);
            details.Multiline = true;
            details.Name = "details";
            details.PlaceholderText = "(ex. 2A)";
            details.Size = new Size(300, 36);
            details.TabIndex = 2;
            // 
            // name
            // 
            name.BackColor = SystemColors.Window;
            name.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(64, 64, 64);
            name.Location = new Point(345, 173);
            name.Margin = new Padding(4);
            name.MinimumSize = new Size(300, 30);
            name.Multiline = true;
            name.Name = "name";
            name.PlaceholderText = "(ex. Seiffer)";
            name.Size = new Size(300, 36);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(236, 236);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 3;
            label2.Text = "SECTION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 213, 206);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(id);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(type);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(details);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(department);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 559);
            panel1.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.BackgroundColor = Color.Gainsboro;
            cancelBtn.BorderColor = Color.FromArgb(34, 34, 59);
            cancelBtn.BorderRadius = 20;
            cancelBtn.BorderSize = 2;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Quicksand", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.FromArgb(34, 34, 59);
            cancelBtn.Location = new Point(366, 476);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 40);
            cancelBtn.TabIndex = 22;
            cancelBtn.Text = "CANCEL";
            cancelBtn.TextColor = Color.FromArgb(34, 34, 59);
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(285, 115);
            label5.Name = "label5";
            label5.Size = new Size(31, 28);
            label5.TabIndex = 21;
            label5.Text = "ID";
            // 
            // id
            // 
            id.BackColor = SystemColors.Window;
            id.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id.ForeColor = Color.FromArgb(64, 64, 64);
            id.Location = new Point(345, 115);
            id.Margin = new Padding(4);
            id.MinimumSize = new Size(300, 30);
            id.Multiline = true;
            id.Name = "id";
            id.PlaceholderText = "(ex. 20220456-N)";
            id.Size = new Size(300, 36);
            id.TabIndex = 0;
            // 
            // department
            // 
            department.BackColor = SystemColors.Window;
            department.Font = new Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point);
            department.ForeColor = Color.FromArgb(64, 64, 64);
            department.Location = new Point(345, 297);
            department.Margin = new Padding(4);
            department.MinimumSize = new Size(300, 30);
            department.Multiline = true;
            department.Name = "department";
            department.PlaceholderText = "(ex. BSCS)";
            department.Size = new Size(300, 36);
            department.TabIndex = 3;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddStudent";
            Size = new Size(883, 559);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private TextBox type;
        private Label label1;
        private CustomControls.RJControls.CustomButton button2;
        private Label label4;
        private Label label3;
        private TextBox details;
        private TextBox name;
        private Label label2;
        private Panel panel1;
        private TextBox department;
        private Label label5;
        private TextBox id;
        private CustomControls.RJControls.CustomButton cancelBtn;
    }
}
