using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1ababiy
{
    class Program
    {
        public class MyClass
        {
            public string change;
        }

        public struct MyStruct
        {
            public string change;
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            // Создание экземпляра класса
            MyClass myClassInstance = new MyClass();
            // Создание экземпляра структуры
            MyStruct myStructInstance = new MyStruct();

            // Изменение значений полей на "не изменено"
            myClassInstance.change = "не изменено";
            myStructInstance.change = "не изменено";

            // Вызов метода для класса
            ClassTaker(myClassInstance);
            // Вызов метода для структуры
            StruktTaker(myStructInstance);

            // Вывод значений полей экземпляров
            Console.WriteLine("Для класса MyClass: " + myClassInstance.change);
            Console.WriteLine("Для структуры MyStruct: " + myStructInstance.change);

            Console.ReadKey();
        }
    }
}
