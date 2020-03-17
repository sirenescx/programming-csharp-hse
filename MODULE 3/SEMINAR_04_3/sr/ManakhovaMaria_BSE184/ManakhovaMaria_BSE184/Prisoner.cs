using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Prisoner : Man
    {
        public Prisoner(int id, Jail jail) : base(id, jail)
        {
        }

        public override void OnJailEscapeEventHandler()
        {
            if (jail.isLocked == false)
            //if (Jail.isLocked == false)
            {
                Console.WriteLine($"Escape from prison was successful, ID = {ID}");
            }
            else Console.WriteLine($"Escape from prison was failed, ID = {ID}");
        }

        public override string ToString() => $"{this.GetType()}, ID = {ID}";
    }
}
