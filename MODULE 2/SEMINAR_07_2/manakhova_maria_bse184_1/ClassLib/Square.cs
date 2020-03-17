using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manakhova_maria_bse184_1
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side
        {
            get;
        }

        public override double Area { get
            {
                return Side * Side;
            }
        }

        public override double Perimeter { get
            {
                return 4 * Side;
            }
        }

        public override string ToString()
        {
            return $"A = {Side}, S = {Area}, P = {Perimeter}";
        }
    }
}
