using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Dot
    {
        double x, y;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set { x = value; CoordinateChanged?.Invoke(this, new MyArgs("X coordinate was changed")); } }
        public double Y { get => y; set { y = value; CoordinateChanged?.Invoke(this, new MyArgs("Y coordinate was changed")); } }

        public event EventHandler<MyArgs> CoordinateChanged;
    }

    public class MyArgs : EventArgs
    {
        public string info;
        public MyArgs(string str)
        {
            info = str;
        }
    }
}
