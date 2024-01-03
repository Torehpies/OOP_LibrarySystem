using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class Book 
    {
        enum Status
        {
            Available,
            Borrowed
        }
        public string title;
        public string isbn13;
        public string isbn10;
        public string author;
        public string category;
        public string publisher;
        public string published;
        Status status = Status.Available;
    }
}
