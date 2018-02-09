using System.Collections.Generic;
using BuilderPattern.Model;
using NUnit.Framework;

namespace BuilderPattern.Tests
{
	[TestFixture]
	internal class BuilderPatternTest
	{
		[Test]
		public void NewSandwich()
		{
			var sandwich = new Sandwich(BreadType.Brown, false, CheeseType.Cheader, MeatType.Beef, false, true, new List<string>{"Tomato"});
			sandwich.Display();
		}
	}
}
