namespace InterpreterPattern.Library
{
	public class MustardCondiment : ICondiment
	{
		public void Interpret(Context context)
		{
			context.Output += "Mustard";
		}
	}
}