using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Манахова
 БПИ184
 Вар 4*/

namespace Task_01
{
    class Program
    {
        class GeometricSequence
        {
            private double beginElement;
            private double step;

            public GeometricSequence()
            {
                beginElement = Math.PI;
                step = Math.E;
            }

            public GeometricSequence(double _beginElement, double _step)
            {
                beginElement = _beginElement;
                step = _step;
            }

            public double this[int i]
            {
                get
                {
                    return i * step;
                }
            }


            public Boolean IsDescending()
            {
                int cur = 0;
                int end = 42;
                for (int i = cur; i < end - 1; i++)
                {
                    if (this[i] < this[i + 1])
                        return true; 
                    else return false;
                }
                return false;
            }

            public string InstanceInfo()
            {
                return ($"{beginElement}, {step}");
            }
        }



        static void Main(string[] args)
        {
            
   
            GeometricSequence defaultSequence = new GeometricSequence();
            Random rand = new Random();
            GeometricSequence[] Arr = new GeometricSequence[rand.Next(1, 6)];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = new GeometricSequence(rand.NextDouble() + rand.Next(-4, 4), rand.NextDouble() + rand.Next(-4, 4));
                Console.WriteLine(Arr[i].InstanceInfo());
            }



            Console.ReadLine();
        }
    }
}
