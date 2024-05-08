using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    internal class BookData
    {
        private static BookData instance;

        public event EventHandler<int> BookListChanged;

        protected virtual void OnBookListChanged(int index)
        {
            BookListChanged?.Invoke(this, index);
        }

        //"C:\\Users\\Salupado\\source\\repos\\OOP_LibrarySystem\\FINAL PROJECT DRAFTZ(5)\\Resources\\";

        static string picturePath = "F:\\LIB\\FINAL PROJECT DRAFTZ(5)\\Resources\\";

        private Book[] bookList;
        private BookData()
        {
            bookList=  new Book[]
            {
                new Book(Book.BookType.Borrowed, "How to Write a Lot: A Practical Guide to Productive Academic Writing", "9781433829789", "1433829789", "Academic", "Paul J. Silvia", "American Psychological Association", "2018 ", picturePath + "how to write a lot.jpg"),
                new Book(Book.BookType.Borrowed, "Decolonizing Methodologies: Research and Indigenous Peoples", "9781350346086", "135034608X", "Academic", "Smith, Linda Tuhiwai", "Bloomsbury Academic", "2023-01-26", picturePath + "methodologies.jpg"),
                new Book(Book.BookType.Borrowed, "What I Wish I Knew When I Was 20: A Crash Course on Making Your Place in the World", "9780061872495", "0061872490", "Academic", "Tina Seelig", "Harper Collins", "2009", picturePath + "what i wish i know.png"),
                new Book(Book.BookType.Borrowed, "Orientalism", "9780394740676", "039474067X", "Academic", "Said, Edward W.", "Vintage", "1979", picturePath + "orientalism.jpg"),
                new Book(Book.BookType.Borrowed, "In Search of Deeper Learning: The Quest to Remake the American High School", "9780674248250", "0674248252", "Academic", "Jal Mehta, Sarah Fine", "Harvard University Press", "2020-08-04", picturePath + "deeper learning.jpg"),
                new Book(Book.BookType.Available, "If We Were Villains: A Novel", "9781250095305", "1250095301", "Fiction", "M. L. Rio", "Flatiron Books", "2017", picturePath + "if we were villains.jpg"),
                new Book(Book.BookType.Borrowed, "The Book Thief", "9780307433848", "0307433846", "Fiction", "Markus Zusak", "Random House Children's Books", "2007", picturePath + "book thief.jpg"),
                new Book(Book.BookType.Available, "Changing Tides (National Treasure - A Gates Family Mystery)", "9781423108146", "1423108140", "Fiction", "Catherine Hapka", "Disney Press", "2007-11-06", picturePath + "changing tides.jpg"),
                new Book(Book.BookType.Borrowed, "Pride and Prejudice", "9781616416959", "1616416955", "Fiction", "Jane Austen", "ABDO", "2011", picturePath + "pride and prejudice.jpg"),
                new Book(Book.BookType.Available, "Jane Eyre", "9781616416911", "1616416912", "Fiction", "Charlotte Brontë", "ABDO", "2011", picturePath + "jane eyre.jpg"),
                new Book(Book.BookType.Borrowed, "A Brief History of Time", "9780553380163", "0553380168", "Non-Fiction", "Stephen Hawking", "Random House Publishing Group", "1998-09-01", picturePath + "a brief history of time.jpg"),
                new Book(Book.BookType.Available, "The Female Eunuch", "9780061972805", "0061972800", "Non-Fiction", "Germaine Greer", "Harper Collins", "2009", picturePath + "the female eunuch.jpg"),
                new Book(Book.BookType.Available, "Republic", "9781603840132", "1603840133", "Non-Fiction", "Plato", "Hackett Publishing", "2004", picturePath + "republic.jpg"),
                new Book(Book.BookType.Borrowed, "Night", "9780374500016", "0374500010", "Non-Fiction", "Elie Wiesel", "Paw Prints", "2008-04-25", picturePath + "night.jpg"),
                new Book(Book.BookType.Borrowed, "Silent Spring", "9780547527628", "0547527624", "Non-Fiction", "Rachel Carson", "Harper Collins", "2002", picturePath + "silent spring.jpg")
            };

        }
        public static BookData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookData();
                }
                return instance;
            }

        }

        public Book[] BookList
        {
            get { return bookList; }
            set
            {
                bookList = value;
                //OnBookListChanged();
            }
        }
       

        public void BookStatusToBorrowed(List<int> Titles)
        {
            foreach(int title in Titles)
            {
                BookList[title].status = Book.BookType.Borrowed;
                OnBookListChanged(title);
            }
        }

        public void BookStatusToAvailable(string Title)
        {
            int index = 0;
            foreach (Book book in BookList)
            {
                if (book.title == Title)
                {
                    book.status = Book.BookType.Available;
                    
                    OnBookListChanged(index);
                }
                index++;
            }
        }
    }
}
