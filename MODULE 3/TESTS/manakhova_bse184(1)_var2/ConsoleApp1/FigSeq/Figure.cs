using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigSeq
{
    public abstract class Figure
    {
        protected Figure(int n, double m)
        {
            if ((n < 0) || (m < 0)) { throw new Exception("Число вершин или масса фигуры не могут быть меньше нуля"); }
            else
            {
                N = n;
                Mass = 1;
            }

            
        }

        public Figure()
        {
        }

        protected int N { get; set; }
        protected double Mass { get; set; }

        public abstract double Area
        {
            get;
        }

        public double CondDensity
        {
            get
            {
                return Mass / Area;
            }
        }



            public override string ToString()
        {
            return $"тип = {GetType()}, количество вершин = {N}, масса = {Mass}, площадь = {Area}, условная плотность = {CondDensity}";
        }
    }
}
