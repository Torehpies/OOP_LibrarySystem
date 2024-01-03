using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class Book
    {
        public enum BookStatus
        {
            Available,
            Borrowed
        }
        public string title
        { get; set; }
        public string isbn13
        { get; set; }
        public string isbn10
        { get; set; }
        public string author
        { get; set; }
        public string category
        { get; set; }
        public string publisher
        { get; set; }
        public string published
        { get; set; }
        private BookStatus status = BookStatus.Available;
        public BookStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        
    }
}
