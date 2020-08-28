using System.Text;

namespace OrderProcessingApp
{
    public class UpgradeMembership : Membership
    {
        public override string ProcessOrder()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apply Upgrade");
            sb.AppendLine("Email : Upgradation successfull");

            return sb.ToString();
        }
    }
}
