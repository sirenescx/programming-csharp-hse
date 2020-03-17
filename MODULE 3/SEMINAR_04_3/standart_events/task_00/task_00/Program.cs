using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_00
{
    class Program
    { 
        static void UserInputCallBack(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Input input = new Input();
            input.UserInput += UserInputCallBack;
            input.GetUserInput();
            Console.ReadKey();
        }
    }
}
