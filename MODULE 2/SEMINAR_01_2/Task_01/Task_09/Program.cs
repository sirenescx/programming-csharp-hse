
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Program
    {
        public static void Input(out int m, out int n)
        {
            do Console.WriteLine("Please input size M of matrix A > 0");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0);
            do Console.WriteLine("Please input size N of matrix A > 0");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
        }

        public static int[][] GenArr(int n, int m)
        {
            int[][] Arr;
            Arr = new int[n + 1][];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = new int[rand.Next(1, m)];
                for (int j = 0; j < Arr[i].Length; j++)
                    Arr[i][j] = rand.Next(0, 100);
            }
            return Arr;
        }

        public static int[] MaxSumLine(int[][] Arr, out int max_sum)
        {
            int[] line = new int[Arr.GetLength(0)];
            for (int i = 0; i < line.GetLength(0); i++)
            line[i] = 0;
            int max_sum_cur = 0;
            max_sum = 0;
            foreach (int[] ar in Arr)
            {
                max_sum_cur = 0;
                foreach (int k in ar)
                    max_sum_cur += k;
                if (max_sum_cur > max_sum)
                {
                    max_sum = max_sum_cur;
                    line = ar;
                } 
            }
            return line;
        }

        public static int MaxElement(int[][] Arr)
        {
            int max_el = 0;
            foreach (int[] ar in Arr)
            {
                foreach (int k in ar)
                    if (k > max_el) max_el = k;
            }
            return max_el;

        }

        static Random rand = new Random();

        static void Main(string[] args)
        {
            int m, n;
            Input(out m, out n);
            int[][] Arr = GenArr(n, m);

            foreach (int[] ar in Arr)    
            {
                foreach (int k in ar)    
                    Console.Write("{0,4}", k);
                Console.WriteLine();
            }

            Console.WriteLine("Max Element of Array = " + MaxElement(Arr));
            int maxsum;
            int[] line = MaxSumLine(Arr, out maxsum);
            string s = string.Join(" ", line); 
            Console.WriteLine($"Line with maximum sum is {s}, sum = {maxsum}");
            Console.ReadLine();            






        }
    }
}
