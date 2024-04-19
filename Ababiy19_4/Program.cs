using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy19_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание коллекции
            List<TourAgency> agencies = new List<TourAgency>
        {
                //заполнение коллекции
            new TourAgency("Firma1", 2000, "1234567890", 50000),
            new TourAgency("Firma2", 1995, "0987654321", 75000),
            new TourAgency("Firma3", 2010, "5678901234", 100000),
               new TourAgency("Firma4", 2009, "5678901234", 0),

        };
            // Вывод информации о всех фирмах
            Console.WriteLine("Информация о всех фирмах:");
            //цикл foreach для вывода всех обьектов коллекции
            foreach (var agency in agencies)
            {
                agency.DisplayInfo();
            }

            // Запрос пользователя для поиска информации о фирме
            Console.WriteLine("Введите название фирмы для поиска информации:");
            string searchName = Console.ReadLine();

            // Поиск фирмы по названию
            TourAgency foundAgency = agencies.Find(a => a.Name == searchName);

            // Если фирма найдена, выводим информацию
            if (foundAgency != null)
            {
                Console.WriteLine($"Информация о фирме {foundAgency.Name}:");
                Console.WriteLine($"ИНН:{foundAgency.INN}");
                Console.WriteLine($"Прибыль за текущий год:{foundAgency.CurrentYearProfit}");
            }
            else
            {
                Console.WriteLine($"Фирма с названием {searchName} не найдена.");
            }

            Console.WriteLine($"\n");

            // Вычисление суммарной прибыли всех фирм
            Console.WriteLine($"Суммарная прибыль всех фирм: {agencies.Sum(a => a.CurrentYearProfit)}");

            Console.WriteLine($"\n");

            //используем RemoveAll для удаления обьекта коллекции по определенному критерию(прибыли)
            agencies.RemoveAll(a => a.CurrentYearProfit <= 0);

            Console.WriteLine("Информация о фирмах после удаления обанкротившихся:");
            //вывод
            foreach (var agency in agencies)
            {
                agency.DisplayInfo();
            }

            // Создаем новый объект TourAgency для новой фирмы
            TourAgency newAgency = new TourAgency("Firma5", 2024, "9876543210", 20000);

            // Добавляем новую фирму в коллекцию
            agencies.Add(newAgency);

            Console.WriteLine("Информация о фирмах после добавления новой фирмы:");

            foreach (var agency in agencies)
            {
                agency.DisplayInfo();
            }


          

        // Затем используем метод Sort для сортировки
        agencies.Sort();

Console.WriteLine("Информация о фирмах после сортировки по размеру прибыли за текущий год:");

foreach (var agency in agencies)
{
    agency.DisplayInfo();
}


    Console.ReadKey();
        }
    }
}
