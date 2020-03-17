using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigSeq
{
   
    public class FigureSequence
    {
        Random rand = new Random();
        
        Figure[] figures = new Figure[30];
        int possibility;

        public FigureSequence(int _possibility)
        {
            if (_possibility < 1) _possibility = 1;
            if (_possibility > 100) _possibility = 100;
            possibility = _possibility;

        

            int num = possibility * figures.Length / 100;
                for (int i = 0; i < figures.Length; i++)
                {
                    if (num > 0)
                    {
                        while (true)
                        {
                            try
                            {
                                figures[i] = new Triangle(rand.Next(-25, 25) + rand.NextDouble(), rand.Next(-25, 25), rand.Next(-25, 25), rand.Next(-25, 25));
                                break;
                            }
                            catch (Exception e)
                            {
                                // Ooops
                            }
                        }
                        num--;
                    }
                    else
                    {
                        while (true)
                        {
                            try
                            {
                                figures[i] = new Rectangle(rand.Next(-25, 25) + rand.NextDouble(), rand.Next(-25, 25), rand.Next(-25, 25));
                                break;
                            }
                            catch (Exception e)
                            {
                                // Ooops
                            }
                        }
                }

            }
        }

        public FigureSequence(Figure[] figures)
        {
            this.figures = figures;

         
        }


       public Figure[] returnArray(int N)
        {
            int num = 50 / 100 * figures.Length;
            Figure[] figureAr = new Figure[N];
            for (int i = 0; i < figureAr.Length; i++)
            {
                if (num > 0) figureAr[i] = new Triangle(rand.Next(-25, 25) + rand.NextDouble(), rand.Next(-25, 25), rand.Next(-25, 25), rand.Next(-25, 25));
                else figureAr[i] = new Rectangle(rand.Next(-25, 25) + rand.NextDouble(), rand.Next(-25, 25) + rand.NextDouble(), rand.Next(-25, 25) + rand.NextDouble());
            }

            return figureAr;
        } 

        public void GetInfo()
        {
            for (int i = 0; i < figures.Length; i++)
                Console.WriteLine(figures[i].ToString());
            }

        public void GetMaxCondDensityInfo()
        {
            double MaxCondDensity = 0;
            int num = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i].CondDensity > MaxCondDensity)
                {
                    MaxCondDensity = figures[i].CondDensity;
                    num = i;
                }
            }
            Console.WriteLine($"{figures[num].ToString()}, максимальная условная плотность = {MaxCondDensity}");
        }

        public void AverageRectangleArea()
        {
            int count = 0;
            double RectangleArea = 0;
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is Rectangle)
                {
                    count++;
                    RectangleArea += figures[i].Area;
                }
            }
            Console.WriteLine($"Среднее арифметическое площади всех объектов типа Rectangle = {RectangleArea / count}");
        }
    }
}
