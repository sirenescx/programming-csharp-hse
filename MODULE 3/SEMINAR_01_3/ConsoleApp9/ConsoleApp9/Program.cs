using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
   public class TestClass
    {
        public int TestMethod(double x, double y)
        {
            int px = (int)Math.Floor(x);
            int py = (int)Math.Floor(y);
            return px + py;
        }
    }
    class Program
    {
        public delegate int MyDel(double x, double y);
        static void Main(string[] args)
        {
            MyDel calc = (a, b) => new TestClass().TestMethod(a, b);
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(calc(x, y));
            Console.ReadKey();
        }
    }
}
