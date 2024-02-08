﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace t17_1
{
    /// <summary>
    /// Наследуемый класс описывающий сотрудника 
    /// </summary>
    class Employee : Person
    {
        /// <summary>
        /// Поля и свойства класса
        /// </summary>
        private string company;
        private string job;

        public string Company { get => company; set => company = value; }
        public string Job { get => job; set => job = value; }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="company"></param>
        /// <param name="job"></param>
        public Employee(int age, string name, string surname, string company, string job) : base(age, name, surname)
        {
            this.company = company; this.job = job;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        new public void Print()
        {
            base.Print();
            WriteLine($"Company: {Company}\nJob: {Job}");
        }
    }
}
