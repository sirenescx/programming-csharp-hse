using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            //   Cast _nearestOddNumber = new Cast(Class1.NearestOddNumber);

            /* Cast _nearestOddNumber = delegate (double Param) 
             {
                 return Class1.NearestOddNumber(Param);
             }; */

            Cast _nearestOddNumber = Param => Class1.NearestOddNumber(Param);
            Cast _ord = new Cast(Class1.Ord);
            Console.WriteLine(_nearestOddNumber(num));
            Console.WriteLine(_ord(num));

            Cast cast = new Cast(Class1.Ord);
            cast += Class1.NearestOddNumber;

            Console.WriteLine(cast(num));
            Console.ReadKey();
            
        }
    }
}
