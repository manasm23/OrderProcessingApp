using System.Text;

namespace OrderProcessingApp
{
    public class UpgradeMembership : Membership
    {
        public UpgradeMembership(string name, decimal price) : base(name, price)
        {
           
        }

        public override string ProcessProduct()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apply Upgrade");
            sb.AppendLine("Email : Upgradation successfull");

            return sb.ToString();
        }
    }
}
