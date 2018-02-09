namespace BridgePattern.Library.Formatters
{
	public class FancyFormatter : IFormatter
	{
		public string Format(string s)
		{
			return string.Format("--Fancy-- " + s);
		}
	}
}