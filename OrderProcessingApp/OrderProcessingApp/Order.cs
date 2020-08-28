using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class Order
    {
        public string OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public List<Product> Cart { get; set; }


        public void AddProduct (Product prod)
        {

        }

        public string CreateOrder()
        {
            return null;
        }
    }
}
