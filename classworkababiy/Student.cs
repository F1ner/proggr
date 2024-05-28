using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classworkababiy
{
    /// <summary>
    /// перечисления для гендера
    /// </summary>
    public enum Gender
    {
        Мужской,
        Женский
    }
   
    public class Student
    {
        /// <summary>
        /// Свойство для поля описывающего ПолноеИмя
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Свойство для поля описывающего ДатуРождения
        /// </summary>
        public int BirthYear { get; set; }
        /// <summary>
        /// Свойство для поля описывающего Гендер
        /// </summary>
        public Gender Gender { get; set; }   

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Student() { }
      
        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="fullName">ПОЛНОЕИМЯ</param>
        /// <param name="birthYear">ДАТАРОЖДЕНИЯ</param>
        /// <param name="gender">ГЕНДЕР</param>
        public Student(string fullName, int birthYear, Gender gender)
        {
            FullName = fullName;
            BirthYear = birthYear;
            Gender = gender;
        }

     /// <summary>
     /// Метод вывода информации
     /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {FullName}, Год рождения: {BirthYear}, Пол: {Gender}");
        }
    }
}
