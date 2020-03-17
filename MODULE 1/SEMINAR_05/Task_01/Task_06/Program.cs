using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    class Program
    {
        static void ArrSqueeze(ref int[] a)
        {
            int m = 0;  // размер нового массива
            int k = 0;
            for (int i = 0; i < a.Length-1; i++)
                if ((a[i] + a[i + 1]) % 3 == 0)
                {
                    int multplctn = a[i] * a[i + 1];
                    a[i] = multplctn;
                    a[m++] = a[i];;
                    k++;
                    Console.WriteLine($"Количество успешно проведенных операций сжатия равно {k}");
                }
            if (m > 0) Array.Resize(ref a, m);
        }

        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Введите размер массива (целое число > 0)");
            while (!int.TryParse(Console.ReadLine(), out n));

            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-10, 10);
                Console.Write("{0,4}", a[i]);
            }

            Console.WriteLine();

                ArrSqueeze(ref a);

                for (int i = 0; i < a.Length; i++)
                    Console.Write("{0,4}", a[i]);
            Console.ReadLine();

            
        }
    }
}
