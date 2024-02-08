using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T17_2_task_2_
{
    /// <summary>
    /// Класс описывающий печатную продукцию
    /// </summary>
    class Press
    {
        /// <summary>
        /// Поля и свойства класса
        /// </summary>
        private int copies;
        private string name;
        private double price;

        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        /// <summary>
        /// Методы вычисления цены и вывод информации
        /// </summary>
        /// <returns></returns>
        public double Cost()
        {
            return price * copies;
        }
        public void Output()
        {
            WriteLine($"Copies: {Copies}\nName: {Name}\nPrice: {Price}\nCost: {Cost()}");
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="copies"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Press(int copies, string name, double price)
        {
            this.copies = copies; this.name = name; this.price = price;
        } 

    }
}
