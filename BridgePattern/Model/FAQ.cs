using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgePattern.Model
{
	public class Faq : Manuscript
	{
		public Faq(IFormatter formatter) : base(formatter)
		{
		}

		public string Title { get; set; }
		public Dictionary<string, string> Questions { get; set; }

		public override void Print()
		{
			Console.WriteLine(Formatter.Format(Title));
			foreach (var question in Questions)
			{
				Console.WriteLine(Formatter.Format(question.Key + " : " + question.Value));
			}
			Console.WriteLine();
		}
	}
}