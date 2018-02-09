using System.Linq;

namespace BridgePattern.Library
{
	public static class StringExtensions
	{
		public static string Backwards(this string s)
		{
			return new string(s.ToCharArray().Reverse().ToArray());
		}
	}
}
