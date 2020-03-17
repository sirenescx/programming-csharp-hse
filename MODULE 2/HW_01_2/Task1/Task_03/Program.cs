using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        public static int[,] FormArray(int n, int m)
        {
            int[,] Arr = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Arr[i, j] = rand.Next(0, 100);
            return Arr;
        }

        public static int SumStolb(int[,] Arr, int j)
        {
            int sum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
                    sum += Arr[i, j];
            return sum;
        }

        public static int[] SortArray(int[,] Arr)
        {
            int len = Arr.GetLength(1);
            int[] index = new int[len];
            for (int i = 0; i < len; i++)
                index[i] = i;

            for (int i = 0; i < len - 1; i++)
                for (int j = i + 1; j < len; j++)
                    if (SumStolb(Arr, index[i]) > SumStolb(Arr, index[j]))
                    {
                        int temp = index[i];
                        index[i] = index[j];
                        index[j] = temp;
                    }
            return index;
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
            int[,] Arr = FormArray(n, m);
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < Arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < Arr.GetLength(1); j++)
                    Console.Write("{0,3}", Arr[i, j]);
            Console.WriteLine("Отсортированный массив");
            int[] index = SortArray(Arr);
            for (int i = 0; i < Arr.GetLength(0); i++, Console.WriteLine())
                foreach (int j in index)
                    Console.Write("{0,3}", Arr[i, j]);
        }
    }
}
