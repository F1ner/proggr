using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_4_
{
    class Triangle : Figure
    {
        /// <summary>
        /// поле описывающее сторону 1
        /// </summary>
        private double side1;
        /// <summary>
        /// поле описывающее сторону 2
        /// </summary>
        private double side2;
        /// <summary>
        /// поле описывающее сторону 3
        /// </summary>
        private double side3;

        /// <summary>
        /// коструктор с 3 параметрами
        /// </summary>
        /// <param name="side1">поле описывающее сторону 1 </param>
        /// <param name="side2">поле описывающее сторону 2 </param>
        /// <param name="side3">поле описывающее сторону3 </param>
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        /// <summary>
        /// переопределенный метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            // Using Heron's formula to calculate area of a triangle
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
        /// <summary>
        /// переопределенный метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }

        /// <summary>
        /// переопределенный метод вывода информации
        /// </summary>
        public override void PrintInfo()
        {
            Console.WriteLine($"Triangle: Side1 = {side1}, Side2 = {side2}, Side3 = {side3}, Area = {CalculateArea()}, Perimeter = {CalculatePerimeter()}");
        }
    }

}
