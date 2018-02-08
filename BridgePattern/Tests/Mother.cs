using BridgePattern.Model;

namespace BridgePattern.Tests
{
	public class Mother
	{
		public Faq CreateFaq() => new Faq();
	}
}