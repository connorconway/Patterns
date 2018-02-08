using NUnit.Framework;
using StrategyPattern.Interfaces.Library;
using StrategyPattern.Interfaces.Library.ShippingCostStrategy;

namespace StrategyPattern.Interfaces.Tests
{
	[TestFixture]
	internal class ShippingCostCalculatorTest
	{
		[Test]
		public void Shipping_via_Ups()
		{
			var strategy = new UpsShippingCostStrategy();
			var calc = new ShippingCostCalculator(strategy);
			var order = Mother.CreateOrder();
			var cost = calc.Cost(order);
			Assert.AreEqual(4.25d, cost);
		}

		[Test]
		public void Shipping_via_Usps()
		{
			var strategy = new UspsShippingCostStrategy();
			var calc = new ShippingCostCalculator(strategy);
			var order = Mother.CreateOrder();
			var cost = calc.Cost(order);
			Assert.AreEqual(3,00d, cost);
		}

		[Test]
		public void Shipping_Via_FedEx()
		{
			var strategy = new FedExShippingCostStrategy();
			var calc = new ShippingCostCalculator(strategy);
			var order = Mother.CreateOrder();
			var cost = calc.Cost(order);
			Assert.AreEqual(5,00d, cost);
		}
	}
}
