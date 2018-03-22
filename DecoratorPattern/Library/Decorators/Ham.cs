using DecoratorPattern.Model;

namespace DecoratorPattern.Library.Decorators
{
	public class Ham : PizzaDecorator
	{
		private readonly string _description;

		public Ham(Pizza pizza) : base(pizza)
		{
			_description = "Ham Topping";
		}

		public override string Description() => Pizza.Description() + ", " + _description;
		public override double Cost() => Pizza.Cost() + 1.50;
	}
}