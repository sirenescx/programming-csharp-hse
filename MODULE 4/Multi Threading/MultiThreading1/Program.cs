using System;
using System.Diagnostics;
using System.Threading;

namespace MultiThreading1
{
    class Program
    {
        public class MyThread
        {
            Thread thread;
            double a, b, accuracy;
            public double res = 0;
            Func<double, double> func;


            public MyThread(Func<double, double> func, double a, double b, double accuracy = 1e-8)
            {
                thread = new Thread(StartCalculation);
                this.a = a;
                this.accuracy = accuracy;
                this.b = b;
                this.func = func;
                thread.Start();
            }

            void StartCalculation()
            {
                for (double i = a; i < b; i += accuracy)
                {
                    res += func(i) * accuracy;
                }
            }

            public bool endCalculation => !thread.IsAlive;
        }

        static double GetIntegral(Func<double, double> func, double a, double b, double accuracy = 1e-8)
        {
            double res = 0;
            for (double i = a; i < b; i += accuracy)
            {
                res += func(i) * accuracy;
            }
            return res;
        }

        static double GetIntegralParallel(Func<double, double> func, double a, double b, int n, double accuracy = 1e-8)
        {
            MyThread[] threads = new MyThread[n + 1];
            double x = (b - a) / n;

            for (int i = 0; i <= n; i++)
            {
                threads[i] = new MyThread(func, a + x * (i - 1), a + i * x, accuracy);
            }

            bool f = false;
            while (!f)
            {
                f = true;
                foreach (var i in threads)
                    f = f && i.endCalculation;
                Thread.Sleep(0);
            }
            double res = 0;
            foreach (var i in threads)
                res += i.res;
            return res;
        }

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine(GetIntegral(x => x * x, 0, 1));
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000.0);
            timer.Reset();
            timer.Start();
            Console.WriteLine(GetIntegralParallel(x => x * x, 0, 1, 10));
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000.0);
        }
    }
}
