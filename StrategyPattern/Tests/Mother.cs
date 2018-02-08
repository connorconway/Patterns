using StrategyPattern.Model;

namespace StrategyPattern.Tests
{
	public static class Mother
	{
		public static Order CreateOrder_UPS() => new Order();
		public static Order CreateOrder_USPS() => new Order();
		public static Order CreateOrder_FedEx() => new Order();
	}
}