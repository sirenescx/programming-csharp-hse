using System;

namespace Task_10
{
    class Program
    {
        private static Random random = new Random();
        public static void Main()
        {
            int[][,] sampleArr = new int[3][,]
            {
                new [,] { {11,23}, {58,78} },
                new [,] { {50,62}, {45,65}, {85,15} },
                new [,] { {245,365}, {385,135} },
            };

            int[,,] m = new int[3, 3, 3];

            for (var i = 0; i < m.GetUpperBound(0); ++i)
            {
                for (var j = 0; j < m.GetUpperBound(1); ++j)
                {
                    for (var k = 0; k < m.GetUpperBound(2); ++k)
                    {
                        m[i, j, k] = random.Next(0, 100);
                    }
                }
            }

            Console.WriteLine(m.GetUpperBound(0));
            Console.WriteLine(m.GetUpperBound(1));
            Console.WriteLine(m.GetUpperBound(2));
            Console.WriteLine(sampleArr.GetUpperBound(0));

            foreach (var arr in sampleArr)
            {
                Console.WriteLine(arr.GetUpperBound(0));
            }
            //   Console.WriteLine(sampleArr.GetLowerBound(1));
            //   Console.WriteLine(sampleArr.GetLength(0));
            //   Console.WriteLine(sampleArr.GetLength(1));
        }
    }
}