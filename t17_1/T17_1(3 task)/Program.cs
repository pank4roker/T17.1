using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_1_3_task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Copybook copybook = new Copybook("",15);
            copybook.OutPut();
            WriteLine();
            Genlnotebook genlnotebook = new Genlnotebook("",5,"Лилия");
            genlnotebook.OutPut();
            Copybook copybook1 = new Genlnotebook("", 4, "");
            copybook1.OutPut();
            ReadKey();
        }
    }
}
