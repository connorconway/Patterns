using StrategyPattern.Model;

namespace StrategyPattern.Library.ShippingCostStrategy
{
	public class UspsShippingCostStrategy : IShippingCostStrategy
	{
		public double Cost(Order order)
		{
			return 3.00d;
		}
	}
}