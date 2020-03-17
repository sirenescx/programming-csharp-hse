using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public delegate int Cast(double param);
    public class Class1
    {
        public static int NearestOddNumber(double param)
        {
            return Math.Floor(param) % 2 == 0 ? (int)Math.Floor(param) : (int)Math.Ceiling(param);
        }

        public static int Ord(double param)
        {
            int ord = 0;
            while (!(param > 1 & param < 9))
            {
                if (param > 1)
                { 
                    param /= 10;
                    ord++;
                }
                else
                {
                    param *= 10;
                    ord--;
                }
            }
            return ord;
        }
    }
}
