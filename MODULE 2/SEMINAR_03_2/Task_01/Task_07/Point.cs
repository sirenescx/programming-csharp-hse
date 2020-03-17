using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_07
{
    class Point
    {
        public double _x;
        public double _y;

        public Point()
        {

        }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double DistanceBetweenPoints(double x0, double y0)
        {
            double _ro;
            _ro = Math.Sqrt((Math.Pow(_x - x0, 2) + Math.Pow(_y - y0, 2)));
            return _ro;
        }
    }
}