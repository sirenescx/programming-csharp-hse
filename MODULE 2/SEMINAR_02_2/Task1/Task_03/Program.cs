using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        class Polygon
        {
            public int N { get; set; }
            public double R { get; set; }
            public Polygon(int n, double r) { N = n; R = r; }
            public Polygon() : this(0, 0) { } // конструктор умолчания

            public double Perimeter
            {
                get
                {
                    return 2 * R * N * Math.Tan(Math.PI / N);
                }
            }

            public double Square
            {
                get
                {
                    return R * R * N * Math.Tan(Math.PI / N);
                }
            }

            /* public string PolygonData
             {
                 get
                 {
                     string maket = "N = {0}; R = {1:F2}; Perimeter = {2:F2}; Square = {3:F2} ";
                     return string.Format(maket, N, R, Perimeter, Square);
                 }
             } */

            public static string PolygonData(Polygon f)
            {
                    string maket = "N = {0}; R = {1:F2}; Perimeter = {2:F2}; Square = {3:F2} ";
                    return string.Format(maket, f.N, f.R, f.Perimeter, f.Square);
            }

            static void Main(string[] args)
            {
                Polygon f;
                double r = 0;
                int n = 0;
                f = new Polygon();
                do
                {
                    Console.Write("n = ");
                    int.TryParse(Console.ReadLine(), out n);
                    Console.Write("r = ");
                    double.TryParse(Console.ReadLine(), out r);
                    f.N = n; f.R = r;
                    Console.WriteLine(PolygonData(f));
                } while (r != 0 | n != 0);

                /*  int k;
                  Console.WriteLine("Please enter number of objects: ");
                  int.TryParse(Console.ReadLine(), out k);
                  int n = 0;
                  double r = 0;
                  Polygon[] Arr = new Polygon[k];
                  for (int i = 0; i < k; i++)
                  {
                      Console.Write("n = ");
                      int.TryParse(Console.ReadLine(), out n);
                      Console.Write("r = ");
                      double.TryParse(Console.ReadLine(), out r);
                      Arr[i] = new Polygon(n, r);
                  }

                  double min = double.MaxValue;
                  double max = 0;
                  for (int i = 0; i < k; i++)
                  {
                      if (Arr[i].Square < min) min = Arr[i].Square;
                      if (Arr[i].Square > max) max = Arr[i].Square;
                  }

                  for (int i = 0; i < k; i++)
                  {
                      if (Arr[i].Square == min)
                      {
                          Console.ForegroundColor = ConsoleColor.Green;
                          Console.WriteLine(Arr[i].PolygonData);
                          Console.ResetColor();
                      }
                      else
                      if (Arr[i].Square == max)
                      {
                          Console.ForegroundColor = ConsoleColor.Red;
                          Console.WriteLine(Arr[i].PolygonData);
                          Console.ResetColor();
                      }
                      else Console.WriteLine(Arr[i].PolygonData);
                  } */
            } 
        }
    }
}
