using DecoratorPattern.Model;

namespace DecoratorPattern.Library.Decorators
{
	public class Peppers : PizzaDecorator
	{
		private readonly string _description;

		public Peppers(Pizza pizza) : base(pizza)
		{
			_description = "Pepper Topping";
		}

		public override string Description() => Pizza.Description() + ", " + _description;
		public override double Cost() => Pizza.Cost() + 0.20;
	}
}