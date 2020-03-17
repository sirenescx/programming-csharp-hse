using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Example ex = new Example();
            Row testRow = new Row(Example.fib);
            int[] test = testRow(n);
            Print testPrint = new Print(Example.printSum);
            testPrint += new Print(Example.Display);
            testPrint(test);

        }
    }
}
