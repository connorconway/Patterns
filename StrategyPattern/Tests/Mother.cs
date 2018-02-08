using StrategyPattern.Model;

namespace StrategyPattern.Tests
{
	public static class Mother
	{
		public static Order CreateOrder_UPS() => new Order{ShippingMethod =  Order.ShippingOption.Ups};
		public static Order CreateOrder_USPS() => new Order{ShippingMethod =  Order.ShippingOption.Usps};
		public static Order CreateOrder_FedEx() => new Order{ShippingMethod =  Order.ShippingOption.FedEx};
	}
}