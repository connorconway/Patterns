using DecoratorPattern.Model;

namespace DecoratorPattern.Library
{
	public class SmallPizza : IPizza
	{
		private readonly string _description;

		public SmallPizza()
		{
			_description = "Small Pizza";
		}

		public string Description() => _description;

		public double Cost() => 3.00;
	}
}