using StrategyPattern.Library.ShippingCostStrategy;
using StrategyPattern.Model;

namespace StrategyPattern.Library
{
	public class ShippingCostCalculator
	{
		private readonly IShippingCostStrategy _shippingMethod;

		public ShippingCostCalculator(IShippingCostStrategy strategy)
		{
			_shippingMethod = strategy;
		}

		public double Cost(Order order) => _shippingMethod.Cost(order);
	}
}