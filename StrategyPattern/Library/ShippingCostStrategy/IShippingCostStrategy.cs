using StrategyPattern.Model;

namespace StrategyPattern.Library.ShippingCostStrategy
{
	public interface IShippingCostStrategy
	{
		double Cost(Order order);
	}
}