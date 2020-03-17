using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class AnotherSubscriber
    {
        public void SomethingHappenedHandler()
        {
            Console.WriteLine("AnotherSubscriber has handled an event!");
        }
    }
}
