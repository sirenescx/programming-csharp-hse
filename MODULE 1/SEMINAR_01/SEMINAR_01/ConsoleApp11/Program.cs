using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args) {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            Console.WriteLine($"- {a} -\n- {b} -\n- {c} - ", a, b, c);
            Console.WriteLine("press Enter to escape");
            Console.ReadLine();
        }
    }
}
