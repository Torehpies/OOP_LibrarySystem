using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    
    internal class UsersData
    {
        private static Teacher[] teacherData = { new Teacher("Maria", "Espiritu", "2134", "IT", 1),
                            new Teacher("John", "Calamba", "2164", "IS", 1),
                            new Teacher("Mario", "Narcisso", "2194", "CS", 1) };

        private static Student[] studentData = {   new Student("Kaithlyn", "Mercado", "7845", "2", "A", 1),
                                            new Student("Eniya", "Nolastre", "7981", "2", "B", 1),
                                            new Student("Dovina", "Potrako", "7891", "2", "B", 1),
                                            new Student("Skarr", "Mindanar", "7145", "2", "C", 1),
                                            new Student("Kandis", "Terkones", "8945", "2", "C", 1),
                                            new Student("Kenra", "Oakenshield", "7834", "2", "B", 1),
                                            new Student("Mindra", "Miltranes", "2345", "2", "C", 1),
                                            new Student("Sophie", "Ofesiya", "7812", "2", "A", 1),
                                            new Student("Miling", "Andanar", "7842", "2", "D", 1),
                                            new Student("Trony", "Talkombre", "7845", "2", "A", 1),
                                            new Student("Mantrano", "Terintinas", "7823", "2", "A", 1)};

        public static Student[] Students
        {
            get { return studentData; }
        }

        public static Teacher[] Teachers
        {
            get { return teacherData; }
        }

        public static void addBorrowCount()
        {

            
        }

        public static void removeBorrowCount()
        {


        }

        public static bool isUserExists(Teacher userTeacher)
        {
            
            foreach (Teacher teacher in teacherData)
            {
                if (userTeacher.firstName == teacher.firstName && userTeacher.lastName == teacher.lastName && userTeacher.userID == teacher.userID)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool isUserExists(Student userStudent)
        {

            foreach (Student student in studentData)
            {
                if (userStudent.firstName == student.firstName && userStudent.lastName == student.lastName && userStudent.userID == student.userID)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
