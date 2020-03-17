using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter value of U: ");
            double u, r;
            string i, p;
            string str1 = Console.ReadLine();
            double.TryParse(str1, out u);
            Console.WriteLine("Enter value of R: ");
            string str2 = Console.ReadLine();
            double.TryParse(str2, out r);
            i = (u / r).ToString("F2");
            p = (Math.Pow(u, 2) / r).ToString("F2");
            Console.WriteLine("Amperage = " + i);
            Console.WriteLine("Power = " + p);
            Console.WriteLine("press Enter to ESC");
            Console.ReadLine();

        }
    }
}
