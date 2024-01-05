namespace FINAL_PROJECT_DRAFTZ_5_
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdmitTypePanel = new Panel();
            TeacherRadioButton = new RadioButton();
            StudentRadioButton = new RadioButton();
            label1 = new Label();
            StudentLoginPanel = new Panel();
            StudentLoginButton = new Button();
            StudentSectionTxtBox = new TextBox();
            StudentYearTxtBox = new TextBox();
            StudentNameTxtBox = new TextBox();
            StudentIDTxtBox = new TextBox();
            label2 = new Label();
            TeacherLoginPanel = new Panel();
            TeacherLoginButton = new Button();
            TeacherDepartmentTxtBox = new TextBox();
            TeacherNameTxtBox = new TextBox();
            TeacherIDTxtBox = new TextBox();
            label3 = new Label();
            AdmitTypePanel.SuspendLayout();
            StudentLoginPanel.SuspendLayout();
            TeacherLoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdmitTypePanel
            // 
            AdmitTypePanel.BorderStyle = BorderStyle.FixedSingle;
            AdmitTypePanel.Controls.Add(TeacherRadioButton);
            AdmitTypePanel.Controls.Add(StudentRadioButton);
            AdmitTypePanel.Controls.Add(label1);
            AdmitTypePanel.Location = new Point(12, 12);
            AdmitTypePanel.Name = "AdmitTypePanel";
            AdmitTypePanel.Size = new Size(250, 100);
            AdmitTypePanel.TabIndex = 0;
            // 
            // TeacherRadioButton
            // 
            TeacherRadioButton.AutoSize = true;
            TeacherRadioButton.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherRadioButton.ForeColor = Color.FromArgb(73, 85, 121);
            TeacherRadioButton.Location = new Point(130, 52);
            TeacherRadioButton.Name = "TeacherRadioButton";
            TeacherRadioButton.Size = new Size(102, 29);
            TeacherRadioButton.TabIndex = 2;
            TeacherRadioButton.TabStop = true;
            TeacherRadioButton.Text = "TEACHER";
            TeacherRadioButton.UseVisualStyleBackColor = true;
            TeacherRadioButton.CheckedChanged += TeacherRadioButton_CheckedChanged;
            // 
            // StudentRadioButton
            // 
            StudentRadioButton.AutoSize = true;
            StudentRadioButton.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StudentRadioButton.ForeColor = Color.FromArgb(73, 85, 121);
            StudentRadioButton.Location = new Point(15, 52);
            StudentRadioButton.Name = "StudentRadioButton";
            StudentRadioButton.Size = new Size(100, 29);
            StudentRadioButton.TabIndex = 1;
            StudentRadioButton.TabStop = true;
            StudentRadioButton.Text = "STUDENT";
            StudentRadioButton.UseVisualStyleBackColor = true;
            StudentRadioButton.CheckedChanged += StudentRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Location = new Point(33, 12);
            label1.Name = "label1";
            label1.Size = new Size(180, 23);
            label1.TabIndex = 1;
            label1.Text = "CHOOSE ADMIT TYPE.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // StudentLoginPanel
            // 
            StudentLoginPanel.BorderStyle = BorderStyle.FixedSingle;
            StudentLoginPanel.Controls.Add(StudentLoginButton);
            StudentLoginPanel.Controls.Add(StudentSectionTxtBox);
            StudentLoginPanel.Controls.Add(StudentYearTxtBox);
            StudentLoginPanel.Controls.Add(StudentNameTxtBox);
            StudentLoginPanel.Controls.Add(StudentIDTxtBox);
            StudentLoginPanel.Controls.Add(label2);
            StudentLoginPanel.Location = new Point(12, 118);
            StudentLoginPanel.Name = "StudentLoginPanel";
            StudentLoginPanel.Size = new Size(250, 208);
            StudentLoginPanel.TabIndex = 1;
            // 
            // StudentLoginButton
            // 
            StudentLoginButton.BackColor = Color.FromArgb(38, 49, 89);
            StudentLoginButton.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StudentLoginButton.ForeColor = Color.FromArgb(255, 251, 235);
            StudentLoginButton.Location = new Point(35, 167);
            StudentLoginButton.Name = "StudentLoginButton";
            StudentLoginButton.Size = new Size(179, 26);
            StudentLoginButton.TabIndex = 2;
            StudentLoginButton.Text = "LOGIN";
            StudentLoginButton.UseVisualStyleBackColor = false;
            StudentLoginButton.Click += StudentLoginButton_Click;
            // 
            // StudentSectionTxtBox
            // 
            StudentSectionTxtBox.Location = new Point(16, 138);
            StudentSectionTxtBox.Name = "StudentSectionTxtBox";
            StudentSectionTxtBox.PlaceholderText = "Section";
            StudentSectionTxtBox.Size = new Size(217, 23);
            StudentSectionTxtBox.TabIndex = 6;
            // 
            // StudentYearTxtBox
            // 
            StudentYearTxtBox.Location = new Point(16, 109);
            StudentYearTxtBox.Name = "StudentYearTxtBox";
            StudentYearTxtBox.PlaceholderText = "Year";
            StudentYearTxtBox.Size = new Size(217, 23);
            StudentYearTxtBox.TabIndex = 5;
            // 
            // StudentNameTxtBox
            // 
            StudentNameTxtBox.Location = new Point(16, 80);
            StudentNameTxtBox.Name = "StudentNameTxtBox";
            StudentNameTxtBox.PlaceholderText = "Name";
            StudentNameTxtBox.Size = new Size(217, 23);
            StudentNameTxtBox.TabIndex = 4;
            // 
            // StudentIDTxtBox
            // 
            StudentIDTxtBox.Location = new Point(16, 51);
            StudentIDTxtBox.Name = "StudentIDTxtBox";
            StudentIDTxtBox.PlaceholderText = "Student ID";
            StudentIDTxtBox.Size = new Size(217, 23);
            StudentIDTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 85, 121);
            label2.Location = new Point(34, 9);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.TabIndex = 3;
            label2.Text = "MEMBER LOGIN";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // TeacherLoginPanel
            // 
            TeacherLoginPanel.BorderStyle = BorderStyle.FixedSingle;
            TeacherLoginPanel.Controls.Add(TeacherLoginButton);
            TeacherLoginPanel.Controls.Add(TeacherDepartmentTxtBox);
            TeacherLoginPanel.Controls.Add(TeacherNameTxtBox);
            TeacherLoginPanel.Controls.Add(TeacherIDTxtBox);
            TeacherLoginPanel.Controls.Add(label3);
            TeacherLoginPanel.Location = new Point(12, 118);
            TeacherLoginPanel.Name = "TeacherLoginPanel";
            TeacherLoginPanel.Size = new Size(250, 194);
            TeacherLoginPanel.TabIndex = 7;
            // 
            // TeacherLoginButton
            // 
            TeacherLoginButton.BackColor = Color.FromArgb(38, 49, 89);
            TeacherLoginButton.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherLoginButton.ForeColor = Color.FromArgb(255, 251, 235);
            TeacherLoginButton.Location = new Point(35, 138);
            TeacherLoginButton.Name = "TeacherLoginButton";
            TeacherLoginButton.Size = new Size(179, 26);
            TeacherLoginButton.TabIndex = 7;
            TeacherLoginButton.Text = "LOGIN";
            TeacherLoginButton.UseVisualStyleBackColor = false;
            TeacherLoginButton.Click += TeacherLoginButton_Click;
            // 
            // TeacherDepartmentTxtBox
            // 
            TeacherDepartmentTxtBox.Location = new Point(16, 109);
            TeacherDepartmentTxtBox.Name = "TeacherDepartmentTxtBox";
            TeacherDepartmentTxtBox.PlaceholderText = "Department";
            TeacherDepartmentTxtBox.Size = new Size(217, 23);
            TeacherDepartmentTxtBox.TabIndex = 5;
            // 
            // TeacherNameTxtBox
            // 
            TeacherNameTxtBox.Location = new Point(16, 80);
            TeacherNameTxtBox.Name = "TeacherNameTxtBox";
            TeacherNameTxtBox.PlaceholderText = "Name";
            TeacherNameTxtBox.Size = new Size(217, 23);
            TeacherNameTxtBox.TabIndex = 4;
            // 
            // TeacherIDTxtBox
            // 
            TeacherIDTxtBox.Location = new Point(16, 51);
            TeacherIDTxtBox.Name = "TeacherIDTxtBox";
            TeacherIDTxtBox.PlaceholderText = "Employee ID";
            TeacherIDTxtBox.Size = new Size(217, 23);
            TeacherIDTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(73, 85, 121);
            label3.Location = new Point(34, 9);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 3;
            label3.Text = "MEMBER LOGIN";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(283, 338);
            Controls.Add(TeacherLoginPanel);
            Controls.Add(StudentLoginPanel);
            Controls.Add(AdmitTypePanel);
            Name = "FormLogin";
            Text = "LOGIN";
            Load += FormLogin_Load;
            AdmitTypePanel.ResumeLayout(false);
            AdmitTypePanel.PerformLayout();
            StudentLoginPanel.ResumeLayout(false);
            StudentLoginPanel.PerformLayout();
            TeacherLoginPanel.ResumeLayout(false);
            TeacherLoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AdmitTypePanel;
        private RadioButton TeacherRadioButton;
        private RadioButton StudentRadioButton;
        private Label label1;
        private Panel StudentLoginPanel;
        private TextBox StudentYearTxtBox;
        private TextBox StudentNameTxtBox;
        private TextBox StudentIDTxtBox;
        private Label label2;
        private TextBox StudentSectionTxtBox;
        private Button StudentLoginButton;
        private Panel TeacherLoginPanel;
        private TextBox TeacherDepartmentTxtBox;
        private TextBox TeacherNameTxtBox;
        private TextBox TeacherIDTxtBox;
        private Label label3;
        private Button TeacherLoginButton;
    }
}