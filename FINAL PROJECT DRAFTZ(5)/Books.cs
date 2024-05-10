using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class Books
    {
        private string title;
        private string date;

        public Books(string title, string date)
        {
            this.title = title;
            this.date = date;
        }

        public string Title { get { return title; } }
        public string Date { get { return date; } }
    }
}
