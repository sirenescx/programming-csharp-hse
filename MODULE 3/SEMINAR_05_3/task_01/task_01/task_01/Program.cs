using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace task_01
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();

            Circle circle = new Circle(3, 2, 1);
            Circle circle2 = new Circle(4, 0, 8);
            Circle circle3 = new Circle(1, -2, 4);
            Circle circle4 = new Circle(2, 12, 10);

            circles.Add(circle);
            circles.Add(circle2);
            circles.Add(circle3);
            circles.Add(circle4);

            circles.Sort((Circle a, Circle b) =>
            {
                if (a.Rad * a.center.Distance(new Point(0, 0)) > b.Rad * b.center.Distance(new Point(0, 0))) return 1;
                if (a.Rad * a.center.Distance(new Point(0, 0)) == b.Rad * b.center.Distance(new Point(0, 0))) return 0;
                if (a.Rad * a.center.Distance(new Point(0, 0)) < b.Rad * b.center.Distance(new Point(0, 0))) return -1;
                return 0;
            });

            foreach (var item in circles)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
