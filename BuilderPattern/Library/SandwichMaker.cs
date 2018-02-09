using BuilderPattern.Model;

namespace BuilderPattern.Library
{
	public class SandwichMaker
	{
		private readonly SandwichBuilder _builder;

		public SandwichMaker(SandwichBuilder builder)
		{
			_builder = builder;
		}

		public void Build()
		{
			_builder.Create();
			_builder.PrepareBread();
			_builder.ApplyMeatAndCheese();
			_builder.ApplyVegetables();
			_builder.AddCondiments();;
		}

		public Sandwich Sandwich()
		{
			return _builder.Result();
		}
	}
}