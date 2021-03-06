﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }
        public string Title { get; private set; }

        public int Year { get; private set; }

        public IReadOnlyList<string> Authors { get; private set; }

        public int CompareTo(Book other)
        {
            if (this.Year.CompareTo(other.Year) == 0)
            {
                return this.Title.CompareTo(other.Title);
            }

            return this.Year.CompareTo(other.Year);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
