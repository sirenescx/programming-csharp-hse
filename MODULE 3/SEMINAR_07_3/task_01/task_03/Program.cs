using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structures;

namespace task_03
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            CircleS[] circles = new CircleS[10];
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new CircleS(rand.Next(0, 5) + rand.NextDouble(), rand.Next(-5, 5) + rand.NextDouble(), rand.Next(-5, 5) + rand.NextDouble());
            }

            /*    Console.WriteLine("Array: ");
                foreach (var circle in circles)
                {
                    Console.WriteLine(circle);
                }

                Array.Sort(circles);

                Console.WriteLine("\nSorted array: ");
                foreach (var circle in circles)
                {
                    Console.WriteLine(circle);
                } */

            double[] keys = new double[circles.Length];

            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = circles[i].Center.distance(circles[i].Center, new PointS(0, 0));
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine(circles[i] + " Расстояние от центра до начала координат: " + $"{keys[i]:f3}");
            }

            Array.Sort(keys, circles);
            Console.WriteLine("\nSorted array: ");
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine(circles[i] + " Расстояние от центра до начала координат: " + $"{keys[i]:f3}");
            }

            Console.ReadKey();
        }
    }
}
