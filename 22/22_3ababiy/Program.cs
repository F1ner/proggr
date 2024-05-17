using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_3ababiy
{
    struct Book
    {
        public string title;
        public string authorFullName;
        public int yearOfPublication;
        public int numberOfPages;

        // Конструктор для инициализации полей
        public Book(string title, string authorFullName, int yearOfPublication, int numberOfPages)
        {
            this.title = title;
            this.authorFullName = authorFullName;
            this.yearOfPublication = yearOfPublication;
            this.numberOfPages = numberOfPages;
        }

        // Метод для вывода информации об объекте
        public void DisplayInfo()
        {
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Автор: " + authorFullName);
            Console.WriteLine("Год издания: " + yearOfPublication);
            Console.WriteLine("Количество страниц: " + numberOfPages);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Задаем количество книг в массиве
            int n = 3;

            // Создаем массив книг
            Book[] books = new Book[n];

            // Инициализируем книги
            books[0] = new Book("Война и мир", "Лев Толстой", 1869, 1225);
            books[1] = new Book("Преступление и наказание", "Федор Достоевский", 1866, 331);
            books[2] = new Book("Гарри Поттер и философский камень", "Дж. К. Роулинг", 1997, 223);

            // Выводим информацию обо всех книгах
            foreach (var book in books)
            {
                book.DisplayInfo();
            }

            Console.ReadKey();
        }
    }
}
