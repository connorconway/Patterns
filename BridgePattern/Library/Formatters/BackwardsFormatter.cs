using BridgePattern.Model;

namespace BridgePattern.Library.Formatters
{
	public class BackwardsFormatter : IFormatter
	{
		public string Format(string s) => string.Format($"{s.Backwards()}");
	}
}