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
        public BorrowerList()
        {
            InitializeComponent();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            foreach (Student student in UsersData.Students)
            {
                if (student.borrowedBookCount > 0)
                {
                    ListViewItem item = new ListViewItem(student.firstName + " " + student.lastName);
                    item.SubItems.Add(student.userID);
                    item.SubItems.Add(student.yearlevel);
                    item.SubItems.Add(student.section);
                    StudentListView.Items.Add(item);
                }
            }

            foreach (Teacher teacher in UsersData.Teachers)
            {
                if (teacher.borrowedBookCount > 0)
                {
                    ListViewItem item = new ListViewItem(teacher.firstName + " " + teacher.lastName);
                    item.SubItems.Add(teacher.userID);
                    item.SubItems.Add(teacher.department);
                    TeacherListView.Items.Add(item);
                }
            }
        }
    }
}
