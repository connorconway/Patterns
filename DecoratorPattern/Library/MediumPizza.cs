using DecoratorPattern.Model;

namespace DecoratorPattern.Library
{
	public class MediumPizza : Pizza
	{
		private readonly string _description;

		public MediumPizza()
		{
			_description = "Medium Pizza";
		}

		public override string Description() => _description;

		public override double Cost() => 6.00;
	}
}