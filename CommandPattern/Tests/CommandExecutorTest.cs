using System.Collections.Generic;
using CommandPattern.Library;
using CommandPattern.Library.Commands;
using NUnit.Framework;

namespace CommandPattern.Tests
{
	[TestFixture]
    public class CommandExecutorTest
    {
	    [Test]
	    public void CreateOrder()
	    {
		    var availableCommands = GetAvailableCommands();
		    var parser = new CommandParser(availableCommands);
		    var command = parser.ParseCommand(new[] { "UpdateQuantity", "20" });

		    command.Execute();
	    }

	    [Test]
	    public void UpdateQuantity()
	    {
		    var availableCommands = GetAvailableCommands();
			var parser = new CommandParser(availableCommands);
		    var command = parser.ParseCommand(new [] {"UpdateQuantity", "20"});

		    command.Execute();
	    }

	    private IEnumerable<ICommandFactory> GetAvailableCommands()
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
