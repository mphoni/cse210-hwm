using System;

namespace Foundation2
{
    public class Customer
    {
        public string _name;
        public Address address1;

   
        public Customer()
        {
           
            address1.GetCountry();
            address1.ToString();
            
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name )
        {
            _name = name;
        }

        public bool IsInUSA()
        {
            return this.address1.IsInUSA();
        }

        public void Display()
        {
            Console.WriteLine(GetName());
        }
    }
}