using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string newTitle, int newYear, params string[] newAuthors)
        {
            this.Title = newTitle;
            this.Year = newYear;
            this.Authors = newAuthors;
        }

        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }


        public int CompareTo(Book anotherBook)
        {
            if (this.Year < anotherBook.Year)
            {
                return 1;
            }

            if (this.Year > anotherBook.Year)
            {
                return -1;
            }

             return this.Title.CompareTo(anotherBook.Title); ;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
