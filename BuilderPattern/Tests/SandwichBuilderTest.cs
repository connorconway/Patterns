using BuilderPattern.Library;
using NUnit.Framework;

namespace BuilderPattern.Tests
{
	[TestFixture]
	internal class SandwichBuilderTest
	{
		[Test]
		public void MySandwichBuilder()
		{
			var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
			sandwichMaker.Build();
			var sandwich = sandwichMaker.Sandwich();
			Assert.DoesNotThrow(() => sandwich.Display());
		}

		[Test]
		public void DifferentSandwichBuilder()
		{
			var sandwichMaker = new SandwichMaker(new DifferentSandwichBuilder());
			sandwichMaker.Build();
			var sandwich = sandwichMaker.Sandwich();
			Assert.DoesNotThrow(() => sandwich.Display());
		}
	}
}
