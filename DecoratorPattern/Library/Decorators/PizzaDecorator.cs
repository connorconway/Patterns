using DecoratorPattern.Model;

namespace DecoratorPattern.Library.Decorators
{
	public class PizzaDecorator : Pizza
	{
		protected readonly Pizza Pizza;

		protected PizzaDecorator(Pizza pizza)
		{
			Pizza = pizza;
		}

		public override string Description() => Pizza.Description();

		public override double Cost() => Pizza.Cost();
	}
}