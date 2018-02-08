using StrategyPattern.Interfaces.Model;

namespace StrategyPattern.Interfaces.Library.ShippingCostStrategy
{
	public class FedExShippingCostStrategy : IShippingCostStrategy
	{
		public double Cost(Order order) => 5.00d;
	}
} 