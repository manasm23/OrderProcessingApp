using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order objOrder = new Order();
            objOrder.AddProduct(new Book("New Book","Test Author", 10.5m));
            objOrder.AddProduct(new PhysicalProduct("Table",100m));
            objOrder.AddProduct(new UpgradeMembership("Club Membership", 150.3m));

            Console.WriteLine(objOrder.CreateOrder());

            Console.ReadLine();
        }
    }
}
