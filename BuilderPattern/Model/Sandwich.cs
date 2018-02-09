using System;
using System.Collections.Generic;

namespace BuilderPattern.Model
{
	public class Sandwich
	{
		public BreadType BreadType { private get; set; }
		public bool IsToasted { private get; set; }
		public CheeseType CheeseType { private get; set; }
		public MeatType MeatType { private get; set; }
		public bool HasMustard { private get; set; }
		public bool HasMayo { private get; set; }
		public List<string> Vegetables { private get; set; }

		public void Display()
		{
			Console.WriteLine($"Sandwich: {BreadType}");
			if (IsToasted)
				Console.WriteLine("Toasted");
			if (HasMayo)
				Console.WriteLine("With Mayo");
			if (HasMustard)
				Console.WriteLine("With Mustard");
			Console.WriteLine($"Meat: {MeatType}");
			Console.WriteLine($"Cheese: {CheeseType}");
			foreach (var vegetable in Vegetables)
				Console.WriteLine($"Vegetable: {vegetable}");
		}
	}
}