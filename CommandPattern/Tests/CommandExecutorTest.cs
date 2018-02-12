using CommandPattern.Library;
using NUnit.Framework;

namespace CommandPattern.Tests
{
	[TestFixture]
    public class CommandExecutorTest
    {
	    [Test]
	    public void ToDo()
	    {
		    var executor = new CommandExecutor();
			executor.ExecuteCommand(new [] { "UpdateQuantity" , "10"});
	    }
    }
}
