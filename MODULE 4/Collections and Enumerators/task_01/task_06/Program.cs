using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace task_06
{
    public class FileLines : IEnumerable
    {
        StreamReader input;
        string fileName;

        public FileLines(string fileName)
        {
            input = new StreamReader(fileName);
            this.fileName = fileName;
        }

        public IEnumerator GetEnumerator()
        {
            return new FileEnumerator(this);
        }

        class FileEnumerator : IEnumerator
        {
            FileLines fileLines;
            string resultString;

            public FileEnumerator(FileLines fileLines)
            {
                this.fileLines = fileLines;
            }

            public object Current => resultString;

            public bool MoveNext()
            {
                resultString = fileLines.input.ReadLine();
                if (resultString != null)
                    return true;
                else
                {
                    Reset();
                    return false;
                }
            }

            public void Reset()
            {
                if (fileLines.input != null)
                    fileLines.input.Close();
                fileLines.input = new StreamReader(fileLines.fileName);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileLines source = new FileLines(@"..\..\Program.cs");

            foreach (var item in source)
                Console.WriteLine(item);

            Console.WriteLine("* * *");

            foreach (var item in source)
                Console.WriteLine(item);

            Console.ReadKey();

        }
    }
}
