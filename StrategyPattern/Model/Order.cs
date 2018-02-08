namespace StrategyPattern.Model
{
	public class Order
	{
		public ShippingOption ShippingMethod { get; set; }

		public enum ShippingOption
		{
			FedEx,
			Ups,
			Usps
		}
	}
}