using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Input(out int n)
        {
            do Console.WriteLine("Enter size of array (integer number > 0): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
        }

        static void FillArr(ref int[] a)
        {
            a[0] = 1;
            for (int i = 1; i < a.Length; i++)
                a[i] = a[i - 1] * 2;
        }

        static void OutputArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
        }
        static void Main(string[] args)
        {
            int n;
            Input(out n);
            int[] a = new int[n];
            FillArr(ref a);
            OutputArr(a);
            Console.ReadLine();
        }
    }
}
