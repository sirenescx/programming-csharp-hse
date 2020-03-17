using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static double QuEq(double a, double b, double c)
        {
            double d, x1, x2;
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0) Console.WriteLine("no real solutions exist");
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}", x1, x2);
            }
            return 0;
        }

        static void Main()
        {
            double a, b, c;
            Console.WriteLine("press ENTER to start");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("enter value of coefficient A: ");
                double.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("enter value of coefficient B: ");
                double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("enter value of coefficient C: ");
                double.TryParse(Console.ReadLine(), out c);
                QuEq(a, b, c);
                Console.WriteLine("press ESC to exit");
            }
        }
    }
}
