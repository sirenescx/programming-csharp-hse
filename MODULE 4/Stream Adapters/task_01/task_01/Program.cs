using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            BinaryWriter fOut = new BinaryWriter(new FileStream("../../../Numbers.dat", FileMode.Create));
            for (int i = 0; i < 10; ++i)
            {
                fOut.Write(rand.Next(1, 100));
            }
            fOut.Close();
        }
    }
}
