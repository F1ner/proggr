using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2_1_
{
    class Triangle<T>
    {
        /// <summary>
        /// поле описывающее сторону А
        /// </summary>
        private T sideA;
        /// <summary>
        /// поле описывающее сторону Б
        /// </summary>
        private T sideB;
        /// <summary>
        /// поле описывающее сторону Ц
        /// </summary>
        private T sideC;

        /// <summary>
        /// конструктор с 3 параметрами
        /// </summary>
        /// <param name="a">параметр описывающий поле а</param>
        /// <param name="b">параметр описывающий поле б</param>
        /// <param name="c">параметр описывающий поле ц</param>
        public Triangle(T a, T b, T c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        /// свойство описывающее поле А
        /// </summary>
        public T SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        /// <summary>
        /// свойство описывающее поле Б
        /// </summary>
        public T SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        /// <summary>
        /// свойство описывающее поле Ц
        /// </summary>
        public T SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        /// <summary>
        /// Метод вывода информации о треугольнике
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"Triangle sides: {sideA}, {sideB}, {sideC}");
        }

        /// <summary>
        /// Метод возвращающий площадь треугольника
        /// </summary>
        /// <returns>площадь(area)</returns>
        public double GetArea()
        {
            dynamic a = sideA;
            dynamic b = sideB;
            dynamic c = sideC;

            dynamic p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
