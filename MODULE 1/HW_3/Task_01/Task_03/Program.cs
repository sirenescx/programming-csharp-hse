using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static double g(double x)
        {
            double a;
            a = (x > 0.5) ? (Math.Sin(Math.PI * (x - 1)) / 2) : (Math.Sin(Math.PI / 2));
            return a;
        }

        static void Main()
        {
            double x;
            do
            {
                Console.WriteLine("Введите значение Х: ");
                double.TryParse(Console.ReadLine(), out x);
                Console.WriteLine($"g(x) = {g(x)}");
                Console.WriteLine("Нажмите любую клавишу для продолжения, ESC для выхода");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
