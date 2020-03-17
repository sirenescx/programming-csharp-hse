using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static double F(double x)
        {
            double f;
            f = 3 * x * x * (x * (4 * x + 3) - 1) + 2 * (x - 2);
            return f;
        }

        static void Main()
        {
            double x;
            Console.WriteLine("press ENTER to start");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("enter value of x: ");
                double.TryParse(Console.ReadLine(), out x);
                Console.WriteLine(F(x));
                Console.WriteLine("press ESC to exit");
            }
        }
    }
}
