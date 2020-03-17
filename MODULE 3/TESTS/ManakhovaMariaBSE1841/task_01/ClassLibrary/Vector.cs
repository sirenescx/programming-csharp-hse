using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Vector
    {
        Dot b;
        Dot a;

        public Vector(Dot b)
        {
            a = new Dot(0, 0);
            this.b = b;
        }
        /// <summary>
        /// Свойство для вычисления модуля вектора
        /// </summary>
        public double CalcModule { get => Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)); }

        public override string ToString() => $"Начальная точка: ({a.X:f3}, {a.Y:f3}), конечная точка: ({b.X:f3}, {b.Y:f3})";

    }
}
