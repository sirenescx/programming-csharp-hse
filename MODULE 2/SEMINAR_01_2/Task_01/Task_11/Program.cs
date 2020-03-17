using System;
using System.Collections.Generic;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
           /* var n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                return;
            }
            int[] arr = new int[n];
            int current = int.Parse(Console.ReadLine());
            arr[0] = current;
            int index = 1;
            for (var i = 0; i < n - 1; ++i)
            {
                int el = int.Parse(Console.ReadLine());
                if (el != current)
                {
                    arr[index] = el;
                    current = el;
                    index++;
                }
            }

            for (var i = 0; i < index; ++i)
            {
                Console.WriteLine(arr[i]);
            } */

           var s1 = Console.ReadLine();
           var s1chars = s1.ToCharArray();
           Array.Sort(s1chars);
           s1 = new string(s1chars);
           var s2 = Console.ReadLine();
           var s2chars = s2.ToCharArray();
           Array.Sort(s2chars);
           s2 = new string(s2chars);
           Console.WriteLine(s1.Equals(s2) ? 1 : 0);
        }
    }
}
