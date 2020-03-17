using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static Random rand = new Random();
        static Point[] FigArray()
        {
            int numCircle = rand.Next(0, 11);
            int numSquare = rand.Next(0, 11);
            Point[] points = new Point[numCircle + numSquare];
            for (int i = 0; i < points.Length; i++)
            {
                if (numCircle > 0)
                {
                    points[i] = new Circle(rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100));
                    numCircle--;
                }
                else
                {
                    points[i] = new Square(rand.Next(1, 100), rand.Next(1, 100), rand.Next(1, 100));
                    numSquare--;
                }
                    
            }
            return points;
        }
        static void Main(string[] args)
        {
            /* Point p = new Point();
             p.Display();
             Console.WriteLine("p.Area для Point = " + p.Area);
             p = new Circle(1, 2, 6);
             p.Display();
             Console.WriteLine("p.Area для Circle = " + p.Area);
             p = new Square(3, 5, 8);
             p.Display();
             Console.WriteLine("p.Area для Square = " + p.Area); */

            Point[] points = FigArray();
            int c = 0, s = 0;
            double Sc = 0, Ss = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] is Circle)
                {
                    c++;
                    Sc += points[i].Area;
                }
                else
                {
                    s++;
                    Ss += points[i].Area;
                }
                points[i].Display();
                Console.WriteLine($"S = {points[i].Area:f3}");
            }
            Console.WriteLine($"Number of Circle objects is {c}, average S is {Sc / c:f3}");
            Console.WriteLine($"Number of Square objects is {s}, average S is {Ss / s:f3}");

            SComparer sComparer = new SComparer();
            Array.Sort(points, sComparer);
            Console.WriteLine("");
            for (int i = 0; i < points.Length; i++) points[i].Display();
        }
    }
}
