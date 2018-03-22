using DecoratorPattern.Model;

namespace DecoratorPattern.Library
{
	public class SmallPizza : Pizza
	{
		private readonly string _description;

		public SmallPizza()
		{
			_description = "Small Pizza";
		}

		public override string Description() => _description;

		public override double Cost() => 3.00;
	}
}