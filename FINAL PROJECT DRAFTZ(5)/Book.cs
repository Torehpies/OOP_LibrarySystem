using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class Book
    {
        public enum BookType
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
        public string BookID
        { get; set; }
        private BookType status = BookType.Available;
        public BookType Status
        {
            get { return status; }
            set { status = value; }
        }
        public Book(string BookTitle, string BookIsbn13, string BookIsbn10, string BookAuthor, string BookCategory, string BookPublisher, string BookPublished, BookType BookStatus)
        {
            title = BookTitle;
            isbn13 = BookIsbn13;
            isbn10 = BookIsbn10;
            author = BookAuthor;
            category = BookCategory;
            publisher = BookPublisher;
            published = BookPublished;
            Status = BookStatus;
        }
    }
}
