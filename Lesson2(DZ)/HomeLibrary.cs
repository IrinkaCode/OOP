using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_DZ_
{
    public class Book
    {
        public string ?Title { get; set; }
        public string ?Author { get; set; }
        public int Year { get; set; }
    }
    internal class HomeLibrary
    {
        private List<Book> books;

        public HomeLibrary()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> FindByAuthor(string author)
        {
            return books.Where(b => b.Author == author).ToList();
        }

        public List<Book> FindByYear(int year)
        {
            return books.Where(b => b.Year == year).ToList();
        }

        public void SortByTitle()
        {
            books.Sort((a, b) => a.Title!.CompareTo(b.Title));
        }

        public void SortByAuthor()
        {
            books.Sort((a, b) => a.Author!.CompareTo(b.Author));
        }

        public void SortByYear()
        {
            books.Sort((a, b) => a.Year.CompareTo(b.Year));
        }

        public void PrintLibrary()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
    }
}
