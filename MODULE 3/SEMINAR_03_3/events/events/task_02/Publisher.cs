using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Publisher
    {
        public event EventHappened somethingHappened; 

        public void fireEvent()
        {
            Console.WriteLine("Fire somethingHappened.");
            somethingHappened(); 
        }
    }
}
