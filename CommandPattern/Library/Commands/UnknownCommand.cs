using System;

namespace CommandPattern.Library.Commands
{
	public class UnknownCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Could not find command: " + CommandName);
		}

		public string CommandName{ get; set; }
	}
}