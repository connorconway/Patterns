using System.Collections.Generic;
using BridgePattern.Library.Formatters;
using BridgePattern.Model;
using NUnit.Framework;

namespace BridgePattern.Tests
{
	[TestFixture]
	public class BridgePatternTest
	{
		private List<Manuscript> _documents;

		[SetUp]
		public void SetUp()
		{
			_documents = new List<Manuscript>();
		}

		[Test]
		public void StandardFormatter()
		{
			var formatter = new StandardFormatter();
			CreateManuscriptsWith(formatter);
			foreach (var doc in _documents)
				doc.Print();
		}

		[Test]
		public void BackwardsFormatter()
		{
			var formatter = new BackwardsFormatter();
			CreateManuscriptsWith(formatter);
			foreach (var doc in _documents)
				doc.Print();
		}

		[Test]
		public void FancyFormatter()
		{
			var formatter = new FancyFormatter();
			CreateManuscriptsWith(formatter);
			foreach (var doc in _documents)
				doc.Print();
		}

		private void CreateManuscriptsWith(IFormatter formatter)
		{
			var paper = new TermPaper(formatter) { Class = "Author Class", References = "Paper References", Student = "Paper Author", Text = "Paper Text" };
			var faq = new Faq(formatter) { Title = "FAQ Title", Questions = new Dictionary<string, string> { { "A", "1" }, { "B", "2" } } };
			var book = new Book(formatter) { Author = "Author Connor", Text = "Book Text", Title = "Book Title" };
			_documents.Add(paper);
			_documents.Add(faq);
			_documents.Add(book);
		}
	}
}