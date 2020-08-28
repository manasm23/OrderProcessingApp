using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OrderProcessingApp
{
    public class Order
    {
        public long OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public List<Product> Cart { get; set; }

        static long OrderNum = 0;

        public Order()
        {
            Cart = new List<Product>();
            this.OrderDate = DateTime.Now;
            this.OrderID = ++OrderNum;
        }

        public void AddProduct(Product prod)
        {
            if (prod != null)
                Cart.Add(prod);
        }

        public string CreateOrder()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Product currentProduct in Cart)
            {               
               sb.AppendLine("Processing product: " + currentProduct.Name);
               sb.AppendLine(currentProduct.ProcessProduct());

               sb.AppendLine("-------------------------------");               
            }

            return sb.ToString();
        }
    }
}
