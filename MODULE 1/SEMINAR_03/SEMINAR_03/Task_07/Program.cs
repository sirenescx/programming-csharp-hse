using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        static bool QuEq(double a, double b, double c, ref double x1, ref double x2)
        {

            double d;
            if ((a == b & b == c) || (a == b & c != 0))
                return false;
            else
            {
                d = Math.Pow(b, 2) - 4 * a * c;
                if (d < 0)
                    return false;
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    return true;
                }
            }


        }

        static void Main()
        {
            double a, b, c, x1, x2;
            x1 = 1;
            x2 = 0;
            do
            {
                Console.WriteLine("enter value of coefficient A: ");
                double.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("enter value of coefficient B: ");
                double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("enter value of coefficient C: ");
                double.TryParse(Console.ReadLine(), out c);
                if (QuEq(a, b, c, ref x1, ref x2) == false) Console.WriteLine("no real solutions exists");
                else
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}", x1, x2);
                Console.WriteLine("press ESC to exit");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
