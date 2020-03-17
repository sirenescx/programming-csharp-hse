using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Square
    {
        private int[][] _square;

        public Square(int size)
        {
            _square = new int[size][];
        }

        public int SumRow(int row)
        {
            int _sumrow = 0;
            for (int i = 0; i < _square.Length; i++)
                {
                    _sumrow += _square[row][i];
                }
            return _sumrow;
        }

        public int SumCol(int col) {
            int _sumcol = 0;
                for (int i = 0; i < _square.Length; i++)
                {
                    _sumcol += _square[col][i];
                }
            return _sumcol;
        }

        public int SumMainDiagonal() {
            int _summaindiag = 0;
                for (int i = 0; i < _square.Length; i++)
                    for (int j = 0; j < _square.Length; j++)
                    {
                        if (i == j)
                            _summaindiag += _square[i][j];
                    }
            return _summaindiag;
        }

        public int SumOtherDiagonal()
        {
            int _sumotherdiag = 0;
                for (int i = 0; i < _square.Length; i++)
                    for (int j = 0; j < _square.Length; j++)
                    {
                        if (i + j == _square.Length - 1)
                            _sumotherdiag += _square[i][j];
                    }
            return _sumotherdiag;
        }

        public bool Magic() {
            int a1 = 0, a2 = 0, a3, a4;
            bool flag1 = false, flag2 = false;
            for (int i = 0; i < _square.Length - 1; i++)
                if (SumRow(i) == SumRow(i+1))
                {
                    flag1 = true;
                    a1 = SumRow(i);
                }

            for (int j = 0; j < _square.Length - 1; j++)
                if (SumCol(j) == SumCol(j + 1))
                {
                    flag2 = true;
                    a2 = SumCol(j);
                }

            a3 = SumMainDiagonal();
            a4 = SumOtherDiagonal();

            if ((flag1 == true) && (flag2 == true) && (a1 == a2) && (a3 == a4) && (a3 == a2))
                return true;
            else return false;
        }

        public void ReadSquare(string[] lines, int lineIndex)
        {
            for (int row = 0; row < _square.Length; row++)
            {
                string[] line = lines[lineIndex + row].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (line.Length != _square.Length)
                    Console.WriteLine($"Ошибка при чтении квадрата: строка должна содержать {_square.Length} " +
                        $"значений, а содержит {line.Length}");

                _square[row] = new int[line.Length];

                    for (int i = 0; i < _square.Length; i++)
                        int.TryParse(line[i], out _square[row][i]);
            }
        }

        public void PrintSquare() {
            try
            {
                for (int i = 0; i < _square.Length; i++)
                {
                    Console.WriteLine();

                    for (int j = 0; j < _square.Length; j++)
                    {
                        Console.Write("{0,-5}", _square[i][j]);
                    }
                }
            } catch (NullReferenceException)
                {

                }

    }
    }
}
