using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Input(out int n, out int a, out int d)
        {
            do Console.WriteLine("Please enter size of array (integer number > 0): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
            do Console.WriteLine("Please enter value of A (integer number)");
            while (!int.TryParse(Console.ReadLine(), out a));
            do Console.WriteLine("Please enter value of D (integer number)");
            while (!int.TryParse(Console.ReadLine(), out d));
        }

        public static int[] FormArr(int n, int a, int d)
        {
            int[] ar = new int[n];
            ar[0] = a;
            for (int i = 1; i < ar.Length - 1; i++)
                ar[i] = ar[i - 1] + i * d;
            ar[n - 1] = a + (n - 1) * d; 
            return ar;
        }

        static void Main(string[] args)
        {
            int n, a, d;
            Input(out n, out a, out d);
            int[] dat = FormArr(n, a, d);
            for (int i = 0; i < dat.Length; i++)
                Console.WriteLine("{0,4}", dat[i]);
            Console.ReadLine();

        }
    }
}
