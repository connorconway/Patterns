using System.Collections.Generic;
using BridgePattern.Model;
using NUnit.Framework;

namespace BridgePattern.Tests
{
	[TestFixture]
	public class BridgePatternTest
	{
		[Test]
		public void Test()
		{
			var documents = new List<IManuscript>();

			var faq = new Faq {Questions = new Dictionary<string, string> {{"A", "1"}, {"B", "2"}}};
			documents.Add(faq);

			var book = new Book {Author = "Connor", Text = "This book....", Title = "Amazing Book"};
			documents.Add(book);

			var paper = new TermPaper {Class = "21", References = "All of them", Student = "Connor", Text = "WOW"};
			documents.Add(paper);

			foreach (var doc in documents)
			{
				doc.Print();
			}
		}
	}
}