using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"..\..\Program.cs", FileMode.Open))
            {
                //123456;
                int t;      // числовое значение прочитанного байта
                int k = 0;  // позиция байта в потоке (в файле)
                while ((t = fs.ReadByte()) != -1)
                {
                    if (t >= (int)'0' && t <= (int)'9')
                        Console.WriteLine(t + " - " + (char)t + " - " + k);
                    k++;
                }
            }
            Console.ReadKey();
        }
    }
}
