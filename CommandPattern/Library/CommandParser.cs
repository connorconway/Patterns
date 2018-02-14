using System.Collections.Generic;
using System.Linq;
using CommandPattern.Library.Commands;

namespace CommandPattern.Library
{
	public class CommandParser
	{
		private readonly IEnumerable<ICommandFactory> _availableCommands;

		public CommandParser()
		{
			_availableCommands = GetAvailableCommands();
		}

		internal ICommand ParseCommand(string[] args)
		{
			var commandName = args[0];
			var command = FindRequestedCommand(commandName);
			if (command == null)
				return new UnknownCommand{CommandName = args[0]};
			return command.MakeCommand(args);
		}

		private ICommandFactory FindRequestedCommand(string commandName)
		{
			return _availableCommands
				.FirstOrDefault(cmd => cmd.CommandName == commandName);
		}

		private static IEnumerable<ICommandFactory> GetAvailableCommands()
		{
			return new ICommandFactory[]
			{
				new CreateOrderCommand(),
				new UpdateQuantityCommand(),
				new ShipOrderCommand()
			};
		}
	}
}