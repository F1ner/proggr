using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person ilya = new Person(123, "Ilya");
            //Person max = new Person("max123", "Max");
            //int ilyaId = (int)ilya.Id;
            //string maxId = (string)max.Id;
            //Console.WriteLine(ilyaId);   //123
            //Console.WriteLine(maxId);   //max123

            //Person tom = new Person(546, "Tom");
            //string tomId = (string)tom.Id; //!Ошибка
            //Console.WriteLine(tomId);

            ////Person<int> tom = new Person(123, "Tom");
            ////Person<string> bob = new Person("123123", "Bob");
            ////int tomId = tom.Id;
            ////string bobId = bob.Id;
            ////Console.WriteLine(tomId);   // 123
            ////Console.WriteLine(bobId);   // 123123


            //// Создание объекта класса Book<int> с ценой типа int
            //Book<int> book1 = new Book<int>("Мертвые души", 1000);
            //book1.DisplayInfo();
            //Console.WriteLine("Меняем название-");
            //book1.SetTitle("3 Богатыря");
            //book1.DisplayInfo();

            //Console.WriteLine("Меняем цену-");
            //// Изменение цены книги через метод SetPrice с int параметром
            //book1.SetPrice(1200);
            //book1.DisplayInfo();

            //// Создание объекта класса Book<string> с ценой типа string
            //Book<string> book2 = new Book<string>("Евгений Онегин", "1500");
            //book2.DisplayInfo();
            //Console.WriteLine("Меняем название-");
            //book2.SetTitle("Иван Царевич и серый волк");
            //book2.DisplayInfo();

            //Console.WriteLine("Меняем цену-");
            //// Изменение цены книги через метод SetPrice с string параметром
            //book2.SetPrice("1700");
            //book2.DisplayInfo();

            // Первый объект с целыми параметрами
            Calculator<int> intCalculator = new Calculator<int>();

            // Параметры: 10 и 5
            Console.WriteLine($"Сложение: {intCalculator.Add(10, 5)}");
            Console.WriteLine($"Вычитание: {intCalculator.Subtract(10, 5)}");
            Console.WriteLine($"Умножение: {intCalculator.Multiply(10, 5)}");
            Console.WriteLine($"Деление: {intCalculator.Divide(10, 5)}");

            // Второй объект с целым и вещественным параметрами
            Calculator<double> doubleCalculator = new Calculator<double>();

            // Параметры: 10 (целое) и 5.5 (вещественное)
            Console.WriteLine($"Сложение: {doubleCalculator.Add(10, 5.5)}");
            Console.WriteLine($"Вычитание: {doubleCalculator.Subtract(10, 5.5)}");
            Console.WriteLine($"Умножение: {doubleCalculator.Multiply(10, 5.5)}");
            Console.WriteLine($"Деление: {doubleCalculator.Divide(10, 5.5)}");

            // Третий объект с целым и строковым параметрами
            Calculator<string> stringCalculator = new Calculator<string>();

            // Параметры: "10" (строка) и "5" (строка)
            Console.WriteLine($"Сложение: {stringCalculator.Add("10", "5")}");
            // Вычитание и умножение для строк не определены
            // Console.WriteLine($"Вычитание: {stringCalculator.Subtract("10", "5")}");
            // Console.WriteLine($"Умножение: {stringCalculator.Multiply("10", "5")}");
            // Деление для строк не определено
            // Console.WriteLine($"Деление: {stringCalculator.Divide("10", "5")}");

            Console.ReadKey();
        }
    }
}
