using BuilderPattern.Model;

namespace BuilderPattern.Library
{
	public abstract class SandwichBuilder
	{
		protected Sandwich Sandwich;

		public Sandwich Result() => Sandwich;

		public void Create()
		{
			Sandwich = new Sandwich();
		}

		public abstract void PrepareBread();
		public abstract void ApplyMeatAndCheese();
		public abstract void ApplyVegetables();
		public abstract void AddCondiments();
	}
}