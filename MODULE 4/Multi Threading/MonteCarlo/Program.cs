using System;

namespace MonteCarlo
{
    class Program
    {
        static bool Check(double x, double y)
        {
            return x * x + y * y <= 1;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (Check(rnd.NextDouble(), rnd.NextDouble()))
                    count++;
            }
            Console.WriteLine(4.0*count/n);
            Console.ReadLine();
        }
    }
}
