using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    class Program
    {
        static void FormArr(ref double[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                a[i] = (i * (i + 1)) / 2.0 % n;
                Console.Write("{0,4}", a[i]);
            }
        }

        static void NormArr(ref double[] a)
        {
            double MaxValue = Math.Abs(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) > MaxValue) MaxValue = (Math.Abs(a[i]));
            }

            for (int i = 0; i < a.Length; i++)
                a[i] /= MaxValue;
        }

        static void OutputArr(double[] a)
        {
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++) Console.Write("{0:f3}    ", a[i]);
        }

        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Please enter the size of array");
            while (!int.TryParse(Console.ReadLine(), out n));
            double[] a = new double[n];
            FormArr(ref a, n);
            NormArr(ref a);
            OutputArr(a);
            Console.ReadLine();
        }
    }
}
