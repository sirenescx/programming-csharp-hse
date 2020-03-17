using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public delegate int MyDel(int x, int y);

    public static class TestClass
    {
        public static int TestMethod(int x, int y)
        {
            return Math.Max(x, y);
        }
   }
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            MyDel calc = (a, b) => TestClass.TestMethod(a, b);
            Console.WriteLine(calc(x, y));
            Console.ReadKey();

        }
    }
}
