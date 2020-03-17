using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Triangle
    {
        public Point _a;
        public Point _b;
        public Point _c;

        public Triangle()
        {
        }

        public Triangle(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Perimeter
        {
            get
            {
                double ab = _a.DistanceBetweenPoints(_b._x, _b._y);
                double bc = _b.DistanceBetweenPoints(_c._x, _c._y);
                double ca = _c.DistanceBetweenPoints(_a._x, _a._y);
                if ((ab + bc <= ca) || (ab + ca <= bc) || (bc + ca <= ab))
                    return 0;
                else
                return ab + bc + ca;
            }
        }

        public double Square
        {
            get
            {
                double p = Perimeter / 2;
                double ab = _a.DistanceBetweenPoints(_b._x, _b._y);
                double bc = _b.DistanceBetweenPoints(_c._x, _c._y);
                double ca = _c.DistanceBetweenPoints(_a._x, _a._y);
                return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
            }
        }
    }
}
