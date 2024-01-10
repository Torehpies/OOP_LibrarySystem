namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            StudentRadioButton.Checked = false;
            TeacherRadioButton.Checked = false;
            StudentLoginPanel.Visible = false;
            TeacherLoginPanel.Visible = false;
        }

        private void StudentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentRadioButton.Checked)
            {
                StudentLoginPanel.Visible = true;
            }
            else
            {
                StudentLoginPanel.Visible = false;
            }
        }

        private void TeacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TeacherRadioButton.Checked)
            {
                TeacherLoginPanel.Visible = true;
            }
            else
            {
                TeacherLoginPanel.Visible = false;
            }
        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            
            if (!isTextBoxValid(StudentLoginPanel))
            {
                MessageBox.Show("Please enter your student id or check the other information that is missing.", "Notice");
                return;
            }

            Student userStudent = new Student(StudentFirstNameTxtBox.Text,
                                              StudentLastNameTxtBox.Text,
                                              StudentIDTxtBox.Text,
                                              StudentYearTxtBox.Text,
                                              StudentSectionTxtBox.Text);
            if (!UsersData.isUserExists(userStudent))
            {
                MessageBox.Show("Incorrect information or User does not exist.", "Notice");
                return;
            }
            
            BorrowingForm borrowingForm = new BorrowingForm();
            borrowingForm.ShowDialog();
            this.Close();
            
        }

        private void TeacherLoginButton_Click(object sender, EventArgs e)
        {

            if (!isTextBoxValid(TeacherLoginPanel))
            {
                MessageBox.Show("Please enter your student id or check the other information that is missing.", "Notice");
                return;
            }

            Teacher userTeacher = new Teacher(TeacherFirstNameTxtBox.Text,
                                              TeacherLastNameTxtBox.Text,
                                              TeacherIDTxtBox.Text,
                                              TeacherDepartmentTxtBox.Text);
                                              
            if (!UsersData.isUserExists(userTeacher))
            {
                MessageBox.Show("Incorrect information or User does not exist.", "Notice");
                return;
            }

            BorrowingForm borrowingForm = new BorrowingForm();
            borrowingForm.ShowDialog();
            this.Close();
        }

        private bool isTextBoxValid(Control container)
        {
            bool result = true;
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

  
    }
}