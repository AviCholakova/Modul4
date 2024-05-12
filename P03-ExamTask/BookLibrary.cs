using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public class BookLibrary
    {
        private string name;
        private List<Book> books;
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public BookLibrary(string name)
        {
            this.books = new List<Book>();
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void AddBook(string title, double rating)
        {
            Book book = new Book(title, rating);
            books.Add(book);
        }
        public List<Book> SortByTitle()
        {
            return books.OrderBy(x => x.Title).ToList();
        }
        public List<Book> SortByRating()
        {
            return books.OrderByDescending(x => x.Rating).ToList();
        }
        public bool CheckBookIsInBookLibrary(string title)
        {
            Book book = books.FirstOrDefault(x => x.Title == title);
            if (book != null)
            {
                return true;
            }
            return false;
        }
        public List<string> GetBooksByRating(double rating)
        {
            //Important Method
            var ratingBook = books.Where(x => x.Rating > rating).Select(x => x.Title).ToList();
            return ratingBook;
        }
        public double AverageRating()
        {
            double average = books.Average(x => x.Rating);
            return average;
        }
        public string[] ProvideInformationAboutAllBooks()
        {
            string[] info = books.Select(x => x.ToString()).ToArray();
            return info;
        }

    }
}
