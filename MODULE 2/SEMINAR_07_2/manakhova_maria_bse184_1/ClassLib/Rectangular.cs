using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manakhova_maria_bse184_1 {
    public class Rectangular : Shape {
        public Rectangular(double width, double height) {
            Width = width;
            Height = height;
        }

        public double Width { get; }

        public double Height { get; }

        public override double Area {
            get { return 2 * (Height + Width); }
        }

        public override double Perimeter {
            get { return Height * Width; }
        }

        public override string ToString() {
            return $"H = {Height}, W = {Width}, S = {Area}, P = {Perimeter}";
        }
    }
}