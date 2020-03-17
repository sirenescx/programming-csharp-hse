using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void EventHappened(); // событийный делегат

    class Program
    {
        static void Main()
        {
            Publisher pub = new Publisher();
            Subscriber shs = new Subscriber();

            pub.somethingHappened += shs.SomethingHappenedHandler;

            AnotherSubscriber ashs = new AnotherSubscriber();
            pub.somethingHappened += ashs.SomethingHappenedHandler;

            pub.fireEvent();
        }
    }
}
