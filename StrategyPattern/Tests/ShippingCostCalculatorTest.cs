using NUnit.Framework;
using StrategyPattern.Library;
using StrategyPattern.Library.ShippingCostStrategy;

namespace StrategyPattern.Tests
{
	[TestFixture]
	internal class ShippingCostCalculatorTest
	{
		[Test]
		public void Shippiong_via_Ups()
		{
			var strategy = new UpsShippingCostStrategy();
			var calc = new ShippingCostCalculator(strategy);
			var order = Mother.CreateOrder_UPS();
			var cost = calc.Cost(order);
			Assert.AreEqual(4.25d, cost);
		}

		[Test]
		public void Shippiong_via_Usps()
		{
			var strategy = new UspsShippingCostStrategy();
			var calc = new ShippingCostCalculator(strategy);
			var order = Mother.CreateOrder_USPS();
			var cost = calc.Cost(order);
			Assert.AreEqual(3,00d, cost);
		}

		[Test]
		public void Shipping_Via_FedEx()
		{
			var strategy = new FedExShippingCostStrategy();
			var calc = new ShippingCostCalculator(strategy);
			var order = Mother.CreateOrder_FedEx();
			var cost = calc.Cost(order);
			Assert.AreEqual(5,00d, cost);
		}
	}
}
