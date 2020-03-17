using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleLib3;

namespace SampleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.bisec(-3, 7, 0.001, 0.001, Math.Cos));

            Console.WriteLine(Class1.Optimum_1(Math.Cos, 3, 6, 0.1, 0.0001));
            Class1.Functional_1 xpow3 = x => x * (x * x - 2) - 5;
            Console.WriteLine(Class1.Optimum_1(xpow3, 0, 1, 0.1, 0.0001));
            Class1.Functional_1 xsin = x => -Math.Sin(x) - Math.Sin(3 * x) / 3;
            Console.WriteLine(Class1.Optimum_1(xsin, 0, 1, 0.1, 0.0001));
            Console.ReadKey();
        }
    }
}
