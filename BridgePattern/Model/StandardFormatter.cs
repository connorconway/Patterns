namespace BridgePattern.Model
{
	public class StandardFormatter : IFormatter
	{
		public string Format(string s) => string.Format($"{s}");
	}
}