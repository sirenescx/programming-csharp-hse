using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static long pow(long x)
        {
            long numb = 2;
            x--;
            while (x != 0)
            {
                numb <<= 1;
                x--;
            }
            return numb;

        }
        static void Main()
        {
            long n, m, res;
            Console.WriteLine("Введите степень n: ");
            long.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите степень m: ");
            long.TryParse(Console.ReadLine(), out m);
            res = pow(n) + pow(m);
            Console.WriteLine($"result = {res}");
            Console.ReadLine();
        }
    }
}
