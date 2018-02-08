using StrategyPattern.Library.ShippingCostStrategy;
using StrategyPattern.Model;

namespace StrategyPattern.Library
{
	public class FedExShippingCostStrategy : IShippingCostStrategy
	{
		public double Cost(Order order)
		{
			return 5.00d;
		}
	}
}