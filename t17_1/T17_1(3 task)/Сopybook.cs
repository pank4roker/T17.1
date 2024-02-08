using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_3_task_
{
    /// <summary>
    /// Класс описывающий тетрадь
    /// </summary>
    class Copybook
    {
        /// <summary>
        /// Поля класса 
        /// </summary>
        string name;
        int countstr;
        /// <summary>
        /// Свойства класса
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        public int Countstr { get { return countstr; } set { countstr = value; } }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="countstr"></param>
        public Copybook(string name, int countstr)
        {
            this.Name = name;
            this.Countstr = countstr;
        }
        /// <summary>
        /// Методы 
        /// </summary>
        public void OutPut()
        {
            Write($"Название: {Name}\nКоличество страниц: {Countstr}\nЦена: {Cost()} руб.\n");
        }
        public int Cost()
        {
            return 15 * countstr;
        }

    }
}
