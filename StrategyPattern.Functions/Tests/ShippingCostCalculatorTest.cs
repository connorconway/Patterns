using NUnit.Framework;
using StrategyPattern.Functions.Library;

namespace StrategyPattern.Functions.Tests
{
	[TestFixture]
	internal class ShippingCostCalculatorTest
	{
		[Test]
		public void Shipping_via_Ups()
		{
			var calc = new ShippingCostCalculator();
			var order = Mother.CreateOrder();
			var cost = calc.Cost(order, ShippingCostCalculator.UpsStrategy);
			Assert.AreEqual(4.25d, cost);
		}

		[Test]
		public void Shipping_via_Usps()
		{
			var calc = new ShippingCostCalculator();
			var order = Mother.CreateOrder();
			var cost = calc.Cost(order, ShippingCostCalculator.UspsStrategy);
			Assert.AreEqual(3,00d, cost);
		}

		[Test]
		public void Shipping_Via_FedEx()
		{
			var calc = new ShippingCostCalculator();
			var order = Mother.CreateOrder();
			var cost = calc.Cost(order, ShippingCostCalculator.FedExStrategy);
			Assert.AreEqual(5,00d, cost);
		}
	}
}
