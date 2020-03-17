using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        public const int R = 2;

        static bool g_logic(double x, double y)
        {
            if ((x * x + y * y <= R * R) & (x >= 0 & y <= x) | (x <= 0 & y >= 0))  return true;
            else
                return false;
        }

        static void Main()
        {
            double x;
            double y;
            do
            {
                Console.Write("Введите координату Х: ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("Введите координату Y: ");
                double.TryParse(Console.ReadLine(), out y);
                Console.WriteLine(g_logic(x, y));
                Console.ReadLine();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

