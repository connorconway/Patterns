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
			var documents = new List<Manuscript>();
			var formatter = new BackwardsFormatter();

			var faq = new Faq(formatter) {Title = "FAQ Title", Questions = new Dictionary<string, string> {{"A", "1"}, {"B", "2"}}};
			documents.Add(faq);

			var book = new Book(formatter) {Author = "Author Connor", Text = "Book Text", Title = "Book Title"};
			documents.Add(book);

			var paper = new TermPaper(formatter) {Class = "Author Class", References = "Paper References", Student = "Paper Author", Text = "Paper Text"};
			documents.Add(paper);

			foreach (var doc in documents)
			{
				doc.Print();
			}
		}
	}
}