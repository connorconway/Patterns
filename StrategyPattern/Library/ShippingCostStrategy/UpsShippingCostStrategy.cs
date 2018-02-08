using StrategyPattern.Model;

namespace StrategyPattern.Library.ShippingCostStrategy
{
	public class UpsShippingCostStrategy : IShippingCostStrategy
	{
		public double Cost(Order order)
		{
			return 4.25d;
		}
	}
}