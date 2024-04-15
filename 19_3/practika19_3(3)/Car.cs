using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_3_
{
    public class Car : IComparable<Car>
    {

        /// <summary>
        /// Свойство описывающее поле индефикатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Свойство описывающее поле марка
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Свойство описывающее поле максимальная скорость
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Свойство описывающее поле цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Свойство описывающее поле скидку в % 
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Car() { }
        /// <summary>
        /// конструктор с 5 параметрами
        /// </summary>
        /// <param name="id">поле описывающее индефикатор</param>
        /// <param name="brand">поле описывающее марку</param>
        /// <param name="maxSpeed">поле описывающее максимальную скорость</param>
        /// <param name="price">поле описывающее цену</param>
        /// <param name="discount">поле описывающее скидку в %</param>
        public Car(int id, string brand, int maxSpeed, double price, double discount)
        {
            this.Id = id;
            this.Brand = brand;
            this.MaxSpeed= maxSpeed;
            this.Price = price;
            this.Discount = discount;
        }


        /// <summary>
        /// Метод описывающий реализацию  сравнения для сортировки по стоимости
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Car obj)
        {
            // Вычисляем окончательную цену с учетом скидки
            double finalPriceThis = Price * (1 - Discount / 100);
            double finalPriceOther = obj.Price * (1 - obj.Discount / 100);

            // Сравниваем окончательные цены
            return finalPriceThis.CompareTo(finalPriceOther);
        }
    }

}
