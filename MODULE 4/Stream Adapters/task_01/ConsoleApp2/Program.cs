using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{

    class Program
    {
        public static void writeFile(FileStream f, BinaryReader fIn)
        {

            long n = f.Length / 4; int a;
            for (int i = 0; i < n; i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }
            Console.WriteLine("\nOutput:");
            fIn.Close();
            f.Close();
        }
        static void Main(string[] args)
        {
            FileStream f = new FileStream("../../../Numbers.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            writeFile(f, fIn);

            int x;
            do Console.WriteLine("Enter number between 1 and 100");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > 100);

            f = new FileStream("../../../Numbers.dat", FileMode.Open);

                for (int i = 0; i < f.Length - 4; i += 5)
                {
                    byte[] symbol = new byte[4];
                    f.Read(symbol, i, 4);
                    foreach (var item in symbol)
                    {
                        Console.Write(item);
                    }
                   // if (symbol.Equals(BitConverter.GetBytes(x))) symbol = BitConverter.GetBytes(x);
                }

            writeFile(f, fIn);

            Console.ReadKey();

        }
    }
}
