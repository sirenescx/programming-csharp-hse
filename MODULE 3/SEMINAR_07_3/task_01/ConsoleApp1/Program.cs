using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 9, 16, 25 };
            List<int> list = new List<int>(arr);
            list.AddRange(arr);
            list.Remove(25); list.Reverse();
            Console.WriteLine(list[5]);
        }
    }
}
