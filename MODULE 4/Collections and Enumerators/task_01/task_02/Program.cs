using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task_02
{
    class Rainbow
    {
        public IEnumerator GetEnumerator()
        {
            yield return "каждый ";
            yield return "охотник ";
            yield return "желает ";
            yield return "знать ";
            yield return "где ";
            yield return "сидит ";
            yield return "фазан ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rainbow colors = new Rainbow();
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            int i = 0;
            foreach (string color in colors)
            {
                if (++i % 3 == 0) continue;
                Console.Write(color);
            }
            Console.WriteLine();

            i = 0;
            foreach (string color in colors)
            {
                if (++i % 3 == 0) break;
                Console.Write(color);
            }
            Console.WriteLine();
        }
    }
}
