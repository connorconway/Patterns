using DecoratorPattern.Model;

namespace DecoratorPattern.Library
{
	public class LargePizza : IPizza
	{
		private readonly string _description;

		public LargePizza()
		{
			_description = "Large Pizza";
		}

		public string Description() => _description;

		public double Cost() => 9.00;
	}
}