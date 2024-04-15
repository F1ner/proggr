using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika19_3
{
    public class Person : IComparable<Person>
    {
        /// <summary>
        /// свойство описывающее поле Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// свойство описывающее поле Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// конструктор с 2 параметрами
        /// </summary>
        /// <param name="name">поле описывающее имя</param>
        /// <param name="age">поле описывающее возраст</param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// метод реализации сравнения для сортировки по имени
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }

}
