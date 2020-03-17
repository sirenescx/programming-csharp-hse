using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static double Sum(int K)
        {
            double cur, sum;
            sum = 0;
            for (int n = 1; n <= K; n++)
            {
                cur = (K + 0.3) / (3 * Math.Pow(K, 2) + 5);
                sum += cur;
                Console.WriteLine(n + "    " + sum);
            }
            return 0;
        }
        static void Main()
        {
            int K;
            do
            {
                do Console.WriteLine("Введите целое неотрицательное число K"); while (!int.TryParse(Console.ReadLine(), out K));
                Sum(K);
                Console.WriteLine("Нажмите ESC для выхода, любую клавишу для продолжения");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
