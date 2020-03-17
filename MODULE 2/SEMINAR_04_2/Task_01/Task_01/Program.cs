
using System;
using ClassLibrary1;

namespace Task_01
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            A[] arr = new A[10];
            for (int k = 0; k < arr.Length; k++)
                if (rand.Next(0, 3) % 2 == 0) arr[k] = new A();
                else arr[k] = new B();
            foreach (A d in arr) d.getA();
            Console.WriteLine("\nОбъекты класса B: ");
            foreach (A d in arr)
                if (d is B) d.getA();
            Console.WriteLine("\nОбъекты класса A: ");
            foreach (A d in arr)
                if (d is A) d.getA();
            Console.WriteLine();

        }
    }
}
