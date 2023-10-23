using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation3
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _zipcode;

        public Address(string street, string city, string state, string zipcode)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipcode = zipcode;
        }
        // Create getters for the street and city and full  address
        public string street
        {
            get { return _street; }
        }
        public string city
        {
            get { return _city; }
        }
        public string FullAddress
        {
            get { return $"{_street}, {_city}, {_state} {_zipcode}"; }
        }
    }
}