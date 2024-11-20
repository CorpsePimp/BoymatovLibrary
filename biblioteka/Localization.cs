using System.Collections.Generic;

namespace biblioteka
{
    internal static class Localization
    {
        public static string CurrentLanguage { get; set; } = "ru"; // Текущий язык (по умолчанию русский)

        private static Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>()
        {
            { "ru", new Dictionary<string, string>()
                {
                    { "Login", "Вход" },
                    { "Exit", "Выход" },
                    { "Username", "Имя пользователя" },
                    { "Password", "Пароль" },
                    { "LoginButton", "Войти" },
                    { "AddBook", "Добавить книгу" },
                    { "RemoveBook", "Удалить книгу" },
                    { "Search", "Поиск" },
                    { "ShowAllBooks", "Показать все книги" },
                    { "Import", "Импорт" },
                    { "Export", "Экспорт" },
                    { "Title", "Название" },
                    { "Author", "Автор" },
                    { "Year", "Год издания" },
                    { "Books", "Книги" },
                    { "LibraryManagement", "Управление библиотекой" },
                }
            },
            { "en", new Dictionary<string, string>()
                {
                    { "Login", "Login" },
                    { "Exit", "Exit" },
                    { "Username", "Username" },
                    { "Password", "Password" },
                    { "LoginButton", "Login" },
                    { "AddBook", "Add Book" },
                    { "RemoveBook", "Remove Book" },
                    { "Search", "Search" },
                    { "ShowAllBooks", "Show All Books" },
                    { "Import", "Import" },
                    { "Export", "Export" },
                    { "Title", "Title" },
                    { "Author", "Author" },
                    { "Year", "Year" },
                    { "Books", "Books" },
                    { "LibraryManagement", "Library Management" },
                }
            }
        };

        /// <summary>
        /// Возвращает перевод строки по ключу в зависимости от текущего языка.
        /// </summary>
        /// <param name="key">Ключ строки.</param>
        /// <returns>Переведённая строка или ключ, если перевод не найден.</returns>
        public static string Translate(string key)
        {
            if (translations.ContainsKey(CurrentLanguage) && translations[CurrentLanguage].ContainsKey(key))
            {
                return translations[CurrentLanguage][key];
            }
            return key; // Если перевод не найден, возвращаем ключ
        }

        /// <summary>
        /// Переключает язык между русским и английским.
        /// </summary>
        public static void ToggleLanguage()
        {
            CurrentLanguage = CurrentLanguage == "ru" ? "en" : "ru";
        }
    }
}
