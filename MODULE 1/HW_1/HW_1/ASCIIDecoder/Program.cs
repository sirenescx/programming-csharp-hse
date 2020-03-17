using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args) {
            int x;
            string str = Console.ReadLine();
            int.TryParse(str, out x);
            char n = (char)x;
            Console.WriteLine(n);
            Console.WriteLine("press Enter to ESC");
            Console.ReadLine();
        }
    }
}
