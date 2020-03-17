using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        public static int[,] ArGen(int n, int m)
        {
            int[,] ar = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    ar[i, j] = (i + 1) * (2 * j + 1);
            return ar;
        }

        public static void ArChange (ref int [,] ar, int n, int m)
        {
            if (n == m)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (i > n - j - 1) ar[i, j] = 0;
            }
            else return;
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("N");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("M");
            int.TryParse(Console.ReadLine(), out m);

            int[,] ar = ArGen(n, m);

            Console.WriteLine("ar.Length:  " + ar.Length);
            Console.WriteLine("ar.Rank:  " + ar.Rank);

            ArChange(ref ar, n, m);


            for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < ar.GetLength(1); j++)
                    Console.Write("{0,3}", ar[i, j]);
        }
    }
}
