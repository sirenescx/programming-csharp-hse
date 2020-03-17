using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Pifagor()
        {
            int a, b, c;
            for (a = 1; a <= 20; a++)
            {
                for (b = 1; b <= 20; b++)
                {
                    for (c = 1; c <= 20; c++)
                    {
                        if ((a != b) & (b != c) & (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))) 
                            Console.WriteLine($"{a}, {b}, {c}");
                    }
                }
            }
        }
        static void Main()
        {
            Pifagor();
            Console.ReadLine();
        }
    }
}
