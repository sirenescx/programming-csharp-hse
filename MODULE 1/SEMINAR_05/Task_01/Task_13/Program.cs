using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Input(out int n)
        {
            do Console.WriteLine("Please enter size of array (integer number > 0): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
        }

        static int[] FormArr(int n)
        {
            int[] a = new int[n];
            a[0] = 1;
            a[1] = a[0];
            for (int i = 2; i < a.Length; i++)
                a[i] = a[i - 1] + a[i - 2];
            return a;
        }

            static void Main(string[] args)
        {
            int n;
            Input(out n);
            int[] ar = FormArr(n);
            for (int i = ar.Length - 1; i >= 0; i--)
                Console.WriteLine(ar[i]);
            Console.ReadLine();

        }
    }
}
