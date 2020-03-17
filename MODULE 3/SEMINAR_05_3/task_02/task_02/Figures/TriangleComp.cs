using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class TriangleComp
    {
        Point A, B, C;
        double a, b, c, p;

        public TriangleComp(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            A = new Point(xA, yA);
            B = new Point(xB, yB);
            C = new Point(xC, yC);
            a = A.Distance(B, C);
            b = B.Distance(A, C);
            c = C.Distance(A, B);
            p = (a + b + c) / 2;
        }

        public double Square { get => Math.Sqrt(p * (p - a) * (p - b) * (p - c)); }

        public bool isInside(Point P)
        {
            double step1 = (A.X - P.X) * (B.Y - A.Y) - (B.X - A.X) * (A.Y - P.Y);
            double step2 = (B.X - P.X) * (C.Y - B.Y) - (B.Y - P.Y) * (C.X - B.X);
            double step3 = (C.X - P.X) * (A.Y - C.Y) - (C.Y - P.Y) * (A.X - C.X);
            if ((step1 > 0 & step2 > 0 & step3 > 0) || (step1 < 0 & step2 < 0 & step3 < 0)) return true;
            return false;
        }
    }
}
