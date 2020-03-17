
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Program
    {
        static void ChangeArr(ref int[] a, int x)
        {
            int MaxEl = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > MaxEl) MaxEl = a[i];

            for (int i = 0; i < a.Length; i++)
                if (a[i] == MaxEl) a[i] = x; 

        }

        static void Input(out int n, out int x)
        {
            do Console.WriteLine("Please input size of array: ");
            while (!int.TryParse(Console.ReadLine(), out n));

            do Console.WriteLine("Please input integer number: ");
            while (!int.TryParse(Console.ReadLine(), out x));
        }
        static void Main(string[] args)
        {
            int n;
            int x;
            Input(out n, out x);
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-10, 10);
                Console.Write("{0,4}", a[i]);
            }
            ChangeArr(ref a, x);
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Console.ReadLine();
        }
    }
}
