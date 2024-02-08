using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace T17_2_task_2_
{
    /// <summary>
    /// Класс описывающий журнал
    /// </summary>
    class Magazine : Press 
    {
        /// <summary>
        /// Поля класса и их свойства
        /// </summary>
        private string quality;

        public string Quality { get => quality; set => quality = value; }
        /// <summary>
        /// Конструктор
        /// </summary>
        public Magazine(int copies,string name,double price,string quality):base(copies,name,price) 
        { 
             this.quality = quality;
        }
        /// <summary>
        /// Метод высчитывающий стоимость и метод вывода
        /// </summary>
        new public double Cost()
        {
            if (Quality == "High") { return base.Cost() + (base.Cost()*0.1); }
            else if (Quality == "Mid") { return base.Cost(); }
            else { return base.Cost() - (base.Cost() * 0.1); }
        }
        new public void Output()
        {
            base.Output();
            WriteLine($"Quality: {Quality}\nNew cost: {Cost()}");
        }
    }
}
