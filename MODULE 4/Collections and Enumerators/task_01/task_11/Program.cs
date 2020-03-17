using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    public class ArithmeticProgression : IEnumerable
    {
        double a0, d;
        int n;

        public ArithmeticProgression(double a0, double d, int n)
        {
            this.a0 = a0;
            this.d = d;
            this.n = n;
        }

        public double A0 { get => a0; set => a0 = value; }
        public double D { get => d; set => d = value; }
        public int N { get => n; set => n = value; }

        public IEnumerator GetEnumerator()
        {
            return new ArithmeticProgressionEnumerator(a0, d, n);
        }

        class ArithmeticProgressionEnumerator : ArithmeticProgression, IEnumerator
        {
            int index = -1;
            List<double> progression = new List<double>();

            public ArithmeticProgressionEnumerator(double a0, double d, int n) : base(a0, d, n)
            {
                for (int i = 0; i < n; i++)
                    progression.Add(a0 + d * (i));
            }

            public object Current => progression[index];

            public bool MoveNext()
            {
                if (index >= n - 1) return false;
                else
                {
                    index++;
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression progression = new ArithmeticProgression(1, 4, 8);
            foreach (var item in  progression)
                Console.Write(item + "\t");
            Console.ReadKey();
        }
    }
}
