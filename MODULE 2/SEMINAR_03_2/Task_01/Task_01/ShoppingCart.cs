using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class ShoppingCart
    {
        private int _capacity;
        private int _totalItem;
        private int _totalPrice;
        public Item[] _cart;

        public ShoppingCart(int capacity)
        {
            _capacity = capacity;
            _cart = new Item[_capacity];

        }

        public ShoppingCart() : this(7) { }

        private void IncreaseSize()
        {
            Item[] temp = new Item[_capacity * 2];
            for (int i = 0; i < _capacity; i++)
            {
                temp[i] = _cart[i];
            }
            _capacity += 3;
            _cart = temp;
        }

        public void AddToCart(Item item)
        {
            if (_totalItem == _capacity)
                IncreaseSize();
            _cart[_totalItem] = item;
            _totalItem++;
            _totalPrice += item.Price * item.Quantity;
        }

        public override string ToString()
        {
            string res = "Список покупок" + "\n";
            for (int i = 0; i < _totalItem; i++)
            {
                res += _cart[i] + "\n";
            }
            res += $"\nTotalPrice: {_totalPrice}\n";
            return res;
        }
    }
}
