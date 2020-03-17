using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct CircleS : IComparable<CircleS>
    {
        double rad;
        PointS center;

        public CircleS(double rad, double x, double y) : this()
        {
            this.rad = rad;
            center = new PointS(x, y);
        }

        public double getLength{ get => 2 * Math.PI * rad; }
        public double Rad { get => rad; set => rad = value; }
        public PointS Center { get => center; set => center = value; }

        public override string ToString() => $"Center({center.X:f3}, {center.Y:f3}), R = {rad:f3}, Length = {getLength:f3}";

        public int CompareTo(CircleS anotherCircle)
        {
            if (this.rad > anotherCircle.rad) return 1;
            else if (this.rad < anotherCircle.rad) return -1;
            return 0;
        }
    }
}
