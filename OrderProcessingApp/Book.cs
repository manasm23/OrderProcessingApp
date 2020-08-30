using System.Runtime.CompilerServices;
using System.Text;

namespace OrderProcessingApp
{
    public class Book : PhysicalProduct
    {
        public string Author { get; set; }

        public Book(string name, string author, decimal price, int qty = 1) : base(name, price, qty)
        {            
            this.Author = author;
        }

        public override string ProcessProduct()
        {
            string fromBase = base.ProcessProduct();

            StringBuilder sb = new StringBuilder();
            sb.Append(fromBase);
            sb.AppendLine("Duplicate packing slip for Royalty department");

            return sb.ToString();
        }
    }
}
