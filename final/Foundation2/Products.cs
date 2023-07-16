using System;

namespace Foundation2
{
    public class Product
    {
        public string _name;
        public int _id;
        public decimal _price;
        public int _quantity;

        public Product()
        {
            
        }
        public Product(string name, int id, decimal price, int quantity)
        {
            _name = name;
            _id = id;
            _price = price;
            _quantity = quantity;
        }

        public decimal GetPrice()
        {
            return _price * _quantity;
        } 

    }
}