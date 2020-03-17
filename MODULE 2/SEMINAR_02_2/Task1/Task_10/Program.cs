using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class LatinChar
    {
        char _char;

        public LatinChar(char Char) { _char = Char; }
        public LatinChar() : this('a') { }

        public char C
        {
            get
            {
                return _char;
            }
        }



    }
    class Program
    {
        static void Main(string[] args)
        {

            char MinChar = ' ';
            char MaxChar = 'Z';
            char Cur = MinChar;
            while (Cur < MaxChar)
            {
                LatinChar Char = new LatinChar(Cur);
                Console.WriteLine(Char.C);
                Cur += (char)1;

            }
        }
    }
}
