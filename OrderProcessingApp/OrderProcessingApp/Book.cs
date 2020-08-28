using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class Book : PhysicalProduct
    {
        public string Name { get; set; }
        public string Author { get; set; }        
    }
}
