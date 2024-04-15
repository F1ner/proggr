using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_4_
{
    class Circle : Figure
    {
        /// <summary>
        /// поле описывающее радиус
        /// </summary>
        private double radius;

        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="radius">поле описывающее радиус</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// переопределенный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        /// <summary>
        /// переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// переопределенный метод вывода информации
        /// </summary>
        public override void PrintInfo()
        {
            Console.WriteLine($"Circle: Radius = {radius}, Area = {CalculateArea()}, Perimeter = {CalculatePerimeter()}");
        }
    }
}
