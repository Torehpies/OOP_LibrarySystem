using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    
    internal class UsersData
    {
        private static Teacher[] teacherData = 
        { 
            new Teacher("Maria", "Espiritu", "2134", "IT", 1, new List<int>{5}),
            new Teacher("John", "Calamba", "2164", "IS", 1, new List<int>{6}),
            new Teacher("Mario", "Narcisso", "2194", "CS", 1, new List<int>{7}) 
        };

        private static Student[] studentData = 
        {   
            new Student("Kaithlyn", "Mercado", "7845", "2", "A", 1, new List<int>{8}),
            new Student("Eniya", "Nolastre", "7981", "2", "B", 1, new List<int>{9}),
            new Student("Dovina", "Potrako", "7891", "2", "B", 0),
            new Student("Skarr", "Mindanar", "7145", "2", "C", 0),
            new Student("Kandis", "Terkones", "8945", "2", "C", 0),
            new Student("Kenra", "Oakenshield", "7834", "2", "B", 0),
            new Student("Mindra", "Miltranes", "2345", "2", "C", 0),
            new Student("Sophie", "Ofesiya", "7812", "2", "A", 0),
            new Student("Miling", "Andanar", "7842", "2", "D", 0),
            new Student("Trony", "Talkombre", "7895", "2", "A", 0) 
        };
                                            

        public static Student[] Students
        {
            get { return studentData; }
        }

        public static Teacher[] Teachers
        {
            get { return teacherData; }
        }

        public static void addBorrowCount(string id, int newBorrow, bool isStudent)
        {
            if (isStudent)
            {
                foreach(Student student in studentData)
                {
                    if (student.userID == id)
                    {
                        student.borrowedBookCount += newBorrow;
                    }
                }
            }
            else
            {
                foreach (Teacher teacher in teacherData)
                {
                    if (teacher.userID == id)
                    {
                        teacher.borrowedBookCount += newBorrow;
                    }
                }
            }
            
        }

        public static void deductBorrowCount(User user)
        {
            foreach (Student student in studentData)
            {
                if (student.firstName == user.firstName &&
                    student.lastName == user.lastName)
                {
                    student.borrowedBookCount--;
                }
            }
            
            foreach (Teacher teacher in teacherData)
            {
                if (teacher.firstName == user.firstName &&
                    teacher.lastName == user.lastName)
                {
                    teacher.borrowedBookCount--;
                }
            }
        }

        public static Teacher getTeacherByID(string id)
        {
            Teacher user = null;
            foreach (Teacher teacher in teacherData)
            {
                if (teacher.userID == id) user = teacher;
            }

            return user;
        }

        public static Student getStudentByID(string id)
        {
            Student user = null;
            foreach (Student student in studentData)
            {
                if (student.userID == id) user = student;
            }

            return user;
        }

        public static bool isUserExists(Teacher userTeacher)
        {
            bool result = false;
            foreach (Teacher teacher in teacherData)
            {
                if (userTeacher.firstName == teacher.firstName && 
                    userTeacher.lastName == teacher.lastName && 
                    userTeacher.userID == teacher.userID &&
                    userTeacher.department == teacher.department)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool isUserExists(Student userStudent)
        {
            bool result = false;
            foreach (Student student in studentData)
            {
                if (userStudent.firstName == student.firstName && 
                    userStudent.lastName == student.lastName && 
                    userStudent.userID == student.userID &&
                    userStudent.section == student.section &&
                    userStudent.yearlevel == student.yearlevel)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool isUserExists(User user)
        {
            foreach (Student student in studentData)
            {
                if (user.firstName ==  student.firstName &&
                    user.lastName == student.lastName)
                {
                    return true;
                }
            }

            foreach (Teacher teacher in teacherData)
            {
                if (user.firstName == teacher.firstName &&
                    user.lastName == teacher.lastName)
                {
                    return true;
                }
            }

            return false;
        }

        public static void appendUserBookList(List<int> newBookList, string id)
        {
            Student student = getStudentByID(id);
            Teacher teacher = getTeacherByID(id);

            if (student != null) student.borrowedBooks.Concat(newBookList);
            else teacher.borrowedBooks.Concat(newBookList);
        }
    }
}
