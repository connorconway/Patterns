using StrategyPattern.Functions.Model;

namespace StrategyPattern.Functions.Tests
{
	public static class Mother
	{
		public static Order CreateOrder() => new Order();
	}
}