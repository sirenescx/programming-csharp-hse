using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static double f(double x)
        {
            return Math.Pow(x, 2);
        }

        static double MetTr(double delta, double A)
        {
            double sum = 0.0;
            int i = 0;
            do {
                sum += (f(i) + f(Math.Min(A, i + delta))) / 2 * Math.Min(delta, A - i);
                i++;
            }
            while (i < A);
                return sum;
        }
        static void Main()
        {
            double A;
            double delta;
            do Console.WriteLine("Введите значение вещественной точки: ");
            while (!double.TryParse(Console.ReadLine(), out A) || (A<=0));
            do Console.WriteLine("Введите значение шага интегрирования: ");
            while (!double.TryParse(Console.ReadLine(), out delta));
            Console.WriteLine("Площадь под графиком равна " + MetTr(delta, A));
            Console.ReadLine();
        }
    }
}
