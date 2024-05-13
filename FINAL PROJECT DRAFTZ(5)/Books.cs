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

        public Books(string title, string isbn, string author, string category, string publisher, string published)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            
        }

        public Books(string title, string published)
        {
            this.title = title;
            this.published = published; 
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

        Image icon;
        public Books(string title, string isbn, string author, string category, string publisher, string published, Image ImagePath)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
            this.category = category;
            this.publisher = publisher;
            this.published = published;
            this.icon = ImagePath;
        }

        public string Title { get { return title; } }
        public string ISBN { get { return isbn; } }
        public string Author { get { return author; } }
        public string Category { get { return category; } }
        public string Publisher { get { return publisher; } }
        public string Published { get { return published; } }

        public string Date { get { return published; } }
        public string ImagePath { set { }  get { return image; } }
        public int TotalCopies { get { return totalCopies; } }
        public int AvailableCopies { get {  return availableCopies; } }
        public Image Icon { get { return icon; } }
    }
}