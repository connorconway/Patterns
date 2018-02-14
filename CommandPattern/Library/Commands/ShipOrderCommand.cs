using System;

namespace CommandPattern.Library.Commands
{
	public class ShipOrderCommand : ICommand, ICommandFactory
	{
		public void Execute()
		{
			//Simulate logging
			Console.WriteLine("Order Shipped");
		}

		public void Undo()
		{
			Console.WriteLine("Unable to undo once the order has been shipped");
		}

		public string CommandName => "ShipOrder";
		public string Description => "ShipOrder number";
		public ICommand MakeCommand(string[] arguments) => new ShipOrderCommand();
	}
}