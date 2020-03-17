using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A { get => a; set { a = value; SideChanged?.Invoke(this, new MyArgs("Side A has been changed")); } }
        public double B { get => b; set { b = value; SideChanged?.Invoke(this, new MyArgs("Side B has been changed")); } }

        public double GetS { get => a * b; }

        public event EventHandler<MyArgs> SideChanged;
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
