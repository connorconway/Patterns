using System;

namespace CommandPattern.Library
{
	public class CommandExecutor
	{
		internal void ExecuteCommand(string[] args)
		{
			switch (args[0])
			{
				case "UpdateQuantity":
					UpdateQuantity(int.Parse(args[1]));
					break;
				case "CreateOrder":
					CreateOrder();
					break;
				case "ShipOrder":
					ShipOrder();
					break;
				default:
					Console.WriteLine("Unrecognised Command");
					break;
			}
		}

		private void UpdateQuantity(int newQuantity)
		{
			//Simulate updating a database
			const int oldQuantity = 5;
			Console.WriteLine("DATABASE: Updated");

			//Simulate logging
			Console.WriteLine($"LOG: Updated order quantity from {oldQuantity} to {newQuantity}");
		}

		private void ShipOrder()
		{
		}

		private void CreateOrder()
		{
		}
	}
}