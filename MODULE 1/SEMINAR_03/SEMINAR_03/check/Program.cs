using System;

namespace check
{
    class Program
    {
        private static void Divide(int x, double y)
        {
            double result = default;
            try
            {
                result = x / y;
            }
            catch (DivideByZeroException) when (y == 0)
            {
                Console.WriteLine("Division by zero");
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            int x = 5;
            double y = 0;
            Divide(x, y);

        }
    }
}
