using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class User
    {
        public string firstName
        { get; set; }
        public string lastName 
        { get; set; }
        public string userID
        { get; set; }
        public int borrowedBookCount
        { get; set; }
        public string[] borrowedBooks { get; set; }
    }
}
