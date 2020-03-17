using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task_03
{
    public class Fibbonacci
    {
        int s = 1, n = 0;
        public IEnumerable NextMemb(int limit)
        {
            int t;
            for (int i = 0; i < limit; i++)
            {
                t = s + n;
                s = n;
                yield return n = t;
            }
            s = 1;
            n = 0;
        }
    }

    public class TriangleNums
    {
        public IEnumerable NextMemb(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                yield return 1 * i * (i + 1) / 2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fibbonacci = new Fibbonacci();
            foreach (var item in fibbonacci.NextMemb(8))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            TriangleNums triangleNums = new TriangleNums();
            foreach (var item in triangleNums.NextMemb(8))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int i = 0;
            foreach (var item in fibbonacci.NextMemb(8))
            {
                int j = 0;
                foreach (var item_2 in triangleNums.NextMemb(8))
                {
                    int x = (int)item;
                    int y = (int)item_2;
                    if (i == j) Console.Write(x+y + " ");
                    j++;
                }
                i++;
            }

            Console.WriteLine();
            var triangleEnumerator = triangleNums.NextMemb(8).GetEnumerator();
            var fibbonaciEnumerator = fibbonacci.NextMemb(8).GetEnumerator();
            while (fibbonaciEnumerator.MoveNext() && triangleEnumerator.MoveNext())
            {
                int x = (int)triangleEnumerator.Current;
                int y = (int)fibbonaciEnumerator.Current;
                Console.Write(x + y + " ");
            }
        }
    }
}
