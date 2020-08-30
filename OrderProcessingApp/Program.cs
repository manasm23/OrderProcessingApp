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
            objOrder.AddProduct(new Book("New Book","Test Author", 10m, 2));
            objOrder.AddProduct(new PhysicalProduct("Table",100m, 2));
            objOrder.AddProduct(new UpgradeMembership("Club Membership", 150.3m));

            string t = objOrder.CreateOrder();
            Console.WriteLine(objOrder.CreateOrder());

            Console.ReadLine();
        }
    }
}
