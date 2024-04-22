using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    using System;

    public class Calculator<T>
    {
        /// <summary>
        /// метод сложения с 2 параметрами типа T
        /// </summary>
        /// <param name="a">поле описывающее переменную a</param>
        /// <param name="b">поле описывающее переменную b</param>
        /// <returns></returns>
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
        /// <summary>
        /// метод вычитания с 2 параметрами типа T
        /// </summary>
        /// <param name="a">поле описывающее переменную a</param>
        /// <param name="b">поле описывающее переменную b</param>
        /// <returns></returns>
        public T Subtract(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        /// <summary>
        /// метод умножения с 2 параметрами типа T
        /// </summary>
        /// <param name="a">поле описывающее переменную a</param>
        /// <param name="b">поле описывающее переменную b</param>
        /// <returns></returns>
        public T Multiply(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }

        public T Divide(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }

    }

}
