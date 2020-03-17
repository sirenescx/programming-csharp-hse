using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static double TrIn(double a, double b, double c)
        {
            string answer;
            answer = (a + b > c) ? ((a + c > b) ? ((b + c > a) ?
            ("the triangle inequality is satisfied") : ("the triangle inequality is not satisfied")) :
            ("the triangle inequality is not satisfied")) : ("the triangle inequality is not satisfied");
            Console.WriteLine(answer);
            return 0;
        }
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("press ENTER to start");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("enter length of side one: ");
                double.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("enter length of side two: ");
                double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("enter length of side three: ");
                double.TryParse(Console.ReadLine(), out c);
                TrIn(a, b, c);
                Console.WriteLine("press ESC to exit");
            }
        }
    }
}
