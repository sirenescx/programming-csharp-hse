using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    interface ITransform
    {   // интерфейс преобразование
        void transform(double coef);    // преобразовать 
    }
    class Circle : ITransform
    {   // круг
        double rad = 1;     // радиус круга
        public void transform(double coef) { rad *= coef; }
        public override string ToString()
        {
            return String.Format("Площадь круга: {0:G4}",
                              Math.PI * rad * rad);
        }
    }
    class Cube : ITransform
    {   // куб
        double rib = 1;     // ребро куба
        public void transform(double coef) { rib *= coef; }
        public override string ToString()
        {
            return String.Format("Объем куба: {0:G4}",
                             rib * rib * rib);
        }
    }

    class Pyramid : ITransform
    {
        public Pyramid(double b, double h)
        {
            B = b;
            H = h;
        }

        double B { get; set; }
        double H { get; set; }
        public void transform(double coef) { B *= coef; H *= coef; }

        public override string ToString() => $"Объем пирамиды: {1f/3 * B * B * H:G4}. Площадь боковой поверхности: {B * B + 4 * 1f/2 * B * Math.Sqrt((B/2)*(B/2) + H*H):G4}";
    }

    class Program
    {
        public static void report(ITransform g)
        {
            Console.WriteLine("Данные объекта класса {0}:",
                                               g.GetType());
            Console.WriteLine(g);
        }

        public static ITransform mapping(ITransform g, double d)
        {
            g.transform(d);
            return g;
        }
        public static void Main()
        {
            ITransform[] iarray = new ITransform[4];
            ITransform ira = new Circle();
            iarray[0] = ira;
            ira.transform(3);
            iarray[1] = ira;
            ira = mapping(new Cube(), 2);
            iarray[2] = ira;
            iarray[3] = new Circle();
            foreach (ITransform obj in iarray)
                report(obj);
            Console.ReadKey();
        }


        /* public static void Main()
         {
             Circle cir = new Circle();
             report(cir);
             Cube cub = new Cube();
             report(cub);
             ITransform ira = cir;
             report(ira);
             Pyramid pyr = new Pyramid(48, 7);
             report(pyr);
             pyr.transform(1f/3);
             report(pyr);
         } */
    }
}
