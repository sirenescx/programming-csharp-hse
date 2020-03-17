using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigSeq
{
    class Triangle : Figure
    {
        int a, b, c;

        public Triangle(double _m, int _a, int _b, int _c) 
        {

            if ((_m < 0) || (_a < 0) || (_b < 0) || (_c < 0))
            {
                throw new Exception("стороны треугольника или масса не могут быть меньше нуля");
            }
            else
            {
                a = _a;
                b = _b;
                c = _c;
                Mass = 1;
            }

            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                throw new Exception("треугольник с такими сторонами не существует");
            }

        }

        public override double Area
        {
            get
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override string ToString()
        {
            return $"тип = {GetType()}, количество вершин = {N}, масса = {Mass}, площадь = {Area}, условная плотность = {CondDensity}";
        }
    }
}
