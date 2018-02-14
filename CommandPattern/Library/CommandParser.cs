using System.Collections.Generic;
using System.Linq;
using CommandPattern.Library.Commands;
using CommandPattern.Tests;

namespace CommandPattern.Library
{
	public class CommandParser
	{
		private readonly IEnumerable<ICommandFactory> _availableCommands;

		public CommandParser(IEnumerable<ICommandFactory> availableCommands)
		{
			_availableCommands = availableCommands;
		}

		internal ICommand ParseCommand(string[] args)
		{
			var commandName = args[0];
			var command = FindRequestedCommand(commandName);
			return command.MakeCommand(args);
		}

		private ICommandFactory FindRequestedCommand(string commandName)
		{
			return _availableCommands
				.FirstOrDefault(cmd => cmd.CommandName == commandName);
		}
	}
}