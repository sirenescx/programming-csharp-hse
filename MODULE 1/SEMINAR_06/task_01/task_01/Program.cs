/* 
 Манахова Мария
 БПИ184-1
 Вариант 14*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    class Program

    {
        static int Input(out int a, out int b)
        {
            Console.WriteLine("Введите границу A (0 < A < B): ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0)
                Console.WriteLine("Ошибка ввода, введите заново: ");
            Console.WriteLine("Введите границу B (0 < A < B): ");
            while (!int.TryParse(Console.ReadLine(), out b) || b < 0)
                Console.WriteLine("Ошибка ввода, введите заново: ");
            return 0;
        }

        static bool IsCullenNumber(int a, int b, ref int n)
        {
            for (n = 1; n <= 32; n++)
            {
                if ((a < n * Math.Pow(2, n)) && (n * Math.Pow(2, n) < b))
                    Console.WriteLine($"Число {n * Math.Pow(2, n) + 1} является числом Каллена и может быть вычислено при n={n}");
            }

            return false;
        }

        static void Main(string[] args)
        {
            int a, b, n;
            n = 1;
            do
            {
                Input(out a, out b);
                Console.WriteLine("Для выхода нажмите ESCAPE, для продолжения любую клавишу");
                IsCullenNumber(a, b, ref n);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
