using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Conus conus = new Conus(4, 0, 0, 0, 10);
            Console.WriteLine(conus);
            Console.WriteLine($"{conus.GetSection():f3}");
            Console.ReadKey();
        }
    }
}
