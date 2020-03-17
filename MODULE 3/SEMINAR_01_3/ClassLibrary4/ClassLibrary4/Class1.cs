using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public delegate int[] NumArray(int num);
    public delegate void NumArrayWriteLine(int[] ar);
    public class Class1
    {
        public static int[] NumToNumArray(int num)
        {
            int[] res = new int[num.ToString().Length];
            while (num != 0)
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = num % 10;
                    num /= 10;
                }
            return res;
        }

        public static void NumArrayToString(int[] ar)
        {
            Array.Reverse(ar);
            foreach (var item in ar) Console.Write($"\t{item}");
            Console.WriteLine();
        }
    }
}
