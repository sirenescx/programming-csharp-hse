using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Item
    {
        public string Name { get; }
        public int Price { get; }
        public int Quantity { get; }

        public Item(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name,-10}, {Price,5}, {Quantity,5}{Price * Quantity,5}";
        }
    }
}
