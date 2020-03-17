using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args) {
            double a, b;
            string str1 = Console.ReadLine();
            double.TryParse(str1, out a);
            string str2 = Console.ReadLine();
            double.TryParse(str2, out b);
            a = a - (int)a;
            b = b - (int)b;
            Console.WriteLine(a + b);
            Console.WriteLine("press Enter to escape");
            Console.ReadLine();


            

        }
    }
}
