using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            int x, sum, count;
            sum = 0;
            count = 0;
            do
            {
                do Console.WriteLine("Введите целое число: "); while (!int.TryParse(Console.ReadLine(), out x));
                Console.WriteLine("Хотите закончить ввод чисел? Нажмите Y, чтобы закончить и любую клавишу, чтобы продолжить");
                if (x < 0)
                {
                    sum += x;
                    count++;
                }
            } while ((Console.ReadKey().Key != ConsoleKey.Y) || (sum < -1000));
            Console.WriteLine("");
            Console.WriteLine($"Среднее арифметическое равно {sum * 1.0 / count}");
            Console.ReadLine();
        }
    }
}
