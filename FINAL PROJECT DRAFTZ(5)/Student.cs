using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class Student : User 
    {
        public string yearlevel
        {  get; set; }
        public string section
        { get; set; }

        public Student(string firstname, string lastname, string userId, string yearlevel, string section, int borrowcount) : base (firstname, lastname)
        {   
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.yearlevel = yearlevel;
            this.section = section;
            borrowedBookCount = borrowcount;
        }

        public Student(string firstname, string lastname, string userId, string yearlevel, string section) : base(firstname, lastname)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.yearlevel = yearlevel;
            this.section = section;
        }

        public Student(string firstname, string lastname, string userId, string yearlevel, string section, int borrowcount, List<int> BorrowedBooks) : base(firstname, lastname)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.yearlevel = yearlevel;
            this.section = section;
            borrowedBookCount = borrowcount;
            borrowedBooks = BorrowedBooks;

        }


    }
}
