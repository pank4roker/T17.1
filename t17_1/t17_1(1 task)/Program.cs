﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(15);
            person.Print();
            WriteLine();
            Person person1 = new Person(15, "Kirill");
            person1.Print();
            WriteLine();
            Person person2 = new Person(15, "Kirill", "Markow");
            person2.Print();
            WriteLine();
            Employee employee = new Employee(15, "Darya", "Ovcharuk", "DEX", "Programmer");
            employee.Print();
            WriteLine();
            Person person3 = new Employee(15,"n","n","n","n");
            person3.Print();
            WriteLine();
            Students student = new Students(15, "Kirill", "Markow", new DateTime(2007, 02, 12), 215);
            student.Print();
            ReadLine();
        }
    }
}
