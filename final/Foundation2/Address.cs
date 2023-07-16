using System;

namespace Foundation2
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string country)
        {
            _country = country;
        }
        public string GetCountry() 
        {
            return _country;
        }

        public void SetStreet(string country)
        {
            _country = country;
        }


        public bool IsInUSA()
        {
            return GetCountry() == "USA" || GetCountry() == "United States";
        }

        public override string ToString()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }

    }
}