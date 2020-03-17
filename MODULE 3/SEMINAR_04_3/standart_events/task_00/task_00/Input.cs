using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_00
{
    class Input
    {
        public delegate void SendMessage(string message);

        public event SendMessage UserInput;

        private void YouTyped(string message)
        {
            if (UserInput != null)
                UserInput($"You typed: {message}");
        }

        private void TypeQToQuit()
        {
            if (UserInput != null)
                UserInput("You typed 'q' to quit.");
        }
        public void GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Type any characters or 'q' to quit end press Enter.");
                string input = Console.ReadLine();
                if (input.Trim() != "q") { YouTyped(input); }
                else
                {
                    TypeQToQuit();
                    break;
                }
            }
        }
    }
}
