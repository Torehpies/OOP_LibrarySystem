using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text.Length == 0 || name.Text.Length == 0 || details.Text.Length == 0 || department.Text.Length == 0 || type.Text.Length == 0)
            {
                MessageBox.Show("Make sure everything is filled!");
                return;
            }

            Database addStudent = new Database();
            addStudent.addStudent(id.Text, name.Text, details.Text, department.Text, type.Text);
            MessageBox.Show("Student named: " + id.Text + " is added to the database");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            StudentFillUp parent = this.ParentForm as StudentFillUp;
            parent.Close();
        }
    }
}
