using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    abstract public class UnitsBase
    {
        static Random rand = new Random();
        protected int unit_code; // номер единицы
        protected double price; // цена за единицу
        protected string name; // название

        public double Discount()
        {
            return price * (1 - rand.Next(0, 75) / 100 * 1.0);
        }
    }

    public class Books : UnitsBase
    {
        private int no_of_pages; // количество страниц в книге
        private bool _isBestSeller; // является ли бестселлером
    }

    public class Cards : UnitsBase
    {
        private string message; // сообщение
    }

    public class CD : UnitsBase
    {
        private int playing_time; // время звучания диска
    }




}
