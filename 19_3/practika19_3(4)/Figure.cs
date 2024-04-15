using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_4_
{
    abstract class Figure : IComparable<Figure>
    {
        /// <summary>
        ///  абстрактный метод вычисления площади 
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateArea();
        /// <summary>
        /// абстрактные метод вычисления перимитра 
        /// </summary>
        /// <returns></returns>
        public abstract double CalculatePerimeter();
        /// <summary>
        /// абстрактный  метод вывода информации
        /// </summary>
        public abstract void PrintInfo();

        /// <summary>
        /// метод сравнения 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Figure obj)
        {
            if (obj == null) return 1;
            return this.CalculateArea().CompareTo(obj.CalculateArea());
        }
    }
}
