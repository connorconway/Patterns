using CompositePattern.Library;

namespace CompositePattern.Model
{
	public class Player : IParty
	{
		public string Name { get; set; }
		public int Gold { get; set; }
		public string Stats() => $"{Name} : {Gold}";
	}
}