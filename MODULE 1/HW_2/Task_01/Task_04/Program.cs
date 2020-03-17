using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
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
            Console.WriteLine("press ENTER to start");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                do Console.WriteLine("enter four-digit number: ");
                while (!int.TryParse(Console.ReadLine(), out x) || x < 999 || x > 9999);
                string s = x.ToString();
                Console.WriteLine(ReverseString(s));
                Console.WriteLine("enter ESC to exit");
            }
        }
    }
}
