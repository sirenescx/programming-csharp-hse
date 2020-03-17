using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        delegate double Sum(int n);
        delegate double Calc(int n);
        static void Main(string[] args)
        {
            Sum sum = x => 1.0 / Math.Pow(2, x);
            Calc calc = n =>
            {
                double _sum = 0;
                for (int i = 1; i < n; i++)
                    for (int j = 1; j < i; j++)
                        _sum += sum(j);
                return _sum;
            };
            Console.WriteLine(calc(5));
            Console.ReadKey();
        }
    }
}
