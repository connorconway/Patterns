using System;

namespace BridgePattern.Model
{
	public class Book : IManuscript
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Text { get; set; }

		public void Print()
		{
			Console.WriteLine($"{Title} {Author} {Text}");
		}
	}
}