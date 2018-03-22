using DecoratorPattern.Model;

namespace DecoratorPattern.Library.Decorators
{
	public class Cheese : PizzaDecorator
	{
		private readonly string _description;

		public Cheese(Pizza pizza) : base(pizza)
		{
			_description = "Cheese Topping";
		}

		public override string Description() => Pizza.Description() + ", " + _description;
		public override double Cost() => Pizza.Cost() + 1.25;
	}
}