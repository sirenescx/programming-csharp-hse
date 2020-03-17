using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Jailer : Man
    {
        public Jailer(int id, Jail jail) : base(id, jail)
        {
        }

        public override void OnJailEscapeEventHandler()
        {
            if (jail.isLocked == false)
            {
                jail.isLocked = true;
                Console.WriteLine($"Jail is locked, ID = {ID}");
            }
            else Console.WriteLine($"Jail is already locked, ID = {ID}");
        }

        public override string ToString() => $"{this.GetType()}, ID = {ID}";
    }
}
