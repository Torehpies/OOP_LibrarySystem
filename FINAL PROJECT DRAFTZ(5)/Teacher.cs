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

        public Teacher(string firstname, string lastname, string userId, string department, int borrowercount)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.department = department;
            borrowedBookCount = borrowercount;
        }
    }
}
