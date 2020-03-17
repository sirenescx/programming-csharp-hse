using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    public class MyInt : IEnumerable, IEnumerator
    {
        int[] myArray;
        int index = -1;

        public MyInt(int[] myArray)
        {
            this.myArray = myArray;
        }

        public object Current => myArray[index]; 

        public IEnumerator GetEnumerator()
        {
            foreach (var item in myArray)
                yield return item;
        }

        public bool MoveNext()
        {
            if (index >= myArray.Length) return false;
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
    class Program
    {
        static void Main(string[] args)
        {
            MyInt intArray = new MyInt(new int[] { 2, 8, 9, 14 });
            foreach (var item in intArray)
                Console.Write(item + "\t");

            Console.WriteLine("\n * * * ");

            foreach (var item in intArray)
                Console.Write(item + "\t");
            Console.ReadKey();


        }
    }
}
