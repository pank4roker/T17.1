using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Press press = new Press(5, "", 460);
            press.Output();
            WriteLine();
            Magazine magazine = new Magazine(15, "", 2500, "High");
            magazine.Output();
            Press press1 = new Magazine(3,"fd",344,"Low");
            press.Output();
            ReadKey();
        }
    }
}
