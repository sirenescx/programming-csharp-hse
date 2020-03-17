using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_09
{
    class ArithmeticProgression : IEnumerable<Single>
    {
        Single a0, d;
        Int32 n;

        public ArithmeticProgression(Single a0, Single d, Int32 n)
        {
            this.a0 = a0;
            this.d = d;
            this.n = n;
        }

        public Single A0 { get => a0; set => a0 = value; }
        public Single D { get => d; set => d = value; }
        public Int32 N { get => n; set => n = value; }

        public IEnumerator<Single> GetEnumerator()
        {
            for (Int32 i = 1; i < n + 1; i++)
                yield return (a0 + d * (i - 1));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression progression = new ArithmeticProgression(2, 3, 7);
            foreach (var item in progression)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
