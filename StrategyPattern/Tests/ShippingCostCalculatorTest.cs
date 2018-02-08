using NUnit.Framework;
using StrategyPattern.Library;

namespace StrategyPattern.Tests
{
	[TestFixture]
	class ShippingCostCalculatorTest
	{
		[Test]
		public void Shippiong_via_Ups()
		{
			var calc = new ShippingCostCalculator();
			var order = Mother.CreateOrder_UPS();
			var cost = calc.Cost(order);
			Assert.AreEqual(4.25d, cost);
		}

		[Test]
		public void Shippiong_via_Usps()
		{
			var calc = new ShippingCostCalculator();
			var order = Mother.CreateOrder_USPS();
			var cost = calc.Cost(order);
			Assert.AreEqual(3,00d, cost);
		}

		[Test]
		public void Shipping_Via_FedEx()
		{
			var calc = new ShippingCostCalculator();
			var order = Mother.CreateOrder_FedEx();
			var cost = calc.Cost(order);
			Assert.AreEqual(5,00d, cost);
		}
	}
}
