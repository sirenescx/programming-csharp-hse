using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class LinearEquation
    {
        int _a;
        int _b;
        int _c;

        public LinearEquation()
        {
        }

        public LinearEquation(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Solve()
        {
            double x;
            x = 1.0 * (_c - _b) / _a;
            return x;
        }

        public override string ToString()
        {
            if (_b != 0)
            {
                if (_b > 0)
                    return
                            $"for equation {_a}x+{_b}={_c}  x = {Solve()}";
                else
                    return
                         $"for equation {_a}x{_b}={_c}  x = {Solve()}";
            }
            else
                return
                            $"for equation {_a}x={_c}   x = {Solve()}";
        }
    }
}
