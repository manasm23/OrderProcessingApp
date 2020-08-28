using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class Membership : Product
    {
        public Membership(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ProcessProduct()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Membership activated");
            sb.AppendLine("Email : Activation successfull");

            return sb.ToString();
        }
    }
}
