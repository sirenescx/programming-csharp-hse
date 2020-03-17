using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Multiple
    {
         public readonly string name;
         public readonly int divisor;
        public readonly int[] set;
         public readonly List<int> listSet;

      //  public string name;
      //  public int divisor;
      //  public List<int> listSet;
        public Multiple() { }

        public Multiple(int divisor, List<int> list)
        {
            if (divisor <= 0 || divisor > 9)
                throw new Exception("Неверно выбран делитель!");
            this.divisor = divisor;

            switch (divisor)
            {
                case 1: name = "один"; break;
                case 2: name = "два"; break;
                case 3: name = "три"; break;
                case 4: name = "четыре"; break;
                case 5: name = "пять"; break;
                case 6: name = "шесть"; break;
                case 7: name = "семь"; break;
                case 8: name = "восемь"; break;
                case 9: name = "девять"; break;
            }

            List<int> temp = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % divisor == 0) temp.Add(list[i]);
            }
            listSet = temp;
        }

        public Multiple(int divisor, int[] set)
        {
            if (divisor <= 0 || divisor > 9)
                throw new Exception("Неверно выбран делитель!");
            this.divisor = divisor;

            switch (divisor)
            {
                case 1: name = "один"; break;
                case 2: name = "два"; break;
                case 3: name = "три"; break;
                case 4: name = "четыре"; break;
                case 5: name = "пять"; break;
                case 6: name = "шесть"; break;
                case 7: name = "семь"; break;
                case 8: name = "восемь"; break;
                case 9: name = "девять"; break;
            }
            int[] temp = new int[set.Length];
            int numb = 0;
            for (int i = 0; i < set.Length; i++)
                if (set[i] % divisor == 0) temp[numb++] = set[i];
            this.set = new int[numb];
            Array.Copy(temp, this.set, numb);
        }

        public override string ToString()
        {
            string res = "Делитель: " + this.divisor + " - " + name + "\nКратные: ";
            if (set != null)
            {
                foreach (int x in set)
                    res += x + "  ";
            }
            if (listSet != null)
            {
                foreach (int x in listSet)
                    res += x + "  ";
            }
            return res;
        }

    }
}
