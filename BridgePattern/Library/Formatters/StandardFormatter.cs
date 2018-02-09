namespace BridgePattern.Library.Formatters
{
	public class StandardFormatter : IFormatter
	{
		public string Format(string s) => string.Format($"{s}");
	}
}