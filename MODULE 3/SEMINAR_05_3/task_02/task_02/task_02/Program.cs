using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleComp triangle = new TriangleComp(0, 0, 0, 4, 3, 0);
            Point point = new Point(2, 1);
            Point point2 = new Point(10, 10);
            Console.WriteLine(triangle.Square);
            Console.WriteLine(triangle.isInside(point));
            Console.WriteLine(triangle.isInside(point2));
            Console.ReadKey();

        }
    }
}
