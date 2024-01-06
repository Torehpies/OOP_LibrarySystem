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
            if (string.IsNullOrWhiteSpace(StudentIDTxtBox.Text))
            {
                MessageBox.Show("Please enter your student id or check the other information that is missing.", "Notice");
            }
            else if (string.IsNullOrWhiteSpace(StudentNameTxtBox.Text))
            {
                MessageBox.Show("Please enter your name or check the other information that is missing.", "Notice");
            }
            else if (string.IsNullOrWhiteSpace(StudentYearTxtBox.Text))
            {
                MessageBox.Show("Please enter your year or check the other information that is missing.", "Notice");
            }
            else if (string.IsNullOrWhiteSpace(StudentSectionTxtBox.Text))
            {
                MessageBox.Show("Please enter your section or check the other information that is missing.", "Notice");
            }
            else
            {
                bool isExisting = new BorrowerList().checkIfSameID(StudentIDTxtBox.Text);
                BorrowingForm borrowingForm = new BorrowingForm();
                borrowingForm.isStudent(true);
                borrowingForm.ShowDialog();
                this.Close();
            }
        }

        private void TeacherLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TeacherIDTxtBox.Text))
            {
                MessageBox.Show("Please enter your employee id or check the other information that is missing.", "Notice");
            }
            else if (string.IsNullOrWhiteSpace(TeacherNameTxtBox.Text))
            {
                MessageBox.Show("Please enter your name or check the other information that is missing.", "Notice");
            }
            else if (string.IsNullOrWhiteSpace(TeacherDepartmentTxtBox.Text))
            {
                MessageBox.Show("Please enter your department or check the other information that is missing.", "Notice");
            }
            else
            {
                bool isExisting = new BorrowerList().checkIfSameID(TeacherIDTxtBox.Text);
                BorrowingForm form_Homepage = new BorrowingForm();
                form_Homepage.isStudent(false);
                form_Homepage.ShowDialog();
                this.Close();
            }
        }
    }
}