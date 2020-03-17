using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot dot = new Dot(3, 5);
            Circle circle = new Circle(dot, 4);
            Console.WriteLine("Xmin = " + circle.GetMinX() + ", " + "Xmax = " + circle.GetMaxX());
            dot.CoordinateChanged += circle.OnSideChanged;
            dot.X = 10;
            dot.Y = 7;
            Console.ReadKey();
        }
    }
}
