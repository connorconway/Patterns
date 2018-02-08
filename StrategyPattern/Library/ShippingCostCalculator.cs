using StrategyPattern.Interfaces.Library.ShippingCostStrategy;
using StrategyPattern.Interfaces.Model;

namespace StrategyPattern.Interfaces.Library
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