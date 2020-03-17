using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    public class Distrubution: IEnumerable
    {
        int n;
        public int N { get; }
        double p;

        public Distrubution(int n, double p)
        {
            this.n = n;
            this.p = p;
        }

        public double P { get; }
        
        public double Factorial(int n)
        {
            int factorial = 1;
            while (n != 0)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }

        public double BinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(n - k) * Factorial(k));
        }
        public double ProbabilityMassFunction(int n, int k, double p)
        {
            return BinomialCoefficient(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
        }

        public IEnumerator GetEnumerator()
        {
            for (Int32 k = 0; k <= n; k++)
                yield return ProbabilityMassFunction(n, k, p);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distrubution distrubution = new Distrubution(6, 0.3);
            foreach (var item in distrubution)
                Console.WriteLine($"{item:f3}");
            Console.ReadKey();
        }
    }
}
