namespace CommandPattern.Library.Commands
{
	public interface ICommand
	{
		//void Validate();
		void Execute();
		void Undo();
	}
}