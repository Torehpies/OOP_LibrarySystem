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
        int availableCopies;
        int totalCopies;
        int booksToborrow;

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

        

        public string Title { get { return title; } }
        public string ISBN { get { return isbn; } }
        public string Author { get { return author; } }
        public string Category { get { return category; } }
        public string Publisher { get { return publisher; } }
        public string Published { get { return published; } }

        public string Date { get { return published; } }
        public int AvailableCopies { get {  return availableCopies; } }
        public int TotalCopies { get {  return totalCopies; } }
        public int BooksToborrow { get {  return booksToborrow; } }
    }
}
