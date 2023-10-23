using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Customer
    {
        private string _name;
        private Address _address;
        //  Set customer information and pass the Address Class to this class
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }
        // This method will confirm if the customer is living in the usa or not
        public bool Region()
        {
            return _address.GetCountryRegion();
        }
        // Create the Shipping Label 
        public void GetCustomerDetails()
        {
            Console.WriteLine($"name: {_name}");
            Console.WriteLine($"Address: {_address.GetAddress()}\n");
        }
    }
}