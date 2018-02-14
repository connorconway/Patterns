using CommandPattern.Library;
using NUnit.Framework;

namespace CommandPattern.Tests
{
	[TestFixture]
    public class CommandExecutorTest
    {
	    private static CommandParser _parser;

	    [SetUp]
	    public void SetUp()
	    {
		    _parser = new CommandParser();
	    }

	    [Test]
	    public void CreateOrder()
	    {
		    var command = _parser.ParseCommand(new[] { nameof(CreateOrder) });
			Assert.DoesNotThrow(() => command.Execute());
			Assert.DoesNotThrow(() => command.Undo());
		}

	    [Test]
	    public void UpdateQuantity()
	    {
		    var command = _parser.ParseCommand(new [] {nameof(UpdateQuantity), "20"});

		    Assert.DoesNotThrow(() => command.Execute());
		    Assert.DoesNotThrow(() => command.Undo());
		}

	    [Test]
	    public void ShipOrder()
	    {
		    var command = _parser.ParseCommand(new[] { nameof(ShipOrder) });

			Assert.DoesNotThrow(() => command.Execute());
		    Assert.DoesNotThrow(() => command.Undo());
		}

		[Test]
	    public void UnknownCommand()
	    {
		    var command = _parser.ParseCommand(new[] { "ThisCommandDoesNotExist" });

			Assert.DoesNotThrow(() => command.Execute());
		    Assert.DoesNotThrow(() => command.Undo());
		}
    }
}
