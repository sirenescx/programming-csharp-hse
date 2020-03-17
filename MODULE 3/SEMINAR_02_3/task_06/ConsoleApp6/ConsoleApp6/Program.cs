using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class Program
    {
     //   public static TOutput[] ConvertAll<TInput, TOutput> (TInput[] array, Converter<TInput, TOutput> converter)
        public static double[] ConvertAll<TInput, TOutput> (double[] array, Converter<TInput, TOutput> converter)
        {
            double[] ar = Array.ConvertAll(array, new Converter<double, double>(Norm));
            return ar;
        }
        public delegate double Converter<in TInput, out TOutput> (double input);
        public static void ForEach<T>(T[] array, Action<T> action)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return;
        }
        public delegate void Action<in T>(T obj);

        static double[] ar;

        static public double[] Norm(double[] ar)
        {
            double max = ar[0];

            for (int i = 1; i < ar.Length; i++)
                if (ar[i] > max) max = ar[i];

            for (int i = 0; i < ar.Length; i++)
                ar[i] /= max;

            return ar;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
