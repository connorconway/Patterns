namespace CompositePattern.Library
{
	public interface IParty
	{
		int Gold { get; set; }
		string Name { get; set; }
		string Stats();
	}
}