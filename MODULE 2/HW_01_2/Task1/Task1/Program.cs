using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Input(out int n, out int m, out int k)
        {
            do Console.WriteLine("Input the value of N > 0");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            do Console.WriteLine("Input the value of M > 0");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0);
            do Console.WriteLine("Input the value of 0 <= K < N");
            while (!int.TryParse(Console.ReadLine(), out k) || k <= 0 || k > n);
        }

        public static int[,] FormMatrix(int n, int m)
        {
            int[,] Matr = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < Matr.GetLength(0); i++)
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Matr[i, j] = rand.Next();
            return Matr;
        }

        public static void LineKMult_Sum(int[,] Matr, int k)
        {
            long mult = 1;
            int sum = 0;
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                mult *= Matr[k, j];
                sum += Matr[k, j];
            }
            Console.WriteLine($"Sum of k line elements is {sum}");
            Console.WriteLine($"Multiplication of k line elements is {mult}");
        }

        static void Main(string[] args)
        {
            int n, m, k;
            Input(out n, out m, out k);
            int[,] Matr = FormMatrix(n, m);
            for (int i = 0; i < Matr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Console.Write(Matr[i, j] + " ");
            Console.WriteLine();
                    LineKMult_Sum(Matr, k);
        }
    }
}
