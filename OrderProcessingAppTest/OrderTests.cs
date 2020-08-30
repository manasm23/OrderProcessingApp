using NUnit.Framework;
using OrderProcessingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppTest
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void CheckOutput_When_Book_ProductType_Added_To_Cart_No_Quantity_Specified()
        {
            Book objBook = new Book("New Book", "Test Author", 20.5m);
            Order objOrder = new Order();
            objOrder.AddProduct(objBook);
            string result = objOrder.CreateOrder();

            StringBuilder expectResult = new StringBuilder();
            expectResult.AppendLine("Processing product: New Book");
            expectResult.AppendLine("Quantity: 1, Price per unit: $20.5");
            expectResult.AppendLine("Packing Slip for Shipping");
            expectResult.AppendLine("Pay commission to agent");
            expectResult.AppendLine("Duplicate packing slip for Royalty department");
            expectResult.AppendLine("-------------------------------");
            expectResult.AppendLine("Total items in the order: " + objBook.Quantity.ToString());
            expectResult.AppendLine("Total Price: $" + objBook.Price.ToString());

            Assert.AreEqual(expectResult.ToString(), result);
        }

        [Test]
        public void CheckOutput_When_Book_ProductType_Added_To_Cart_With_Quantity_Specified()
        {
            Book objBook = new Book("New Book", "Test Author", 20, 5);
            Order objOrder = new Order();
            objOrder.AddProduct(objBook);
            string result = objOrder.CreateOrder();

            StringBuilder expectResult = new StringBuilder();
            expectResult.AppendLine("Processing product: New Book");
            expectResult.AppendLine("Quantity: " + objBook.Quantity + ", Price per unit: $" + objBook.Price);
            expectResult.AppendLine("Packing Slip for Shipping");
            expectResult.AppendLine("Pay commission to agent");
            expectResult.AppendLine("Duplicate packing slip for Royalty department");
            expectResult.AppendLine("-------------------------------");
            expectResult.AppendLine("Total items in the order: " + objBook.Quantity.ToString());
            expectResult.AppendLine("Total Price: $" + (objBook.Price * objBook.Quantity).ToString());

            Assert.AreEqual(expectResult.ToString(), result);
        }
    }
}
