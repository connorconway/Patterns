using System;

namespace BridgePattern.Model
{
	public class TermPaper : IManuscript
	{
		public string Class { get; set; }
		public string Student { get; set; }
		public string Text { get; set; }
		public string References { get; set; }

		public void Print()
		{
			Console.WriteLine($"{Class} {Student} {Text} {References}");
		}
	}
}