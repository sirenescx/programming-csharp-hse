using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle
    {
        double rad;
        Point center;

        public Circle(double rad, double x, double y)
        {
            this.rad = rad;
            center = new Point(x, y);
        }

        public double Rad { get => rad; set => rad = value; }
        public Point Center { get => center; set => center = value; }
        public override string ToString() => $"Base radius = {rad}, base center({center.X}, {center.Y}), ";
    }
}
