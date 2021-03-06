﻿using System;

namespace CommandPattern.Library.Commands
{
	public class CreateOrderCommand : ICommand, ICommandFactory
	{
		public void Execute()
		{
			//Simulate creating a database
			Console.WriteLine("DATABASE: Created");
		}

		public void Undo()
		{
			//Simulate undoing a database
			Console.WriteLine("DATABASE: Removed");
		}

		public string CommandName => "CreateOrder";
		public string Description => "CreateOrder number";
		public ICommand MakeCommand(string[] arguments) => new CreateOrderCommand();
	}
}