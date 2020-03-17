using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Circle
    {
        public int _xc;
        public int _yc;
        public int _r;

        public Circle()
        {
        }

        public Circle(int xc, int yc, int r)
        {
            _xc = xc;
            _yc = yc;
            _r = r;
        }

        public string CheckCircles(Circle X, Circle Default)
        {
            double D = Math.Sqrt(Math.Pow(X._xc - Default._xc, 2) + Math.Pow(X._yc - Default._yc, 2));
            int RSum = X._r + Default._r;
            int RDif = X._r - Default._r;
            if ((D <= RSum) && (D >= Math.Abs(RDif)))
                return "intersects";
            return "doesn't intersect";
        }

        public override string ToString()
        {
            return $"Circle W({_xc}, {_yc}) with R={_r} ";
        }
    }
} 
