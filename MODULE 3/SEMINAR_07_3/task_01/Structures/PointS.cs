﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct PointS
    {
        double x, y;

        public PointS(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public double distance(PointS pointA, PointS pointB)
        {
            return Math.Sqrt(Math.Pow(pointA.x - pointB.x, 2) + Math.Pow(pointA.y - pointB.y, 2));
        }
    }
}
