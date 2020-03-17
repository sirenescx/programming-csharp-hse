
/*
 Манахова Мария
 БПИ184
 Вариант 2
 21.02.2019
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Jail jail = new Jail(10);
            Console.WriteLine(jail);
            jail.StartEscape();
            jail.StartEscape();
            Console.ReadKey();
        }
    }
}
