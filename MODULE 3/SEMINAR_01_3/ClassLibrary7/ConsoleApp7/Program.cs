using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public delegate double Calc(double x, double y);
        static void Main(string[] args)
        {
            Calc add = (a, b) => a + b;
            Calc mult = (a, b) => a * b;

            double x = 1;
            double sum = 0;

            for (int i = 1; i < 6; ++i)
            {
                double result = 1;
                for (int j = 1; j < 6; ++j)
                {
                    result = mult(result, mult(i, x) / j);
                }
                sum = add(sum, result);
            }
            Console.WriteLine(sum);
        }
    }
}
