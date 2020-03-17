/*Манахова Мария*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate double R(Point x, Point y);
    public class Point
    {
        double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static double calcR(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
        }

        public override string ToString() => $"x={x}, y={y}";
    }
}
