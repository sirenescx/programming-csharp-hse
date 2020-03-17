using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args) {
            double a, b, c;
            string str1 = Console.ReadLine();
            double.TryParse(str1, out a);
            string str2 = Console.ReadLine();
            double.TryParse(str2, out b);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(c.ToString("F2"));
            Console.WriteLine("press Enter to ESC");
            Console.ReadLine();
        }
    }
}
