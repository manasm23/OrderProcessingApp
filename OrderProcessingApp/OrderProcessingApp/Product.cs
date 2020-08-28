using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public abstract class Product
    {
        public string ProductID { get; set; }
        public decimal Price { get; set; }

        public abstract string ProcessOrder();
    }
}
