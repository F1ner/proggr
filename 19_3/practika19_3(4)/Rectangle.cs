using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_4_
{
    class Rectangle : Figure
    {
        /// <summary>
    /// поле описывающее длину
    /// </summary>
        private double length;
        /// <summary>
        /// поле описывающее ширину
        /// </summary>
        private double width;

        /// <summary>
        /// конструктор с двумя параметрами 
        /// </summary>
        /// <param name="length">поле описывающее длину</param>
        /// <param name="width">поле описывающее ширину</param>
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }


        /// <summary>
        /// переопределенный метод вычисления площади 
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return length * width;
        }

        /// <summary>
        /// переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        /// <summary>
        /// переопределенный метод вывода информации
        /// </summary>
        public override void PrintInfo()
        {
            Console.WriteLine($"Rectangle: Length = {length}, Width = {width}, Area = {CalculateArea()}, Perimeter = {CalculatePerimeter()}");
        }
    }
}
