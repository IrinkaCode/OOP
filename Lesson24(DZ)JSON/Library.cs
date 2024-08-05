using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson24_DZ_JSON
{
    public class Library
    {
        private List<Book> books { get; set; }

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SerializeToJson(string filePath)
        {
            string jsonString = JsonSerializer.Serialize(books);
            File.WriteAllText(filePath, jsonString);
        }

        public void DeserializeFromJson(string filePath)
        {
            if((File.Exists(filePath)))
            {
                string jsonString = File.ReadAllText(filePath);
                books = JsonSerializer.Deserialize<List<Book>>(jsonString)!;
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Year: {book.Year}");
            }
        }
    }
}
