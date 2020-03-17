using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static int Max(int x)
        {
            int a, b, c, a1, b1, c1, max;
            a = x / 100;
            b = (x - a * 100) / 10;
            c = x - a * 100 - b * 10;
            a1 = a > b ? (a > c ? a : c) : (b > c ? b : c);
            c1 = a < b ? (a < c ? a : c) : (b < c ? b : c);
            b1 = a + b + c - a1 - c1;
            max = a1 * 100 + b1 * 10 + c1;
            return max;
        }

        static void Main() 
        {
            int p;
            Console.WriteLine("press ENTER to start");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                do Console.WriteLine("enter a three-digit number: ");
                while (!int.TryParse(Console.ReadLine(), out p) || (p < 100) || (p > 999));
                Console.WriteLine(Max(p));
                Console.WriteLine("press ESC to exit");
            }
        }
    }
}
