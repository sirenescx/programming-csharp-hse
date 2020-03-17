using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Program
    {
        public static string ReverseString(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }

        static void Main()
        {
            int x;
            do
            {
                do Console.WriteLine("enter n-digit number: ");
                while (!int.TryParse(Console.ReadLine(), out x));
                while (x % 10 == 0) x /= 10;
                string s = x.ToString();
                Console.WriteLine(ReverseString(s));
                Console.WriteLine("press ESC to exit, any key to continue...");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
