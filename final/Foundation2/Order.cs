 using System;

 namespace Foundation2
 {
    
 
 class Orders
    {
        public List<Product> products = new List<Product>();
        public Customer customer1;

        public Orders()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void GetCustomer(Customer address)
        {
            customer1 = address;
        }

         public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.GetPrice();
            }
            if (customer1.address1.GetCountry() == "USA")
            {
                totalPrice += 5;
            }
            else
            {
                totalPrice += 35;
            }
            return totalPrice;
        }
        public string GetPackingLabel()
      {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Name: {product._name}, Product ID: {product._id}\n";
        }
        return packingLabel;
        }

        public string GetShippingLabel()
    {
        string shippingLabel = "";
        if (customer1.address1.GetCountry() == "USA")
        {
            shippingLabel += $"Name: {customer1._name}, Address: {customer1.address1.GetCountry() }, Shipping Cost: $5\n";
        }
        else
        {
            shippingLabel += $"Name: {customer1.GetName}, Address: {customer1.address1.GetCountry() }, Shipping Cost: $35\n";
        }
        return shippingLabel;
    
    }
    }
 } 
 