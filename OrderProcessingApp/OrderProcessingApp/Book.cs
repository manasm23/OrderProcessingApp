using System.Text;

namespace OrderProcessingApp
{
    public class Book : PhysicalProduct
    {
        public string Name { get; set; }
        public string Author { get; set; }


        public override string ProcessOrder()
        {
            string fromBase = base.ProcessOrder();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(fromBase);
            sb.AppendLine("Duplicate packing slip for Royalty department");

            return sb.ToString();
        }
    }
}
