using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Product
    {
        private string _productName;
        private string _productID;
        private double _price;
        private int _quantity;

        public Product(string productName, string productID, double price, int quantity)
        {
            _productName = productName;
            _productID = productID;
            _price = price;
            _quantity = quantity;
        }
        // Create getters just to display a specific information 
        public string GetProductName()
        {
            return _productName;
        }
        public double GetPrice()
        {

            return _price;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public string GetProductID()
        {
            return _productID;
        }
        public double GetQuantityPrice()
        {
            return _quantity * _price;
        }
    }
}