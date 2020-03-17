using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04
{
    public class Grid
    {
        static Random rnd = new Random();
        int xMax, yMax, zMax;
        int x, y, z;

        public Grid() { }
        public int Count { get; set; }

        public Grid(int xMax, int yMax, int zMax)
        {
            this.xMax = xMax;
            this.yMax = yMax;
            this.zMax = zMax;
            x = rnd.Next(0, xMax + 1);
            y = rnd.Next(0, yMax + 1);
            z = rnd.Next(0, zMax + 1);
        }

        public int XMax
        {
            get => xMax;
            set
            {
                if (value < 0) throw new ArgumentException("xMax должно быть больше или равно 0");
                xMax = value;
            }
        }
        public int YMax
        {
            get => yMax;
            set
            {
                if (value < 0) throw new ArgumentException("yMax должно быть больше или равно 0");
                yMax = value;
            }
        }
        public int ZMax
        {
            get => zMax;
            set
            {
                if (value < 0) throw new ArgumentException("zMax должно быть больше или равно 0");
                zMax = value;
            }
        }

        public override bool Equals(object obj)
        {
            Grid other = (Grid)obj;
            if (other == null)
                return false;
            /* if (other.x == this.x & other.y == this.y & other.z == this.z)
                 return true;
             else
                 return false; */
               
            return other.x == this.x & other.y == this.y & other.z == this.z;
        }

        public override int GetHashCode() => this.GetHashCode();
        public override string ToString() => $"x={x}, y={y}, z={z}, count={Count}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Grid> grids = new List<Grid>();
            int n = 6;
            int xMax = 1, yMax = 2, zMax = 0;
            if ((xMax + 1) * (yMax + 1) * (zMax + 1) < n) Console.WriteLine("Невозможно создать узлы без повторений");
            else
            {
                if (grids.Count == 0) grids.Add(new Grid(xMax, yMax, zMax));
                for (int i = 1; i < n; i++)
                {
                    var grid = new Grid(xMax, yMax, zMax);
                    while(true)
                    {
                        if (!grids.Contains(grid))
                            break;
                        grid = new Grid(xMax, yMax, zMax);
                    }

                    /* check: 
                        foreach (var exGrid in grids)
                        {
                            if (grid.Equals(exGrid))
                            {
                                count++;
                                grid = new Grid(xMax, yMax, zMax);
                                goto check;
                            }
                        }*/
                    grids.Add(grid);
                }
            }

            foreach (var grid in grids)
                Console.WriteLine(grid);
            Console.ReadKey();
        }
    }
}
