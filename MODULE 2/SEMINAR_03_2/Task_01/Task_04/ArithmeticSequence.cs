
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_04
{
    class ArithmeticSequence
    {
        double _start;
        double _increment;

        public ArithmeticSequence()
        {
            _start = 0;
            _increment = 1;
        }

        public ArithmeticSequence(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }

        public double this[int index]
        {
            get
            {
                return _start + (index - 1) * _increment;
            }
        }

        public override string ToString()
        {
            return $"Начальное значение последовательности = {_start:f3}, разность прогрессии = {_increment:f3}";
        }

        public double GetSum(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
                sum += this[i];
            return sum;
        }

    }
}