using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание списка людей
            List<Person> people = new List<Person>
        {
            new Person("Борис", 30),
            new Person("Антон", 25),
            new Person("Глеб", 20),
            new Person("Ева", 35),
            new Person("Денис", 28)
        };

            // Сортировка списка людей по имени
            people.Sort();

            // Вывод отсортированного списка на экран
            Console.WriteLine("Отсортированный список людей по имени:");
            foreach (var person in people)
            {
                Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
            }

            Console.ReadKey();
        }
    }
}
