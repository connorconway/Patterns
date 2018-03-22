using DecoratorPattern.Model;

namespace DecoratorPattern.Library
{
	public class LargePizza : Pizza
	{
		private readonly string _description;

		public LargePizza()
		{
			_description = "Large Pizza";
		}

		public override string Description() => _description;

		public override double Cost() => 9.00;
	}
}