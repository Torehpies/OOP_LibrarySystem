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
    public partial class BorrowerList : UserControl
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        public BorrowerList()
        {
            InitializeComponent();
        }

        public void addStudentBorrower(Student student)
        {
            students.Add(student);
        }

        public void addTeacherBorrower(Teacher teacher)
        {
            teachers.Add(teacher);  
        }

        public List<Teacher> GetTeachers()
        {
            return teachers;
        }

        public List<Student> GetStudents() { 
            return students;
        }

        public bool checkIfSameID(string userID)
        {
            bool result = false;
            foreach (Student student in students) {
                if (student.userID == userID)  result = true;
                else result = false;
            }

            foreach (Teacher teacher in teachers)
            {
                if (teacher.userID == userID) result = true;
                else result = false;
            }
            return result;
            
        }

    }
}
