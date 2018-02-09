using System.Collections.Generic;
using BuilderPattern.Model;

namespace BuilderPattern.Library
{
	public class DifferentSandwichBuilder : SandwichBuilder
	{
		public override void PrepareBread()
		{
			Sandwich.BreadType = BreadType.White;
		}

		public override void ApplyMeatAndCheese()
		{
			Sandwich.MeatType = MeatType.Chicken;
			Sandwich.CheeseType = CheeseType.Cheader;
			Sandwich.IsToasted = true;
		}

		public override void ApplyVegetables()
		{
			Sandwich.Vegetables = new List<string> {"Lettuce"};
		}

		public override void AddCondiments()
		{
			Sandwich.HasMustard = true;
			Sandwich.HasMayo = true;
		}
	}
}