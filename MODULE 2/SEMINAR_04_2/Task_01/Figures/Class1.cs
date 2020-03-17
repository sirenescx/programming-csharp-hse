using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_02
{
    public class SComparer: IComparer
    {
        public int Compare(Object x, Object y)
        {
            Point left = (Point)x;
            Point right = (Point)y;
            if (left.Area == right.Area)
                return 0;
            else if (left.Area < right.Area)
                return -1;
            return 1;
        }
    }
    public class Point
    {
        public int _x;
        public int _y;

        public Point()
        {
        }

        public virtual void Display()
        {
            Console.WriteLine($"(x, y) = ({_x}, {_y})");
        }

        public virtual double Area
        {
            get
            {
                return 0;
            }
        }
    }

    public class Circle : Point
    {
        int rad;

        public Circle(int _rad, int x, int y)
        {
            rad = _rad;
            _x = x;
            _y = y;
        }

        public int Rad
        {
            get
            {
                return rad;
            }
        }


        public override void Display()
        {
            Console.WriteLine($"R = {Rad}, (x, y) = ({_x}, {_y})");
        }

        public virtual double Len
        {
            get
            {
                return 2 * Math.PI * rad;
            }
        }

        public override double Area
        {
            get
            {
                return Len * rad / 2;
            }

        }
    }

    public class Square : Point {
        int side;

        public Square(int _side, int x, int y)
        {
            side = _side;
            _x = x;
            _y = y;
        }

        public int Side
        {
            get
            {
                return side;
            }
        }


        public override void Display()
        {
            Console.WriteLine($"a = {Side}, (x, y) = ({_x}, {_y})");
        }

        public virtual double Len
        {
            get
            {
                return 4 * Side;
            }
        }

        public override double Area
        {
            get
            {
                return Len * side / 4;
            }

        }
    }

}
