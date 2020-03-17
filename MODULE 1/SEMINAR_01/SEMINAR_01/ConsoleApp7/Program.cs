using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Static.Console;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args) {
            int x, y;
            string inputStr = Console.ReadLine();
            int.TryParse(inputStr, out x);
            string inputStr2 = Console.ReadLine();
            int.TryParse(inputStr2, out y);
            Console.WriteLine("x - y = " + (x - y));
            Console.WriteLine("x * y = " + (x * y));
            Console.WriteLine("x / y = " + (x / y));
            Console.WriteLine("x % y = " + (x % y));
            Console.WriteLine("x >> y = " + (x >> y));
            Console.WriteLine("x << y = " + (x << y));
            Console.WriteLine("press Enter to escape");
            Console.ReadLine();



        }
    }
}
