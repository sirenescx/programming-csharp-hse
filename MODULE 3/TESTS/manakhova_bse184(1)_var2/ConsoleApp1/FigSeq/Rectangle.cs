using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigSeq
{
    class Rectangle : Figure
    {
        double a, b;

        public Rectangle(double _m, double _a, double _b)
        {

            if ((_m < 0) || (_a < 0) || (_b < 0))
            {
                throw new Exception("стороны треугольника или масса не могут быть меньше нуля");
            }
            else
            {
                a = _a;
                b = _b;
                Mass = 1;
            }
        }

        public override double Area
        {
            get
            {
                return a * b;
            }
        }

        public override string ToString()
        {
            return $"тип = {GetType()}, количество вершин = {N}, масса = {Mass}, площадь = {Area}, условная плотность = {CondDensity}";
        }
    }
}
