using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgePattern.Model
{
	public class Faq : IManuscript
	{
		public string Title { get; set; }
		public Dictionary<string, string> Questions { get; set; }

		public void Print()
		{
			Console.WriteLine($"{Title} {Questions.ToList()}");
		}
	}
}