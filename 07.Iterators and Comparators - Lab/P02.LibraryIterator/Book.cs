using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public Book(string title, int year, params string[] author)
        {
            Title = title;
            Year = year;
            Author = author;
        }

        public string Title { get; set; }
        public int Year { get; set; }
       public IReadOnlyList<string> Author { get; set; }
    }
}
