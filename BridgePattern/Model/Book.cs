using System;

namespace BridgePattern.Model
{
	public class Book : Manuscript
	{
		public Book(IFormatter formatter) : base(formatter)
		{
		}

		public string Title { get; set; }
		public string Author { get; set; }
		public string Text { get; set; }

		public override void Print()
		{
			Console.WriteLine(Formatter.Format($"{Title}"));
			Console.WriteLine(Formatter.Format($"{Author}"));
			Console.WriteLine(Formatter.Format($"{Text}"));
			Console.WriteLine();
		}
	}
}