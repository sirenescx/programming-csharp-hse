using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14
{
    public class RandomCollection: IEnumerable<int>
    {
        public static Random rnd = new Random();
        public static int n;

        public RandomCollection(int num)
        {
            n = num;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new RandomEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class RandomEnumerator : IEnumerator<int>
        {
            int index = -1;
            public int Current => rnd.Next(0, 1000);

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                index = -1;
            }

            public bool MoveNext()
            {
                if (index >= n) return false;
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
            do
            {          
                RandomCollection collection = new RandomCollection(10);
                foreach (var item in collection)
                    Console.Write(item + "\t");
                Console.WriteLine();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
