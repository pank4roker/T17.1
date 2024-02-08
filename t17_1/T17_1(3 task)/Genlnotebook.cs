using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_3_task_
{
   /// <summary>
   /// Наследуемый класс описывающий общую тетрадь 
   /// </summary>
    class Genlnotebook : Copybook
    {
        /// <summary>
        /// Поля и свойства класса
        /// </summary>
        string material;
        public string Material { get { return material; } set { material = value; } }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="countstr"></param>
        /// <param name="material"></param>
        public Genlnotebook(string name, int countstr,string material):base(name,countstr)
        {
            this.Material = material;
        }
        /// <summary>
        /// Модифицированные методы посчета цены и вывода
        /// </summary>
        /// <returns></returns>
        new public int Cost()
        {
            return base.Cost() + 50;
        }
        new public void OutPut()
        {
            base.OutPut();
            Write($"Материал обложки: {Material}\nЦена с учетом надбавки: {Cost()} руб.\n \n");
        }

    }
}
