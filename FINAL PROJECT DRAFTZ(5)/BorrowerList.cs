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

            teachers.Add(new Teacher("Maria", "Espiritu", "2134", "IT", 0));
            teachers.Add(new Teacher("John", "Calamba", "2164", "IS", 0));
            teachers.Add(new Teacher("Mario", "Narcisso", "2194", "CS", 0));

            students.Add(new Student("Kaithlyn", "Mercado", "7845", "2", "A", 0));
            students.Add(new Student("Eniya", "Nolastre", "7981", "2", "B", 0));
            students.Add(new Student("Dovina", "Potrako", "7890", "2", "B", 0));
            students.Add(new Student("Skarr", "Mindanar", "7145", "2", "C", 0));
            students.Add(new Student("Kandis", "Terkones", "8945", "2", "C", 0));
            students.Add(new Student("Kenra", "Oakenshield", "7834", "2", "B", 0));
            students.Add(new Student("Mindra", "Miltranes", "2345", "2", "C", 0));
            students.Add(new Student("Sophie", "Ofesiya", "7812", "2", "A", 0));
            students.Add(new Student("Miling", "Andanar", "7842", "2", "D", 0));
            students.Add(new Student("Trony", "Talkombre", "7845", "2", "A", 0));
            students.Add(new Student("Mantrano", "Terintinas", "7823", "2", "A", 0));

            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.firstName + " " + student.lastName);
                item.SubItems.Add(student.userID);
                item.SubItems.Add(student.yearlevel);
                item.SubItems.Add(student.section);
                StudentListView.Items.Add(item);
            }

            foreach(Teacher teacher in teachers)
            {
                ListViewItem item = new ListViewItem(teacher.firstName + " " + teacher.lastName);
                item.SubItems.Add(teacher.userID);
                item.SubItems.Add(teacher.department);
                TeacherListView.Items.Add(item);
            }

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

        public List<Student> GetStudents()
        {
            return students;
        }

        public bool checkIfSameID(string userID)
        {
            bool result = false;
            foreach (Student student in students)
            {
                if (student.userID == userID) result = true;
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
