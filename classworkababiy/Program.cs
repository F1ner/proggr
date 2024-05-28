using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworkababiy
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Введите колличество студентов:");
            int n = int.Parse(Console.ReadLine());
            // Ввод данных для каждого студента
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите данные для студента {i + 1}:");
                Console.Write("ФИО: ");
                string fullName = Console.ReadLine();

                Console.Write("Год рождения: ");
                int birthYear = int.Parse(Console.ReadLine());

                Console.Write("Пол (Мужской/Женский): ");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true );

                students.Add(new Student(fullName, birthYear, gender));
            }

            //Вывод информации о всех студентах
            Console.WriteLine("Информация о всех студентах:");
            foreach (var student in students)
            {
                student.PrintInfo();
            }

            //Вывод информации о мужчинах
            Console.WriteLine("\nИнформация о мужчинах:");
            foreach (var student in students)
            {
                if (student.Gender == Gender.Мужской)
                {
                    student.PrintInfo();
                }
            }

            //Вывод информации о женщинах
            Console.WriteLine("\nИнформация о женщинах:");
            foreach (var student in students)
            {
                if (student.Gender == Gender.Женский)
                {
                    student.PrintInfo();
                }
            }

            //Вывод информации по определенному номеру студента 
            Console.Write("\nВведите номер студента для получения информации: ");
            int studentNumber = int.Parse(Console.ReadLine());

            FindStudentByNumber(studentNumber, students);

            Console.ReadKey();
        }

        //метод для нахождения студента по определенному номеру в листе и его вывод(не вывод, если студента с таким номером нет)
        static void FindStudentByNumber(int number, List<Student> students)
        {
            if (number >= 1 && number <= students.Count)
            {
                Console.WriteLine("\nИнформация о студенте:");
                students[number - 1].PrintInfo();
            }
            else
            {
                Console.WriteLine("Студента с таким номером нет.");
            }
        }
    }
}

