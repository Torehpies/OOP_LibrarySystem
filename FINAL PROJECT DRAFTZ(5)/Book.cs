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
        string title;
        string isbn13;
        string isbn10;
        string author;
        string category;
        string publisher;
        string published;
        Status status = Status.Available;
    }
}
