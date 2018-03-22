namespace DecoratorPattern.Model
{
	public abstract class Pizza
	{
		private string _description;

		public abstract string Description();
		public abstract double Cost();
	}
}