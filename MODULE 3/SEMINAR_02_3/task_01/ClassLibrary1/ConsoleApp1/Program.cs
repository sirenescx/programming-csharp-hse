using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleLib1;

namespace ConsoleApp1
{
    class Program
    {
        public static string RemoveDigits(string str)
        {
            string str2 = "";
            foreach (char x in str)
                if (x < '0' || x > '9') str2 += x;
            return str2;
        }
        public static string RemoveSpaces(string str)
        {
            string str2 = "";
            foreach (char x in str)
                if (x != ' ') str2 += x;
            return str2;
        }
        static void Main(string[] args)
        {
            string[] sample = { "as23 45", "as23wd", "a  b", "ab" };
 
        
            for (int i = 0; i < sample.Length; i++)
            {
                Converter converter = new Converter();
                //ConvertRule convertRule = RemoveSpaces;
               // sample[i] = converter.Convert(sample[i], RemoveDigits);
               // sample[i] = converter.Convert(sample[i], convertRule);
                ConvertRule convert = RemoveSpaces;
                convert += RemoveDigits;
                sample[i] = converter.Convert(sample[i], convert);

            }
            foreach (string x in sample)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
