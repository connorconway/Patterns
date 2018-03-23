namespace InterpreterPattern.Library
{
	public class KetchupCondiment : ICondiment
	{
		public void Interpret(Context context)
		{
			context.Output += "Ketchup";
		}
	}
}