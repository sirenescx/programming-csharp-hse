using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading2
{
    class Program
    {
        static double GetIntegral(Func<double, double> func, double a, double b, double accuracy = 1e-8)
        {
            double res = 0;
            for (double i = a; i < b; i += accuracy)
            {
                res += func(i) * accuracy;
            }
            return res;
        }

        static async Task<double> GetIntegralAsyncStupid(Func<double, double> func, double a, double b, int n, double accuracy = 1e-8)
        {
            double x = (b - a) / n, res = 0;
            for (int i = 0; i < n; i++)
            {
                res += await Task.Run(() => GetIntegral(func, a + i * x, a + (i + 1) * x, accuracy));
            }
            return res;
        }

        static async Task<double> GetIntegralAsync(Func<double, double> func, double a, double b, int n, double accuracy = 1e-8)
        {
            double x = (b - a) / n, res = 0;
            Task<double>[] tasks = new Task<double>[n];
            for (int i = 0; i < n; i++)
            {
                var index = i;
                tasks[index] = Task<double>.Run(() => GetIntegral(func, a + index * x, a + (index + 1) * x, accuracy));
            }
            double[] results = await Task.WhenAll(tasks);
            foreach (var i in results)
            {
                res += i;
            }
            return res;
        }

        static void Main(string[] args)
        {
            double a = 0, b = 5;
            int n = 8;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine(GetIntegral(x => x * x, a, b));
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000.0);
            timer.Reset();
            timer.Start();
            Task<double> value = GetIntegralAsyncStupid(x => x * x, a, b, n);
            value.Wait();
            Console.WriteLine(value.Result);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000.0);
            timer.Reset();
            timer.Start();
            value = GetIntegralAsync(x => x * x, a, b, n);
            value.Wait();
            Console.WriteLine(value.Result);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000.0);
        }
    }
}
