using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание списка автомобилей
            List<Car> cars = new List<Car>
        {
            new Car(1, "Toyota", 180, 25000, 10),
            new Car(2, "BMW", 220, 40000, 5),
            new Car(3, "Honda", 170, 22000, 8),
            new Car(4, "Audi", 200, 35000, 7),
            new Car(5, "Ford", 160, 20000, 12)
        };

            // Сортировка списка автомобилей по стоимости
            cars.Sort();

            // Вывод отсортированного списка на экран
            Console.WriteLine("Отсортированный список автомобилей по стоимости:");
            foreach (var car in cars)
            {
                double finalPrice = car.Price * (1 - car.Discount / 100);
                Console.WriteLine($"Марка: {car.Brand}, Стоимость со скидкой: {finalPrice}");
            }


            Console.ReadKey();
        }
    }
}
