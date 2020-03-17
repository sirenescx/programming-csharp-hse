using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Man
    {
        abstract public void OnJailEscapeEventHandler();
        int id;
        public Jail jail;
        //

        protected Man(int id, Jail jail)
        {
            this.id = id;
            this.jail = jail;
        }

        public int ID { get => id; set => id = value; }
    }
}
