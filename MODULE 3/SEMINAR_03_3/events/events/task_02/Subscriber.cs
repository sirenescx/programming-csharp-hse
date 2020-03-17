using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Subscriber
    {
            public void SomethingHappenedHandler()
            {
                // код обработки события
                Console.WriteLine("Subscriber has handled an event!");
            }
    }
}
