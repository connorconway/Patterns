using StrategyPattern.Interfaces.Model;

namespace StrategyPattern.Interfaces.Library.ShippingCostStrategy
{
	public class UspsShippingCostStrategy : IShippingCostStrategy
	{
		public double Cost(Order order) => 3.00d;
	}
}