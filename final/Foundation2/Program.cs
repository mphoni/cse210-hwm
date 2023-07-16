using System;

namespace Foundation2
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Foundation2 World!");

            Orders order1 = new Orders();
            order1.products.Add(new Product{_name ="a", _id = 20, _price = 20, _quantity = 30});
            order1.products.Add(new Product{_name ="a", _id = 20, _price = 20, _quantity = 30});
            order1.products.Add(new Product{_name ="a", _id = 20, _price = 20, _quantity = 30});

            Orders order2 = new Orders();
            order2.products.Add(new Product{_name ="b", _id = 20, _price = 20, _quantity = 30});
            order2.products.Add(new Product{_name ="b", _id = 20, _price = 20, _quantity = 30});
            order2.products.Add(new Product{_name ="b", _id = 20, _price = 20, _quantity = 30});

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine(order1.GetTotalPrice());

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine(order2.GetTotalPrice());

        }
    }  
}
