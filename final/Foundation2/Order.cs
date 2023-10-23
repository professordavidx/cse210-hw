using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Order
    {
        private Customer _customer;
        private List<Product> _productList = new List<Product>();
        private double _shippingCost;
        private double _totalPayment;

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }
        // Add the shipping cost according to where customer is living
        public double GetShippingCost()
        {
            if (_customer.Region())
            {
                _shippingCost = 5;
            }
            else
            {
                _shippingCost = 35;
            }
            return _shippingCost;
        }
        // Create Packing label for receipt
        public void PackingLabel()
        {
            int count = 0;
            foreach (Product product in _productList)
            {
                count++;
                Console.WriteLine($"{count}. {product.GetProductName()}({product.GetProductID()}) Product price: ${product.GetPrice()}, quantity: {product.GetQuantity()} price: ${product.GetQuantityPrice()}");
                _totalPayment += product.GetQuantityPrice();
            }

        }
        // Create receipt using previous methods
        public void DisplayReceipt()
        {
            Console.WriteLine("\nPurchase Receipt");
            Console.WriteLine("-------------------------------------------------------------");
            PackingLabel();
            Console.WriteLine($"\nSubtotal: ${_totalPayment}");
            Console.WriteLine($"Shipping Cost: ${GetShippingCost()}");
            _totalPayment += GetShippingCost();
            Console.WriteLine($"Total: ${_totalPayment}");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Shipping Address:\n");
            _customer.GetCustomerDetails();

            Console.WriteLine("Thank you for your order!\n");
        }
    }
}