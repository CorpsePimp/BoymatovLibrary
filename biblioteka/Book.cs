using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteka
{
    internal class Book
    {
        public int Id { get; private set; } // Числовой ID книги
        public string Title { get; set; } // Название книги
        public string Author { get; set; } // Автор книги
        public int Year { get; set; } // Год издания книги

        public Book(int id, string title, string author, int year)
        {
            Id = id; // Присваиваем числовой ID
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Название: {Title}, Автор: {Author}, Год: {Year}";
        }
    }
}