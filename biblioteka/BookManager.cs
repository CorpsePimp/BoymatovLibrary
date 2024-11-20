using System;
using System.Collections.Generic;
using System.IO; // Для работы с файлами
using System.Linq;

namespace biblioteka
{
    internal class BookManager
    {
        private List<Book> books = new List<Book>(); // Список для хранения книг
        private int nextId = 1; // Переменная для генерации следующего ID

        public void AddBook(string title, string author, int year)
        {
            books.Add(new Book(nextId++, title, author, year)); // Создаем книгу с новым числовым ID
        }

        public bool RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }

        public List<Book> SearchBooks(string keyword)
        {
            if (int.TryParse(keyword, out int year))
            {
                return books.Where(b => b.Year == year).ToList();
            }

            return books.Where(b =>
                b.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                b.Author.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        // Метод для импорта книг из CSV файла
        public void ImportBooks(string filePath)
        {
            var lines = File.ReadAllLines(filePath); // Читаем все строки из файла
            foreach (var line in lines)
            {
                var parts = line.Split(','); // Предполагаем формат CSV: Title,Author,Year
                if (parts.Length == 3 && int.TryParse(parts[2], out int year))
                {
                    AddBook(parts[0].Trim(), parts[1].Trim(), year); // Добавляем книгу
                }
            }
        }

        // Метод для экспорта книг в CSV файл
        public void ExportBooks(string filePath)
        {
            var lines = books.Select(b => $"{b.Title},{b.Author},{b.Year}"); // Форматируем книги в строки
            File.WriteAllLines(filePath, lines); // Записываем строки в файл
        }

        // Метод для добавления книги из текста (например, из TXT или других файлов)
        public void AddBooksFromTextFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|'); // Формат: Title|Author|Year
                if (parts.Length == 3 && int.TryParse(parts[2], out int year))
                {
                    AddBook(parts[0].Trim(), parts[1].Trim(), year);
                }
            }
        }

        // Метод для экспорта книг в формат TXT
        public void ExportBooksToTextFile(string filePath)
        {
            var lines = books.Select(b => $"{b.Title} | {b.Author} | {b.Year}");
            File.WriteAllLines(filePath, lines);
        }

        // Метод для экспорта книг в формат PDF
        public void ExportBooksToPdf(string filePath)
        {
            // Используйте стороннюю библиотеку для PDF, например iTextSharp
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Список книг:");
                writer.WriteLine("=================");
                foreach (var book in books)
                {
                    writer.WriteLine($"Название: {book.Title}");
                    writer.WriteLine($"Автор: {book.Author}");
                    writer.WriteLine($"Год издания: {book.Year}");
                    writer.WriteLine("-------------------");
                }
            }
        }
    }
}
