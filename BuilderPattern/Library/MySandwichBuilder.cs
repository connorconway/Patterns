using System.Collections.Generic;
using BuilderPattern.Model;

namespace BuilderPattern.Library
{
	public class MySandwichBuilder : SandwichBuilder
	{
		public override void PrepareBread()
		{
			Sandwich.BreadType = BreadType.Brown;
		}

		public override void ApplyMeatAndCheese()
		{
			Sandwich.MeatType = MeatType.Beef;
			Sandwich.CheeseType = CheeseType.Cheader;
			Sandwich.IsToasted = false;
		}

		public override void ApplyVegetables()
		{
			Sandwich.Vegetables = new List<string> {"Tomato", "Lettuce"};
		}

		public override void AddCondiments()
		{
			Sandwich.HasMustard = false;
			Sandwich.HasMayo = true;
		}
	}
}