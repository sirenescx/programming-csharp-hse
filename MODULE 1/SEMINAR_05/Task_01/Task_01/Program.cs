using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void ReturnSinArr1(int n, ref double[] a)         ///метод для подсчета членов ряда в количестве N
        {
            const double x = 1.0;
            double newx;
            newx = x;
            for (int i = 0; i < n; i++)
            {
                a[i] = newx;
                newx *= -x * x / 2 / (i + 1) / (2 * (i + 1) + 1); 
            }
        }

        static double ReturnSinArrX(double x, ref double[] a)    ///метод для подсчета синуса введенного угла
        {
            double sin = 0;
            double cur = x;
            foreach (var i in a)
            {
                sin += i * cur;
                cur *= x * x;
            }
            return sin;
        }

        public static void Main()
        {
            double angle, // Введенный угол в радианах
                   x; // Аргумент x (приведенный угол)

            do
            {
                do Console.Write("Введите значение угла в радианах: ");
                while (!double.TryParse(Console.ReadLine(), out angle));
                x = angle % (2 * Math.PI);
                int n;
                do Console.Write("Введите размер массива: ");
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
                double[] a = new double[n];
                ReturnSinArr1(n, ref a);
                Console.WriteLine(ReturnSinArrX(x, ref a));
                Console.WriteLine(Math.Sin(x));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
