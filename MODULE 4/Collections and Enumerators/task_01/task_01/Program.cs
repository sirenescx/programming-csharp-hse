using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{

    public class A : IEnumerable
    {
        private string[] arr = { "раз ромашка ", "два ромашка ",
                                 "три ромашка ", "пять ромашка ", "шесть ромашка " };
        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            foreach (var str in a)
            {
                Console.WriteLine(str);
            }
        }
    }
}
