using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    class Program
    {
        static Random rand = new Random();

        public static int[,] CreateMatrix(int m, int n)
        {
            int[,] matr = new int[m, n];

            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    matr[i, j] = rand.Next(0, 10 + 1);
            return matr;
        }

        public static int[,] MatrixMult(int[,] MatrA, int[,] MatrB)
        {
            if (!(MatrA.GetLength(1) == MatrB.GetLength(0)))
            {
                return null;
            }
            else
            {
                int[,] MatrC = new int[MatrA.GetLength(0), MatrB.GetLength(1)];
                for (int i = 0; i < MatrC.GetLength(0); i++)
                    for (int j = 0; j < MatrC.GetLength(1); j++)
                        for (int k = 0; k < MatrB.GetLength(0); k++)
                            MatrC[i, j] += MatrA[i, k] * MatrB[k, j];
                return MatrC;
            }
        }

        public static void MatrixToString(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matr[i, j]);
                }
            }

            Console.WriteLine();
        }

        public static void Input(out int n, out int m, out int n1, out int m1)
        {
            do Console.WriteLine("Please input size M of matrix A > 0");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            do Console.WriteLine("Please input size N of matrix A > 0");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0);
            do Console.WriteLine("Please input size M of matrix B > 0");
            while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0);
            do Console.WriteLine("Please input size N of matrix B > 0");
            while (!int.TryParse(Console.ReadLine(), out m1) || m1 < 0);
        }
        static void Main(string[] args)
        {
            int n, m, n1, m1;
            Input(out n, out m, out n1, out m1);
            int[,] MatrA = CreateMatrix(m, n);
            int[,] MatrB = CreateMatrix(m1, n1);
            MatrixToString(MatrA);
            MatrixToString(MatrB);
            int[,] MatrC = MatrixMult(MatrA, MatrB);
            if (MatrC == null) Console.WriteLine("Multiplication between MatrixA and MatrixB is impossible");
            else MatrixToString(MatrC);
            Console.ReadLine();
        }
    }
}
