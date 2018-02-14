using System;

namespace CommandPattern.Library.Commands
{
	public class UpdateQuantityCommand : ICommand, ICommandFactory
	{
		private int NewQuantity { get; set; }
		private const int OldQuantity = 5;

		public void Execute()
		{
			//Simulate updating a database
			Console.WriteLine("DATABASE: Updated");

			//Simulate logging
			Console.WriteLine($"LOG: Updated order quantity from {OldQuantity} to {NewQuantity}");
		}

		public void Undo()
		{
			//Simulate reverting a database
			Console.WriteLine("DATABASE: Reverted");

			//Simulate logging
			Console.WriteLine($"LOG: Reverted order quantity to {OldQuantity}");
		}

		public string CommandName => "UpdateQuantity";
		public string Description => "UpdateQuantity number";
		public ICommand MakeCommand(string[] arguments) => new UpdateQuantityCommand {NewQuantity = int.Parse(arguments[1])};
	}
}