using System;
using System.Linq;

namespace BridgePattern.Model
{
	public class BackwardsFormatter : IFormatter
	{
		public string Format(string s) => string.Format($"{s.Reverse()}");
	}
}