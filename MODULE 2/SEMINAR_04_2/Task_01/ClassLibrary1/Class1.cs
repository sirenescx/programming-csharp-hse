using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class A
    {
        public virtual void getA()
        {
            Console.Write("A");
        }
    }

    public class B : A
    {
        public virtual void getB()
        {
            Console.Write("B");
        }
    }
}
