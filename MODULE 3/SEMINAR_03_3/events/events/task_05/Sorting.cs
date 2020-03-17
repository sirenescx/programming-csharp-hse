using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_05
{
    public delegate void SortHandler(long cn, int si, int kl);
    class Sorting
    { // класс сортировки массивов    
        int[] ar;   // ссылка на массив
        public long count; // счетчик выполненных обменов при сортировке
        public event SortHandler onSort; // объявление события
        public Sorting(int[] ls)
        { // конструктор            
            count = 0;
            ar = ls;
        }
        public void Sort()
        {// сортировка с посылкой извещений         
            int temp;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                    if (ar[i] > ar[j])
                    {
                        temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                        count++;
                    }
                if (onSort != null) // сортировка не завершена
                    onSort(count, ar.Length, i); // генерация события 
            }
        }
    }

}
