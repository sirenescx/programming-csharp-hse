using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle
    {

        double rad;
        public Point center;

        public Circle(double rad, double x, double y)
        {
            this.rad = rad;
            center = new Point(x, y);
        }

        public double Rad { get => rad; set => rad = value; }

        public override string ToString() => $"R={rad}, O=({center.X}, {center.Y})";

    }
}
