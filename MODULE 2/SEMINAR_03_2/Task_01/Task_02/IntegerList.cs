using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_02
{
    class IntegerList
    {
        private static readonly Random Random = new Random();
        private int[] _list;
        public int amount = 0;

        public IntegerList(int size)
        {
            _list = new int[size];
        }

        public void Randomize()
        {
            for (int i = 0; i < _list.Length; i++)
            {
                _list[i] = Random.Next(1, 15);
                amount++;
            }
        }

        public void AddElement(int newVal)
        {
            if (amount >= _list.Length) IncreaseSize(ref _list);
            _list[amount] = newVal;
        }


        public void IncreaseSize(ref int[] _list)
        {
            Array.Resize(ref _list, _list.Length * 2); 
        }

        public void RemoveFirst(int val)
          {
            for (int i = 0; i < amount; i++)
            {
                if (_list[i] == val)
                {
                    for (int j = i; j < amount - 1; j++)
                    {
                        _list[j] = _list[j + 1];
                        if (j + 1 == amount - 1)
                            _list[j + 1] = 0;
                    }
                    amount--;
                    break;
                }
            }
        }

        public void RemoveAll(int val)
        {
            for (int i = 0; i < amount; i++)
            {
                if (_list[i] == val)
                    RemoveFirst(val);
            }
        }

        /// <summary>
        /// Печатает элементы списка с их индексами
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < _list.Length; i++)
                Console.WriteLine(i + ":\t" + _list[i]);
        }
    }

}