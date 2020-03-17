using System;
using System.Runtime.Remoting.Messaging;

namespace Task_05
{
    internal class Program
    {
        private static double InfSum()
        {
            var i = 1;
            // double d = 1,
            var sum = 0.0;
            // while (d > double.Epsilon)
            while (CountD(i) > double.Epsilon)
            {
                // d = 1.0 / (i * (i + 1) * (i + 2));
                // sum += d;
                sum += CountD(i);
                i++;
            }
            return sum;
        }
         private static double CountD(int i) => 1.0 / (i * (i + 1) * (i + 2));

        // private static double CountD(int i) => 1 / (i * (double)(i + 1) * (i + 2));
        // private static double CountD(int i) => 1 / ((double)i * (i + 1) * (i + 2));

        private static double CheckEquality(int i) => i * (double) (i + 1) * (i + 2);
        public static void Main()
        {
            //var sum = InfSum();
            var i = 1;
            var sum = 0.0;
            while (CountD(i) > double.Epsilon)
            {
                sum += CountD(i);
                i++;
            } 
            //Console.WriteLine(CountD(1290));
            Console.WriteLine($"Сумма бесконечного ряда равна {sum}");
            Console.ReadLine();
        }
    }
}
