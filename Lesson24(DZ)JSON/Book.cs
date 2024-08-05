using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24_DZ_JSON
{
    public class Book
    {
        public Book(string? title, string? author, string? genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int Year { get; set; }
    }
 
}

