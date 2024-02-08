using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace t17_1
{
    /// <summary>
    /// Класс описывающий человека
    /// </summary>
    class Person
    {
        /// <summary>
        /// Поля и свойства класса
        /// </summary>
        private int age;

        private string name;

        private string surname;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// Конструкторы с +3 перегрузками 
        /// </summary>
        public Person() { }
        public Person(int age)
        {
            this.age = age;
        }
        public Person(int age, string name) : this(age)
        {
            this.name = name;
        }
        public Person(int age, string name, string surname) : this(age, name)
        {
            this.surname = surname;
        }
        /// <summary>
        /// Метод вывода 
        /// </summary>
        public void Print()
        {
            WriteLine($"Age: {Age}\nName: {Name}\nSurname: {Surname}");
        }

    }

}
