using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class Membership : Product
    {   
        public override string ProcessOrder()
        {
            return "Membership activated";
        }
    }
}
