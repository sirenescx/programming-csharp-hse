using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_03
{
    public delegate void ChainLenChanged(double r);

        public class ChainLenChangedEventArgs : EventArgs
        {
            public readonly double rad;
            public ChainLenChangedEventArgs(double r)
            {
                rad = r;
            }

        }

    class Bead
    {
        double r;

        public Bead(double r)
        {
            if (r <= 0) throw new ArgumentOutOfRangeException("Bead radius should be greater than 0");
            this.r = r;
        }
    }

    class Chain
    {
        public event EventHandler<ChainLenChangedEventArgs> ChainLenChanged;
        double len;
        public int N;
        List<Bead> beads = new List<Bead>();

        public Chain(double len, int n)
        {
            this.len = len;
            N = n;
            for (int i = 0; i < N; i++)
                CreateBeads();

        }

        public double Len { get => len; set { len = value; OnChainLenChanged(new ChainLenChangedEventArgs (newR)); } }

        protected virtual void OnChainLenChanged(ChainLenChangedEventArgs e)
        {
            if (ChainLenChanged != null) ChainLenChanged(this, e);
        }

        public event ChainLenChanged ChainLenChangedEvent;
        public void CreateBeads()
        {
            Bead bead = new Bead(len / N);
            beads.Add(bead);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Chain chain = new Chain(100, 10);
            Console.WriteLine($"Длина нити: {chain.Len}, количество бусин: {chain.N}");
        }
    }
}
