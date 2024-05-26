using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT_DRAFTZ_5_
{
    public class Books
    {
        string title;
        string isbn;
        string author;
        string category;
        string publisher;
        string published;
        string image;
        int availableCopies;
        int totalCopies;
        int booksToborrow;
        string imagePath;
        Image icon;

        public Books(string title, string isbn, string author, string category, string publisher, string published, int aCopies)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            
        }

       
       public Books(string Title, string ISBN, string Author, string Category, string Publisher, string Date)
        {
            this.title = Title;
            this.isbn = ISBN;
            this.author = Author;
            this.category = Category;
            this.publisher = Publisher;
            this.published = Date;
            

        }
        

        public Books(string title, string isbn, string author, string category, string publisher, string published, string ImagePath)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            this.image = ImagePath;
        }

        public Books(string title, string isbn, string author, string category, string publisher, string published, int availableCopies, int totalCopies, int booksToborrow)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            this.availableCopies = availableCopies;
            this.totalCopies = totalCopies;
            this.booksToborrow = booksToborrow;
        }

        
        public Books(string Title, string ISBN, string Author, string Category, string Publisher, string Year, int aCopies, int tCopies, Image icon)
        {
            this.title = title;
            this.isbn = ISBN;
            this.author = Author;
            this.category = Category;
            this.publisher = Publisher;
            this.published = Year;
            this.availableCopies = aCopies;
            this.totalCopies = tCopies;
            this.icon = icon;

        }

        public Books(string Title, string ISBN, string Author, string Category, string Publisher, string Year, int tCopies, Image icon)
        {
            this.title = title;
            this.isbn = ISBN;
            this.author = Author;
            this.category = Category;
            this.publisher = Publisher;
            this.published = Year;
            this.totalCopies = tCopies;
            this.icon = icon;

        }









        public string Title { get { return title; } }
        public string ISBN { get { return isbn; } }
        public string Author { get { return author; } }
        public string Category { get { return category; } }
        public string Publisher { get { return publisher; } }
        public string Published { get { return published; } }
        public int AvailableCopies { get { return availableCopies; } }
        public int TotalCopies { get { return totalCopies; } }
        public int BooksToborrow { get { return booksToborrow; } }
        public Image Icon { get { return icon; } }
        public string ImagePath { get { return imagePath; } }
    }
}