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

        public Student(string firstname, string lastname, string userId, string yearlevel, string section, int borrowcount)
        {   
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.yearlevel = yearlevel;
            this.section = section;
            borrowedBookCount = borrowcount;
        }

        public Student(string firstname, string lastname, string userId, string yearlevel, string section)
        {
            firstName = firstname;
            lastName = lastname;
            userID = userId;
            this.yearlevel = yearlevel;
            this.section = section;
        }

    }
}
