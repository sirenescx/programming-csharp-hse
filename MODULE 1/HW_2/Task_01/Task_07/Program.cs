using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        static double drobn_cel(double x)
        {
            int cel;
            double drobn;
            cel = (int)x;
            drobn = x - cel;
            Console.WriteLine($"Целая часть числа равна {cel}");
            Console.WriteLine($"Дробная часть числа равна {drobn}");
            return 0;
        }

        static double sqrt_sqr(double x)
        {
            double sqrt, sqr;
            sqrt = Math.Sqrt(x);
            sqr = Math.Pow(x, 2);
            Console.WriteLine($"Корень из числа равен {sqrt}");
            Console.WriteLine($"Квадрат числа равен {sqr}");
            return 0;
        }

        static void Main()
        {
            double x;
            do
            {
                do Console.WriteLine("Введите число: ");
                while (!double.TryParse(Console.ReadLine(), out x));
                drobn_cel(x);
                sqrt_sqr(x);
                Console.WriteLine("Для выхода нажмите Escape, для продолжения любую клавишу");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
