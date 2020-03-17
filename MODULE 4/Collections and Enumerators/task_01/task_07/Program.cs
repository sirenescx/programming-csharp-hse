using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task_07
{
    public class StringArray : IEnumerable<String>
    {
        String[] arr;

        public String[] Arr { get; }

        public StringArray(String[] arr)
        {
            this.arr = arr;
        }

        public String[] ConvertStringToStringArray(String s)
        {
            return new[] { s };
        }

        public IEnumerator<String> GetEnumerator()
        {
            List<int> vs = new List<int>();
            List<int> vs2 = new List<int>(vs);
            String[] array;
            arr.CopyTo(array = new String[arr.Length], 0);
            Array.Sort(array);
            for (Int32 i = 0; i < array.Length; i++)
                yield return array[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
    class Program
    {
        static void Main(String[] args)
        {
            String[] strArr = new String[] { "abb", "cd", "ae", "jga", "b" };
            StringArray arr = new StringArray(strArr);
            foreach (var item in arr)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
