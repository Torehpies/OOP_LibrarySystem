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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            AdmitTypePanel = new Panel();
            TeacherRadioButton = new RadioButton();
            StudentRadioButton = new RadioButton();
            label1 = new Label();
            StudentLoginPanel = new Panel();
            StudentLastNameTxtBox = new TextBox();
            StudentLoginButton = new Button();
            StudentSectionTxtBox = new TextBox();
            StudentYearTxtBox = new TextBox();
            StudentFirstNameTxtBox = new TextBox();
            StudentIDTxtBox = new TextBox();
            label2 = new Label();
            TeacherLoginPanel = new Panel();
            TeacherLastNameTxtBox = new TextBox();
            TeacherLoginButton = new Button();
            TeacherDepartmentTxtBox = new TextBox();
            TeacherFirstNameTxtBox = new TextBox();
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
            resources.ApplyResources(AdmitTypePanel, "AdmitTypePanel");
            AdmitTypePanel.Name = "AdmitTypePanel";
            // 
            // TeacherRadioButton
            // 
            resources.ApplyResources(TeacherRadioButton, "TeacherRadioButton");
            TeacherRadioButton.ForeColor = Color.FromArgb(73, 85, 121);
            TeacherRadioButton.Name = "TeacherRadioButton";
            TeacherRadioButton.TabStop = true;
            TeacherRadioButton.UseVisualStyleBackColor = true;
            TeacherRadioButton.CheckedChanged += TeacherRadioButton_CheckedChanged;
            // 
            // StudentRadioButton
            // 
            resources.ApplyResources(StudentRadioButton, "StudentRadioButton");
            StudentRadioButton.ForeColor = Color.FromArgb(73, 85, 121);
            StudentRadioButton.Name = "StudentRadioButton";
            StudentRadioButton.TabStop = true;
            StudentRadioButton.UseVisualStyleBackColor = true;
            StudentRadioButton.CheckedChanged += StudentRadioButton_CheckedChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(73, 85, 121);
            label1.Name = "label1";
            // 
            // StudentLoginPanel
            // 
            StudentLoginPanel.BorderStyle = BorderStyle.FixedSingle;
            StudentLoginPanel.Controls.Add(StudentLastNameTxtBox);
            StudentLoginPanel.Controls.Add(StudentLoginButton);
            StudentLoginPanel.Controls.Add(StudentSectionTxtBox);
            StudentLoginPanel.Controls.Add(StudentYearTxtBox);
            StudentLoginPanel.Controls.Add(StudentFirstNameTxtBox);
            StudentLoginPanel.Controls.Add(StudentIDTxtBox);
            StudentLoginPanel.Controls.Add(label2);
            resources.ApplyResources(StudentLoginPanel, "StudentLoginPanel");
            StudentLoginPanel.Name = "StudentLoginPanel";
            // 
            // StudentLastNameTxtBox
            // 
            resources.ApplyResources(StudentLastNameTxtBox, "StudentLastNameTxtBox");
            StudentLastNameTxtBox.Name = "StudentLastNameTxtBox";
            // 
            // StudentLoginButton
            // 
            StudentLoginButton.BackColor = Color.FromArgb(38, 49, 89);
            resources.ApplyResources(StudentLoginButton, "StudentLoginButton");
            StudentLoginButton.ForeColor = Color.FromArgb(255, 251, 235);
            StudentLoginButton.Name = "StudentLoginButton";
            StudentLoginButton.UseVisualStyleBackColor = false;
            StudentLoginButton.Click += StudentLoginButton_Click;
            // 
            // StudentSectionTxtBox
            // 
            resources.ApplyResources(StudentSectionTxtBox, "StudentSectionTxtBox");
            StudentSectionTxtBox.Name = "StudentSectionTxtBox";
            // 
            // StudentYearTxtBox
            // 
            resources.ApplyResources(StudentYearTxtBox, "StudentYearTxtBox");
            StudentYearTxtBox.Name = "StudentYearTxtBox";
            // 
            // StudentFirstNameTxtBox
            // 
            resources.ApplyResources(StudentFirstNameTxtBox, "StudentFirstNameTxtBox");
            StudentFirstNameTxtBox.Name = "StudentFirstNameTxtBox";
            // 
            // StudentIDTxtBox
            // 
            resources.ApplyResources(StudentIDTxtBox, "StudentIDTxtBox");
            StudentIDTxtBox.Name = "StudentIDTxtBox";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(73, 85, 121);
            label2.Name = "label2";
            // 
            // TeacherLoginPanel
            // 
            TeacherLoginPanel.BorderStyle = BorderStyle.FixedSingle;
            TeacherLoginPanel.Controls.Add(TeacherLastNameTxtBox);
            TeacherLoginPanel.Controls.Add(TeacherLoginButton);
            TeacherLoginPanel.Controls.Add(TeacherDepartmentTxtBox);
            TeacherLoginPanel.Controls.Add(TeacherFirstNameTxtBox);
            TeacherLoginPanel.Controls.Add(TeacherIDTxtBox);
            TeacherLoginPanel.Controls.Add(label3);
            resources.ApplyResources(TeacherLoginPanel, "TeacherLoginPanel");
            TeacherLoginPanel.Name = "TeacherLoginPanel";
            // 
            // TeacherLastNameTxtBox
            // 
            resources.ApplyResources(TeacherLastNameTxtBox, "TeacherLastNameTxtBox");
            TeacherLastNameTxtBox.Name = "TeacherLastNameTxtBox";
            // 
            // TeacherLoginButton
            // 
            TeacherLoginButton.BackColor = Color.FromArgb(38, 49, 89);
            resources.ApplyResources(TeacherLoginButton, "TeacherLoginButton");
            TeacherLoginButton.ForeColor = Color.FromArgb(255, 251, 235);
            TeacherLoginButton.Name = "TeacherLoginButton";
            TeacherLoginButton.UseVisualStyleBackColor = false;
            TeacherLoginButton.Click += TeacherLoginButton_Click;
            // 
            // TeacherDepartmentTxtBox
            // 
            resources.ApplyResources(TeacherDepartmentTxtBox, "TeacherDepartmentTxtBox");
            TeacherDepartmentTxtBox.Name = "TeacherDepartmentTxtBox";
            // 
            // TeacherFirstNameTxtBox
            // 
            resources.ApplyResources(TeacherFirstNameTxtBox, "TeacherFirstNameTxtBox");
            TeacherFirstNameTxtBox.Name = "TeacherFirstNameTxtBox";
            // 
            // TeacherIDTxtBox
            // 
            resources.ApplyResources(TeacherIDTxtBox, "TeacherIDTxtBox");
            TeacherIDTxtBox.Name = "TeacherIDTxtBox";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(73, 85, 121);
            label3.Name = "label3";
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            Controls.Add(AdmitTypePanel);
            Controls.Add(StudentLoginPanel);
            Controls.Add(TeacherLoginPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormLogin";
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
        private TextBox StudentFirstNameTxtBox;
        private TextBox StudentIDTxtBox;
        private Label label2;
        private TextBox StudentSectionTxtBox;
        private Button StudentLoginButton;
        private Panel TeacherLoginPanel;
        private TextBox TeacherDepartmentTxtBox;
        private TextBox TeacherFirstNameTxtBox;
        private TextBox TeacherIDTxtBox;
        private Label label3;
        private Button TeacherLoginButton;
        private TextBox StudentLastNameTxtBox;
        private TextBox TeacherLastNameTxtBox;
    }
}