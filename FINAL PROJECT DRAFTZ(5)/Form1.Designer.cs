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
            StudentLoginbtn = new Button();
            StudentSectiontxtBox = new TextBox();
            StudentYeartxtBox = new TextBox();
            StudentNametxtBox = new TextBox();
            StudentIDtxtBox = new TextBox();
            label2 = new Label();
            TeacherLoginPanel = new Panel();
            TeacherLoginbtn = new Button();
            TeacherDepartmenttxtBox = new TextBox();
            TeacherNametxtBox = new TextBox();
            TeacherIDtxtBox = new TextBox();
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
            StudentLoginPanel.Controls.Add(StudentLoginbtn);
            StudentLoginPanel.Controls.Add(StudentSectiontxtBox);
            StudentLoginPanel.Controls.Add(StudentYeartxtBox);
            StudentLoginPanel.Controls.Add(StudentNametxtBox);
            StudentLoginPanel.Controls.Add(StudentIDtxtBox);
            StudentLoginPanel.Controls.Add(label2);
            StudentLoginPanel.Location = new Point(12, 118);
            StudentLoginPanel.Name = "StudentLoginPanel";
            StudentLoginPanel.Size = new Size(250, 208);
            StudentLoginPanel.TabIndex = 1;
            // 
            // StudentLoginbtn
            // 
            StudentLoginbtn.BackColor = Color.FromArgb(38, 49, 89);
            StudentLoginbtn.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StudentLoginbtn.ForeColor = Color.FromArgb(255, 251, 235);
            StudentLoginbtn.Location = new Point(35, 167);
            StudentLoginbtn.Name = "StudentLoginbtn";
            StudentLoginbtn.Size = new Size(179, 26);
            StudentLoginbtn.TabIndex = 2;
            StudentLoginbtn.Text = "LOGIN";
            StudentLoginbtn.UseVisualStyleBackColor = false;
            // 
            // StudentSectiontxtBox
            // 
            StudentSectiontxtBox.Location = new Point(16, 138);
            StudentSectiontxtBox.Name = "StudentSectiontxtBox";
            StudentSectiontxtBox.PlaceholderText = "Section";
            StudentSectiontxtBox.Size = new Size(217, 23);
            StudentSectiontxtBox.TabIndex = 6;
            // 
            // StudentYeartxtBox
            // 
            StudentYeartxtBox.Location = new Point(16, 109);
            StudentYeartxtBox.Name = "StudentYeartxtBox";
            StudentYeartxtBox.PlaceholderText = "Year";
            StudentYeartxtBox.Size = new Size(217, 23);
            StudentYeartxtBox.TabIndex = 5;
            // 
            // StudentNametxtBox
            // 
            StudentNametxtBox.Location = new Point(16, 80);
            StudentNametxtBox.Name = "StudentNametxtBox";
            StudentNametxtBox.PlaceholderText = "Name";
            StudentNametxtBox.Size = new Size(217, 23);
            StudentNametxtBox.TabIndex = 4;
            // 
            // StudentIDtxtBox
            // 
            StudentIDtxtBox.Location = new Point(16, 51);
            StudentIDtxtBox.Name = "StudentIDtxtBox";
            StudentIDtxtBox.PlaceholderText = "Student ID";
            StudentIDtxtBox.Size = new Size(217, 23);
            StudentIDtxtBox.TabIndex = 2;
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
            TeacherLoginPanel.Controls.Add(TeacherLoginbtn);
            TeacherLoginPanel.Controls.Add(TeacherDepartmenttxtBox);
            TeacherLoginPanel.Controls.Add(TeacherNametxtBox);
            TeacherLoginPanel.Controls.Add(TeacherIDtxtBox);
            TeacherLoginPanel.Controls.Add(label3);
            TeacherLoginPanel.Location = new Point(288, 118);
            TeacherLoginPanel.Name = "TeacherLoginPanel";
            TeacherLoginPanel.Size = new Size(250, 208);
            TeacherLoginPanel.TabIndex = 7;
            // 
            // TeacherLoginbtn
            // 
            TeacherLoginbtn.BackColor = Color.FromArgb(38, 49, 89);
            TeacherLoginbtn.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TeacherLoginbtn.ForeColor = Color.FromArgb(255, 251, 235);
            TeacherLoginbtn.Location = new Point(35, 138);
            TeacherLoginbtn.Name = "TeacherLoginbtn";
            TeacherLoginbtn.Size = new Size(179, 26);
            TeacherLoginbtn.TabIndex = 7;
            TeacherLoginbtn.Text = "LOGIN";
            TeacherLoginbtn.UseVisualStyleBackColor = false;
            // 
            // TeacherDepartmenttxtBox
            // 
            TeacherDepartmenttxtBox.Location = new Point(16, 109);
            TeacherDepartmenttxtBox.Name = "TeacherDepartmenttxtBox";
            TeacherDepartmenttxtBox.PlaceholderText = "Department";
            TeacherDepartmenttxtBox.Size = new Size(217, 23);
            TeacherDepartmenttxtBox.TabIndex = 5;
            // 
            // TeacherNametxtBox
            // 
            TeacherNametxtBox.Location = new Point(16, 80);
            TeacherNametxtBox.Name = "TeacherNametxtBox";
            TeacherNametxtBox.PlaceholderText = "Name";
            TeacherNametxtBox.Size = new Size(217, 23);
            TeacherNametxtBox.TabIndex = 4;
            // 
            // TeacherIDtxtBox
            // 
            TeacherIDtxtBox.Location = new Point(16, 51);
            TeacherIDtxtBox.Name = "TeacherIDtxtBox";
            TeacherIDtxtBox.PlaceholderText = "Employee ID";
            TeacherIDtxtBox.Size = new Size(217, 23);
            TeacherIDtxtBox.TabIndex = 2;
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
            ClientSize = new Size(563, 338);
            Controls.Add(TeacherLoginPanel);
            Controls.Add(StudentLoginPanel);
            Controls.Add(AdmitTypePanel);
            Name = "FormLogin";
            Text = "LOGIN";
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
        private TextBox StudentYeartxtBox;
        private TextBox StudentNametxtBox;
        private TextBox StudentIDtxtBox;
        private Label label2;
        private TextBox StudentSectiontxtBox;
        private Button StudentLoginbtn;
        private Panel TeacherLoginPanel;
        private TextBox TeacherDepartmenttxtBox;
        private TextBox TeacherNametxtBox;
        private TextBox TeacherIDtxtBox;
        private Label label3;
        private Button TeacherLoginbtn;
    }
}