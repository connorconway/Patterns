using DecoratorPattern.Library;
using NUnit.Framework;

namespace DecoratorPattern.Tests
{
	[TestFixture]
	public class PizzaTests
	{
		[Test]
		public void SmallPizza()
		{
			var pizza = new SmallPizza();
			Assert.AreEqual(pizza.Description(), "Small Pizza");
			Assert.AreEqual(pizza.Cost(), 3.00);
		}

		[Test]
		public void MediumPizza()
		{
			var pizza = new MediumPizza();
			Assert.AreEqual(pizza.Description(), "Medium Pizza");
			Assert.AreEqual(pizza.Cost(), 6.00);
		}

		[Test]
		public void LargePizza()
		{
			var pizza = new LargePizza();
			Assert.AreEqual(pizza.Description(), "Large Pizza");
			Assert.AreEqual(pizza.Cost(), 9.00);
		}
	}
}