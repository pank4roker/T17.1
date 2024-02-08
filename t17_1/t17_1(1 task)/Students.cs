using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace t17_1
{
    /// <summary>
    /// Наследуемый класс описывающий студента
    /// </summary>
    class Students : Person
    {
        /// <summary>
        /// Поля и свойства класса
        /// </summary>
        private DateTime dateofbirth;

        private int course;

        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public int Course { get => course; set => course = value; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dateofbirth"></param>
        /// <param name="course"></param>
        public Students(int age, string name, string surname, DateTime dateofbirth, int course) : base(age, name, surname)
        {
            this.dateofbirth = dateofbirth; this.course = course;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        public new void Print()
        {
            base.Print();
            WriteLine($"Date of birth: {Dateofbirth}\nCourse: {Course}");
        }

    }
}
