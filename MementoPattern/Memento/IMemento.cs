namespace MementoPattern.Memento
{
	public interface IMemento
	{
		object State { get; set; }
	}
}