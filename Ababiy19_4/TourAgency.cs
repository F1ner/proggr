using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy19_4
{
    //класс Тур Агенство
    class TourAgency : IComparable<TourAgency>
    {
        /// <summary>
        /// свойство описывающее поле Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// свойство описывающее поле Год создания
        /// </summary>
        public int YearFounded { get; set; }
        /// <summary>
        /// свойство описывающее поле Иденфикационный номер
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// свойство описывающее поле Прибыль зат текущий год
        /// </summary>
        public double CurrentYearProfit { get; set; }

        /// <summary>
        /// конструктор с 4 параметрами
        /// </summary>
        /// <param name="name">поле описывающее имя</param>
        /// <param name="yearFounded">поле описывающее год создания</param>
        /// <param name="inn">поле описывающее иденфикационный номер</param>
        /// <param name="currentYearProfit">поле описывающее годовой доход</param>
        /// 

        public TourAgency() { }
        public TourAgency(string name, int yearFounded, string inn, double currentYearProfit)
        {
            this.Name = name;
            this.YearFounded = yearFounded;
            this.INN = inn;
            this.CurrentYearProfit = currentYearProfit;
        }

        /// <summary>
        /// метод вывода информации(получение информации о тур агенстве)
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Год основания: {YearFounded}");
            Console.WriteLine($"ИНН: {INN}");
            Console.WriteLine($"Прибыль за текущий год: {CurrentYearProfit}");
            Console.WriteLine();
        }

     
        /// <summary>
        /// метод CompareTO для сравнения прибыли фирм
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(TourAgency other)
        {
            // Сравниваем текущий объект с объектом other по размеру прибыли за текущий год
            return this.CurrentYearProfit.CompareTo(other.CurrentYearProfit);
        }
    }

   
    }


