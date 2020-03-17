using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle
    {
        Dot center;
        double rad;

        public Circle(Dot center, double rad)
        {
            this.Center = center;
            this.Rad = rad;
        }

        public Dot Center { get => center; set => center = value; }
        public double Rad { get => rad; set => rad = value; }

        public double GetMaxX()
        {
            return center.X + rad;
        }

        public double GetMinX()
        {
            return center.X - rad;
        }

        public void OnSideChanged(object sender, MyArgs args)
        {
            Console.WriteLine(args.info);
            Console.WriteLine($"Xmin = {this.GetMinX()}, Xmax = {this.GetMaxX()}");
        }
    }
}
