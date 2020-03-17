using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        public static int[,] MatrGen(int n)
            {
            int[,] matr = new int[n, n];
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                    matr[i, j] = (i + j) % n + 1;
            }
            return matr;
        }

        public static void ArChange(ref int[,] ar, int n)
        {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (i > n - j - 1) ar[i, j] = 0;
        }

        static void Main(string[] args)
        {
            int n;
            do Console.WriteLine("Enter the length of array");
            while (!int.TryParse(Console.ReadLine(), out n));

            int[,] matr = MatrGen(n);

            ArChange(ref matr, n);

            for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < matr.GetLength(1); j++)
                    Console.Write("{0,3}", matr[i, j]);

            Console.ReadLine();
        }
    }
}
