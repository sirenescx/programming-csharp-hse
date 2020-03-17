using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static double g(double x, double y)
        {
            double a = (x < y) ? ((x > 0) ? (x + Math.Sin(y)) : (0.5 * x * y)) : ((x > y) ? ((x < 0) ? (y - Math.Cos(x)) : (0.5 * x * y)) : (0.5 * x * y));
            return a;
        }

        static void Main()
        {
            double x;
            double y;
            do
            {
                Console.Write("Введите значение Х: ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("Введите значение Y: ");
                double.TryParse(Console.ReadLine(), out y);
                Console.WriteLine(g(x, y));
                Console.Write("нажмите любую клавишу для продолжения, ESC для выхода");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
