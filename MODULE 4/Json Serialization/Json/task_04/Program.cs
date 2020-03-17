using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Drawing;

namespace task_04
{
    [Serializable]
    public struct ConsoleSymbolStruct
    {
        char symb;
        int y;
        int x;

        public ConsoleSymbolStruct(char symb, int y, int x)
        {
            this.symb = symb;
            this.y = y;
            this.x = x;
        }

        public char Symb { get => symb; set => symb = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


    }
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            ConsoleSymbolStruct[] symbols = new ConsoleSymbolStruct[20];
            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = new ConsoleSymbolStruct('a', rnd.Next(0, 80), rnd.Next(0, 80));
            }

            foreach (var symbol in symbols)
            {
                Console.SetCursorPosition(symbol.X, symbol.Y);
                Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
                Console.WriteLine(symbol.Symb);
            }

            Console.ReadKey();

       
        }
    }
}
