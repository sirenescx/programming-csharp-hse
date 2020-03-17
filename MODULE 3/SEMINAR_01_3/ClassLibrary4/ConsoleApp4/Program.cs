using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary4;

namespace ConsoleApp4
{
    delegate int Sample(int x);
    class random
    {
        public static int Method(int a)
        {
            return a++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] checkAr = new int[10];
            for (int i = 0; i < checkAr.Length; i++)
            {
                checkAr[i] = rand.Next(10, 100);
            }

             NumArray numArray = ar => Class1.NumToNumArray(ar);
           
            NumArrayWriteLine writeLine = new NumArrayWriteLine(Class1.NumArrayToString);
            writeLine(numArray(num));

            Sample sample = new Sample(random.Method);
            sample(num);
            Console.WriteLine(sample.Target);


            for (int i = 0; i < checkAr.Length; i++)
            {
                Console.WriteLine(checkAr[i]);
                writeLine(numArray(checkAr[i]));
            }

            Console.WriteLine(numArray.Target);
            Console.WriteLine(numArray.Method);
            Console.WriteLine(writeLine.Target);
            Console.WriteLine(writeLine.Method);
            Console.ReadKey();
        }
    }
}
