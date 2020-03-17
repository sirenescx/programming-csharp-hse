using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    public class Alphabet
    {
        char A = 'A';
        int length = 26;

        public AlphabetEnumerator GetEnumerator()
        {
            return new AlphabetEnumerator();
        }

        public class AlphabetEnumerator : Alphabet, IEnumerator
        {
            int index = -1;
            public object Current => (char)(A + index);

            public bool MoveNext()
            {
                if (index >= length - 1) return false;
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
            Alphabet alphabet = new Alphabet();
            foreach (var item in alphabet)
                Console.WriteLine(item);
            Console.ReadKey();

        }
    }
}
