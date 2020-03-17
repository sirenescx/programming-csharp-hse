using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart(5);
            Item item = new Item("Orange", 10, 15);
            shoppingCart.AddToCart(item);
            Item item2 = new Item("Milk", 10, 15);
            shoppingCart.AddToCart(item2);
            Item item3 = new Item("Apple", 10, 15);
            shoppingCart.AddToCart(item3);
            Item item4 = new Item("Bread", 10, 15);
            shoppingCart.AddToCart(item4);
            Item item5 = new Item("Juice", 10, 15);
            shoppingCart.AddToCart(item5);
            Console.WriteLine(shoppingCart);
        }
    }
}
