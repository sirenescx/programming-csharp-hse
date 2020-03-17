using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfItems;
            do Console.Write("Введите размер массива: ");
            while (!int.TryParse(Console.ReadLine(), out numOfItems) ||
                                                                         numOfItems <= 0);
            char[] a = new char[numOfItems];

            Random generator = new Random();
            for (int i = 0; i < numOfItems; i++)
            {
                a[i] = (char)generator.Next('A', 'Z' + 1);
                Console.Write("{0,2}", a[i]); 
            }
            Console.WriteLine();

            char[] b = (char[])a.Clone();
            Array.Sort(b);

            foreach (char ch in b)
                Console.Write("{0,2}", ch);
            Console.WriteLine();
            Array.Reverse(b);
            foreach (char ch in b)
                Console.Write("{0,2}", ch);            Console.ReadLine();
        }
    }
}
