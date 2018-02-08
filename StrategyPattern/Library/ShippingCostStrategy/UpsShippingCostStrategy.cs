using StrategyPattern.Interfaces.Model;

namespace StrategyPattern.Interfaces.Library.ShippingCostStrategy
{
	public class UpsShippingCostStrategy : IShippingCostStrategy
	{
		public double Cost(Order order) => 4.25d;
	}
}