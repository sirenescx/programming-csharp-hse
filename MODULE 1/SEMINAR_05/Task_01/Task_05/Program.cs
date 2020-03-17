using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
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

            int m = 0; // размер нового массива
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 != 0) a[m++] = a[i];
            if (m > 0) Array.Resize(ref a, m);

            Console.WriteLine();

           for (int i = 0; i < a.Length; i++)
           Console.Write("{0,4}", a[i]);

            Console.ReadLine();
        }
    }
}
