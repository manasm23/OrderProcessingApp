using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class PhysicalProduct : Product
    {
        public override string ProcessOrder()
        {
            return "Packing Slip for Shipping";
        }
    }
}
