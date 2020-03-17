using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task_05
{
    public class Iterators<T> : IEnumerator<T>
    {
        List<T> list = new List<T>();
        int index = -1;
        bool isReversed = false;

        public Iterators(List<T> list)
        {
            this.list = new List<T>(list);
        }

        public Iterators(List<T> list, bool isReversed)
        {
            this.list = new List<T>(list);
            this.isReversed = isReversed;
        }

        public Iterators(List<T> list, int start)
        {
            this.list = new List<T>(list);
            if (start == 0) index = -1;
            else index = start - 1;
        }

        public Iterators(List<T> list, int start, bool isReversed)
        {
            this.list = new List<T>(list);
            if (start == 0) index = -1;
            else index = start - 1;
            this.isReversed = isReversed;
        }

        public T Current => list[index];

        object IEnumerator.Current => Current;

        public IEnumerator GetEnumerator()
        {
            if (!isReversed) return this;
            else
            {
                list.Reverse();
                return this;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            if (index >= list.Count) return false;
            else return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            Iterators<int> iterator = new Iterators<int>(list, true);
            foreach (var item in iterator)
                Console.Write(item + "\t");

            iterator.Reset();

            Console.WriteLine("\n * * * \n");
            foreach (var item in iterator)
                Console.Write(item + "\t");

            Console.ReadKey();
        }
    }
}
