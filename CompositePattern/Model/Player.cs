namespace CompositePattern.Model
{
	public class Player
	{
		public string Name { get; set; }
		public string Gold { get; set; }
		public string Stats() => $"{Name} : {Gold}";
	}
}