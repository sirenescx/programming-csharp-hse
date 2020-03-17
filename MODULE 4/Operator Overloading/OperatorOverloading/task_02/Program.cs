using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    public class RectSet
    {
        public static Random rnd;

        int minX, maxX;

        HashSet<int> setPoints;

        public HashSet<int> SetPoints { get => setPoints; }

        public RectSet()
        {
            setPoints = new HashSet<int>();
        }

        public RectSet(int min, int max, int N)
        {
            if (N == 0) throw new ArgumentException("Попытка создания пустого множества ");
            if (min < max) throw new ArgumentException("Минимальная координата не может быть больше максимальной.");
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = rnd.Next(min, max + 1);
            setPoints = new HashSet<int>(arr); // конструируем множество
            Array.Sort(arr);
            minX = arr[0];
            maxX = arr[arr.Length - 1];
        }
        public RectSet(HashSet<int> setPoints)
        {
            if (setPoints.Count == 0) throw new ArgumentException("Попытка создания пустого множества ");
            this.setPoints = setPoints;
            minX = setPoints.Min();
            maxX = setPoints.Max();
        }

        public static RectSet operator +(RectSet a, RectSet b)
        {
            // используем метод Concat() из HashSet<>
            return new RectSet(new HashSet<int>(a.SetPoints.Concat(b.SetPoints)));
        }

        public static RectSet operator *(RectSet a, RectSet b)
        {
            // используем метод Intersect() из HashSet<>
            return new RectSet(new HashSet<int>(a.SetPoints.Intersect(b.SetPoints)));
        }

        public static RectSet operator ^(RectSet a, RectSet b)
        {
            // используем метод () из HashSet<>
            RectSet set = a;
            set.SetPoints.SymmetricExceptWith(b.SetPoints);
            return set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*      try
                  {
                      int[] arr = { 1, 2, 3, 4, 5 };
                      HashSet<int> hs = new HashSet<int>(arr);
                      int[] arr2 = { 7, 8, 6 };
                      HashSet<int> hs2 = new HashSet<int>(arr2);
                      RectSet rs = new RectSet(hs);
                      RectSet rs2 = new RectSet(hs2);
                      RectSet rs3 = rs * rs2;
                      foreach (int x in rs3.SetPoints)
                      {
                          Console.Write(x + " ");
                      }
                  }
                  catch (ArgumentException ex)
                  {
                      var LineNumber = new StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                      Console.WriteLine(ex.Message + "в строке " + LineNumber + "."); }
                  Console.ReadKey(); */


            int[] arr = { 3, 3, 1, 2, 4, 5 };
            HashSet<int> setA = new HashSet<int>(arr); // System.Collection.Generic
            Console.Write("A: ");
            foreach (int x in setA) Console.Write(x + " ");// 3 1 2 4 5
                                                           // Добавление одного и того же значения
            setA.Add(45); setA.Add(45);
            Console.Write("\nA: ");
            foreach (int x in setA) Console.Write(x + " ");// 3 1 2 4 5 45
                                                           // создаём множество B
            int[] arr2 = { 1, 2, 7, 7, 15 };
            HashSet<int> setB = new HashSet<int>(arr2);
            Console.Write("\nB: ");
            foreach (int x in setB) Console.Write(x + " ");// 1 2 7 15
                                                           // Формируем пересечение множеств System.Linq
            HashSet<int> intersectAB = new HashSet<int>(setA.Intersect(setB));
            Console.WriteLine("\n A intersection B:");
            foreach (int x in intersectAB) Console.Write(x + " "); // 1 2
            Console.WriteLine();
        }
    }
}
