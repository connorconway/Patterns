using StrategyPattern.Interfaces.Model;

namespace StrategyPattern.Interfaces.Library.ShippingCostStrategy
{
	public interface IShippingCostStrategy
	{
		double Cost(Order order);
	}
}