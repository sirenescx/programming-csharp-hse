using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Conus
    {
        Circle conusBase;
        Point conusVertex;

        public Conus(double rad, double xc, double yc, double xv, double yv)
        {
            conusBase = new Circle(rad, xc, yc);
            conusVertex = new Point(xv, yv);
        }

        public double GetSection()
        {
            double h = Math.Sqrt(Math.Pow(conusVertex.X - conusBase.Center.X, 2) + Math.Pow(conusVertex.Y - conusBase.Center.Y, 2));
            
            double s = Math.PI * Math.Pow(conusBase.Rad, 2);
            return 1d / 3 * h * s;
        }

        public override string ToString() => $"Conus. " + conusBase.ToString() + conusVertex.ToString();
    }
}
