using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        public static void SumStolb(double[,] Matr)
        {
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                double sum = 0;
                for (int i = 0; i < Matr.GetLength(0); i++)
                    sum += Matr[i, j];
                    Console.WriteLine(sum);
            }
        }
        public static double[,] FormMatrix(int n, int m)
        {
            double[,] Matr = new double[n, m];
            Random rand = new Random();
            for (int i = 0; i < Matr.GetLength(0); i++)
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Matr[i, j] = rand.NextDouble() + rand.Next(0,13);
            return Matr;
        }

        public static void Input(out int n, out int m)
        {
            do Console.WriteLine("Input the value of N > 0");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            do Console.WriteLine("Input the value of M > 0");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0);
        }

            static void Main(string[] args)
        {
            int n, m;
            Input(out n, out m);
            double[,] Matr = FormMatrix(n, m);
            for (int i = 0; i < Matr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < Matr.GetLength(1); j++)
                    Console.Write($"{Matr[i, j]:f3}" + " ");
            Console.WriteLine();
            SumStolb(Matr);
        }
    }
}
