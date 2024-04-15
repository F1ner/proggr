using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];
            figures[0] = new Rectangle(5, 4);
            figures[1] = new Circle(3);
            figures[2] = new Triangle(3, 4, 5);

           
            //сортирует фигуры по площади
            Array.Sort(figures);

        
            //выводит информацию о фигуре
            foreach (Figure figure in figures)
            {
                figure.PrintInfo();
            }
            Console.ReadKey();

        }
    }
}
