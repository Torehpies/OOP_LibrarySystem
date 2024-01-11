using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class Book
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
        public string picturePath
        { get; set; }
        public BookType status
        { get; set; }
        public Book(BookType status, string BookTitle, string BookIsbn13, string BookIsbn10, string BookCategory, string BookAuthor, string BookPublisher, string BookPublished, string PicturePath)
        {
            this.status = status;
            title = BookTitle;
            isbn13 = BookIsbn13;
            isbn10 = BookIsbn10;
            category = BookCategory;
            author = BookAuthor;
            publisher = BookPublisher;
            published = BookPublished;
            picturePath = PicturePath;
        }
    }
}
