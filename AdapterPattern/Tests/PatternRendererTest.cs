using System;
using System.Collections.Generic;
using System.Linq;
using AdapterPattern.Model;
using NUnit.Framework;

namespace AdapterPattern.Tests
{
	[TestFixture]
	public class PatternRendererTest
	{
		[Test]
		public void RenderTwoPatterns()
		{
			var renderer = new PatternRenderer();
			var data = Data();

			var result = renderer.ListPatterns(data);
			Console.Write(result);

			var lineCount = result.Count(c => c.Equals('\n'));
			Assert.AreEqual(4, lineCount);
		}

		private static IEnumerable<Pattern> Data()
		{
			var list = new List<Pattern>
			{
				new Pattern
				{
					Id = 1,
					Name = "Pattern One",
					Description = "Description One"
				},
				new Pattern
				{
					Id = 2,
					Name = "Pattern Two",
					Description = "Description Two"
				}
			};
			return list;
		}
	}
}