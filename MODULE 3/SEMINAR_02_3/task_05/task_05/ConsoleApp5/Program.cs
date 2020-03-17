using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    delegate bool Sorting(int x, int y);
    class Series
    {
        public int[] ar;

        public Series(int[] ar)
        {
            this.ar = ar;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public bool _ifFirstIsGreaterThanSecond(int x, int y)
        {
            if (x > y) return true;
            else return false;
        }

        public bool _isEven(int x, int y)
        {
            if ((x % 2 != 0) & (y % 2 == 0)) return true;
            else return false;
        }

        public int[] Order (int[] ar)
        {
            //  Sorting sortXY = (x, y) => _ifFirstIsGreaterThanSecond(x, y);
            Sorting sortXY = (x, y) => _isEven(x, y);
            for (int j = 0; j < ar.Length - 1; ++j)
            for (int i = j; i < ar.Length; i++)
            {
                if (sortXY(ar[i], ar[j])) Swap(ref ar[i], ref ar[j]); 
            }
            return ar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Series test = new Series(new int[] { 1, 4, 0, 9, 6 });
            test.Order(test.ar);
            foreach (var item in test.ar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
