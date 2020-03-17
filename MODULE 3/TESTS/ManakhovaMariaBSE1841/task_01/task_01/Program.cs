using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace task_01
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0))
                Console.WriteLine("Введите целое число N - количество элментов в массиве");
            Vector[] ar = new Vector[n];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = new Vector(new Dot(rnd.Next(-10, 10) + rnd.NextDouble(), rnd.Next(-10, 10) + rnd.NextDouble()));
            }

            foreach (var item in ar)
            {
                Console.WriteLine(item + " Модуль вектора = " + $"{item.CalcModule:f3}");
            }

            int minLengthVectorIndex = -1;
            double minLength = double.MaxValue;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i].CalcModule < minLength)
                {
                    minLength = ar[i].CalcModule;
                    minLengthVectorIndex = i;
                }
            }

            Console.WriteLine("Вектор с минимальной длиной: " + ar[minLengthVectorIndex] + ". Длина = " + $"{ar[minLengthVectorIndex].CalcModule:f3}");
            Console.ReadKey();
       
        }
    }
}
