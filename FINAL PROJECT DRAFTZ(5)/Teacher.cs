using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class Teacher : User
    {
        public string department
        { get; set; }

        public Teacher(string firstname, string lastname, string userId, string department, int borrowercount) : base(firstname, lastname)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.department = department;
            borrowedBookCount = borrowercount;
        }

        public Teacher(string firstname, string lastname, string userId, string department) : base(firstname, lastname)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.department = department;
        }
        public Teacher(string firstname, string lastname, string userId, string department, int borrowercount, List<int> BorrowedBooks) : base(firstname, lastname)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.department = department;
            borrowedBookCount = borrowercount;
            borrowedBooks = BorrowedBooks;

        }
        public Teacher(string FirstName, string LastName): base(FirstName, LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
