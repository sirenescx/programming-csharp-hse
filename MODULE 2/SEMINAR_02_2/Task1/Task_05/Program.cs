using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        class ConsolePlate
        {
            private char _plateChar;
            private ConsoleColor _plateColor;

            public ConsolePlate(char symb, ConsoleColor color)
            {
                _plateChar = symb;
                _plateColor = color;
            }

            public ConsolePlate() : this('+', 0) { }


        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter size of the array: ");
            int.TryParse(Console.ReadLine(), out n);
            ConsolePlate[] Arr = new ConsolePlate[n];
            ConsolePlate x;
            x = new ConsolePlate();
        }
    }
}
