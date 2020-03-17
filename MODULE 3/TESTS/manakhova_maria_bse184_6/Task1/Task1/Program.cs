/*
 Манахова Мария
 БПИ184
 Вариант 6*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static Random rand = new Random();

        static int[][] GenerateArrayOfArrays(int M, int N)
        {
            int[][] Arr;
            int[] SumArI = new int[M];
            for (int i = 0; i < SumArI.GetLength(0); i ++)
            {
                SumArI[i] = 0;
            }
            Arr = new int[M][];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = new int[N];
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Arr[i][j] = rand.Next(-10, 11);
                    SumArI[i] += Arr[i][j];
                }
            }
           
            return Arr;
        }

        static int[] GetSumByI(int M, int N, int[][] Arr)
        {
            int[] SumArI = new int[M];
            for (int n = 0; n < SumArI.GetLength(0); n++)
                SumArI[n] = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                    if (Arr[i][j] > 0) SumArI[i] += Arr[i][j];
                }
                return SumArI;
        }

        static int GetSum(int[] arr, int[][] Arr, int M, int N)
        {
            int[] GetSumArr = GetSumByI(M, N, Arr);
            int Sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                Sum += GetSumArr[i];
            return Sum;
        }

        public static void Input(out int m, out int n)
        {
            do Console.WriteLine("Please input size M of array > 0");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0);
            do Console.WriteLine("Please input size N of array > 0");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
        }

        static void Main(string[] args)
        {
           int M, N;
            Input(out M, out N);
            int[][] Arr = GenerateArrayOfArrays(M, N);

            foreach (int[] ar in Arr)
            {
                foreach (int k in ar)
                    Console.Write("{0,4}", k);
                Console.WriteLine();
            }

            Console.WriteLine(); 
            int[] arr = GetSumByI(M, N, Arr);

            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                Console.Write("{0,4}", arr[i]);

            Console.WriteLine();
            Console.WriteLine($"sum = {GetSum(arr, Arr, M, N)}");
            Console.ReadLine();
        }
    }
}
