﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ProcessProduct()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Packing Slip for Shipping") ;
            sb.AppendLine("Pay commission to agent");

            return sb.ToString();
        }
    }
}
