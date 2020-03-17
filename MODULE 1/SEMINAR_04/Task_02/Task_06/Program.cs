using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{ 
    class Program
    {
        static int Factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }

        static double Sum1(int x)
        {
            double cur, sum;
            int n = 3;
            int pow = 1;
            cur = 1;
            sum = Math.Pow(x, 2);
            while (cur > double.Epsilon)
            {
                cur = Math.Pow(-1, pow)*((Math.Pow(2, n) * Math.Pow(x, n + 1))*1.0 / Factorial(n + 1));
                sum += cur;
                n += 2;
                pow++;
            }
            return sum;
        }

        static double Sum2(int x)
        {
            double cur, sum;
            cur = 1;
            sum = 1;
            int n = 1;
            while (cur > double.Epsilon)
            {
                cur = Math.Pow(x, n) / Factorial(n);
                sum += cur;
                n++; 
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int x;
            do
            {
                do Console.WriteLine("Введите число x"); while (!int.TryParse(Console.ReadLine(), out x));
                Console.WriteLine($"Сумма ряда 1 = {Sum1(x)}");
                Console.WriteLine($"Сумма ряда 2 = {Sum2(x)}");
                Console.WriteLine("Нажмите ESC для выхода, любую клавишу для продолжения");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
