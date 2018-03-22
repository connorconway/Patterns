using DecoratorPattern.Model;

namespace DecoratorPattern.Library
{
	public class MediumPizza : IPizza
	{
		private readonly string _description;

		public MediumPizza()
		{
			_description = "Medium Pizza";
		}

		public string Description() => _description;

		public double Cost() => 6.00;
	}
}