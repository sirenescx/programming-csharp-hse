using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Block block = new Block(rectangle, 5);
            Console.WriteLine($"V = {block.GetV():f2}");
            rectangle.SideChanged += block.OnSideChanged;
            rectangle.B = 10;
            rectangle.A = 2;
            Console.WriteLine($"V = {block.GetV():f2}");
            Console.ReadKey();
        }
    }
}
