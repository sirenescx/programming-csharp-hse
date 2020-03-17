using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manakhova_maria_bse184_1 {
    public abstract class Shape {
        public Shape() {
        }

        public Shape(double area, double perimeter) {
            Area = area;
            Perimeter = perimeter;
        }

        public virtual double Area { get; }

        public virtual double Perimeter { get; }

        public override string ToString() => $"S = {Area}, P = {Perimeter}";
    }
}