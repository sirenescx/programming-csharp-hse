using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void tab(int a, int b, int c)
        {
            double x = 0.95;
            double delta = 0.05;
            double y;
            while (x < 1.2)
            {
                y = a * Math.Pow(x, 2) + b * x + c;
                x += delta;
                Console.WriteLine($"x = {x}     y = {y}");
            }

            while (x == 1.2)
            {
                y = a/x + Math.Sqrt(Math.Pow(x, 2) + 1);
                x += delta;
                Console.WriteLine($"x = {x}     y = {y}");
            }

            while ((x > 1.2) & (x <= 2))
            {
                y = (a + b * x) / Math.Sqrt(Math.Pow(x, 2) + 1);
                x += delta;
                Console.WriteLine($"x = {x}     y = {y}");
            }
        }

        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введите коэффициент а: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите коэффициент b: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите коэффициент c: ");
            int.TryParse(Console.ReadLine(), out c);
            tab(a, b, c);
            Console.ReadLine();
        }
    }
}
