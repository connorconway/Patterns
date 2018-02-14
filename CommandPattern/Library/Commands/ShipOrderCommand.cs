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

		public string CommandName => "ShipOrder";
		public string Description => "ShipOrder number";
		public ICommand MakeCommand(string[] arguments) => new ShipOrderCommand();
	}
}