using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Schema;

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
            int totalProducts = Cart.Count;
            decimal totalPrice = 0M;
            
            StringBuilder sb = new StringBuilder();
           
            foreach (Product currentProduct in Cart)
            {
               totalPrice += currentProduct.Price; 
               sb.AppendLine("Processing product: " + currentProduct.Name);
               sb.AppendLine(currentProduct.ProcessProduct());
               sb.AppendLine("-------------------------------");               
            }

            sb.AppendLine("Total items in the order: " + totalProducts.ToString());
            sb.AppendLine("Total Price: $" + totalPrice.ToString());

            return sb.ToString();
        }
    }
}
