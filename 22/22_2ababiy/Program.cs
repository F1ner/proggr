using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_2ababiy
{
    
        struct Notebook
        {
            public string model;
            public string manufacturer;
            public decimal price;

            // Конструктор для инициализации полей
            public Notebook(string model, string manufacturer, decimal price)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.price = price;
            }

            // Метод для вывода содержимого полей на экран
            public void DisplayInfo()
            {
                Console.WriteLine("Модель: " + model);
                Console.WriteLine("Производитель: " + manufacturer);
                Console.WriteLine("Цена: " + price);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Создание экземпляра структуры с помощью конструктора
                Notebook myNotebook = new Notebook("MacBook Pro", "Apple", 2000);

                // Вывод содержимого полей на экран с помощью метода DisplayInfo
                myNotebook.DisplayInfo();

                Console.ReadKey();
            }
        }
    }

