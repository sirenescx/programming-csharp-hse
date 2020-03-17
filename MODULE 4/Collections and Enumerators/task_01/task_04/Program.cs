using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task_04
{
    public class Evens
    {
        int Nmin, Nmax;
        public Evens(int min, int max)
        {
            if (min >= max) throw new Exception("Error!");
            Nmin = min;
            Nmax = max;
        }

        public IEnumerator GetEnumerator()
        {
            for (int p = Nmin; p <= Nmax; p++)
            {
                if (p % 2 == 0) yield return p;
            }
        }
    }

    public class SimpleNumbers
    {
        int Nmin, Nmax;
        public SimpleNumbers(int min, int max)
        {
            if (min >= max) throw new Exception("Error!");
            Nmin = min;
            Nmax = max;
        }

        public bool isSimple(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }
        public IEnumerator GetEnumerator()
        {
            for (int p = Nmin; p <= Nmax; p++)
            {
                if (isSimple(p))
                    yield return p;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Evens ev = new Evens(20, 43);
            foreach (var t in ev)
                Console.Write(t + " ");
            Console.WriteLine();


            SimpleNumbers simpleNumbers = new SimpleNumbers(1, 30);
            foreach (var x in simpleNumbers)
                Console.Write(x + " ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
