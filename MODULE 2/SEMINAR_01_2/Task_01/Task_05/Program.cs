using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        public static int[][] CGen(int n)
        {
            int[][] paskal;
            paskal = new int[n + 1][];
            for (int i = 0; i < paskal.Length; i++)
            {
                paskal[i] = new int[i + 1];
                paskal[i][0] = paskal[i][i] = 1;
                for (int j = 1; j < i; j++)
                    paskal[i][j] = paskal[i - 1][j - 1] + paskal[i - 1][j];
            }
            return paskal;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("N");
            int.TryParse(Console.ReadLine(), out n);
            int[][] paskal = CGen(n);

            foreach (int[] ar in paskal)    // перебор ссылок типа int[] 
            {
                foreach (int cnk in ar)     // перебор элементов типа int
                    Console.Write("{0,4}", cnk);
                Console.WriteLine();
            }


        }
    }
}
