using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation2
{
    public class Address
    {
        private string _city;
        private string _streetAddress;
        private string _country;
        private bool _region;

        // Set the Address with city, street address, and country
        public Address(string city, string streetAddress, string country)
        {
            _city = city;
            _streetAddress = streetAddress;
            _country = country;
        }
        public bool GetCountryRegion()
        {
            if (_country != "usa")
            {
                _region = false;
            }
            else
            {
                _region = true;
            }

            return _region;
        }
        public string GetAddress()
        {
            return $"{_city}, {_streetAddress}, {_country}";
        }
    }
}