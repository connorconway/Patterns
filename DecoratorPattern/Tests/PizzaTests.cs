using DecoratorPattern.Library;
using DecoratorPattern.Library.Decorators;
using DecoratorPattern.Model;
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

		[Test]
		public void MediumPizzaWithCheese()
		{
			Pizza pizza = new MediumPizza();
			pizza = new Cheese(pizza);
			Assert.AreEqual("Medium Pizza, Cheese Topping", pizza.Description());
			Assert.AreEqual(7.25, pizza.Cost());
		}

		[Test]
		public void LargePizzaWithCheeseAndHam()
		{
			Pizza pizza = new LargePizza();
			pizza = new Cheese(pizza);
			pizza = new Ham(pizza);
			Assert.AreEqual("Large Pizza, Cheese Topping, Ham Topping", pizza.Description());
			Assert.AreEqual(11.75, pizza.Cost());
		}
	}
}