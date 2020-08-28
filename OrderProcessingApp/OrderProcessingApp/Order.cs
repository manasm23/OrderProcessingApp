using System;
using System.Collections.Generic;

namespace OrderProcessingApp
{
    public class Order
    {
        public string OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public List<Product> Cart { get; set; }


        public void AddProduct(List<Product> prod)
        {
            foreach (Product p in prod)
            {

            };
        }

        public string CreateOrder()
        {
            return null;
        }
    }
}
