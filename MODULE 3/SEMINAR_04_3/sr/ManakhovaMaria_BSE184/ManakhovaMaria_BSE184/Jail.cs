using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Событийный делегат
    /// </summary>
    public delegate void JailEscape();
    public class Jail
    {

        public event JailEscape OnJailEscape; 
        bool IsLocked = false; 

        Man[] men; //массив ссылок типа Man

        Random rnd = new Random(); 

        /// <summary>
        /// Свойства дял доступа к полю IsLocked
        /// </summary>
        public bool isLocked { get => IsLocked; set { IsLocked = value; } }
        
        /// <summary>
        /// Метод для перемешивания элементов массива
        /// </summary>
        /// <param name="men"></param>
        /// <returns></returns>
        Man[] Shuffle(Man[] men)
        {
            for (int i = men.Length; i > 0; i--)
            {
                int j = rnd.Next(i);
                Man temp = men[j];
                men[j] = men[i - 1];
                men[i - 1] = temp;
            }
            return men;
        } 

        /// <summary>
        /// Конструктор от целого числа N, где создается массив из N ccылок на объекты класса Man
        /// </summary>
        /// <param name="n"></param>
        public Jail(int n)
        {
            men = new Man[n];
            int numberOfPrisoners = (int)(n * 0.8);
            for (int i = 0; i < men.Length; i++)
            {
                if (numberOfPrisoners > 0)
                {
                    men[i] = new Prisoner(rnd.Next(1, 30), this);
                    numberOfPrisoners--;
                }
                else
                    men[i] = new Jailer(rnd.Next(1, 30), this);
            }

            Shuffle(men);

            for (int i = 0; i < men.Length; i++)
                OnJailEscape += men[i].OnJailEscapeEventHandler;
        }

        /// <summary>
        /// Метод, запускающий событие OnJailEscape, если значение IsLocked ложно
        /// </summary>
        public void StartEscape()
        {
            if (OnJailEscape != null & isLocked == false)
                OnJailEscape();
        }

        /// <summary>
        /// Строка с информацией обо всех людях в тюрьме
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = "";
            foreach (var man in men)
            {
                info += $"{man.ToString()}\n";
            }
            return info;
        }
    }
}
