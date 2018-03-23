namespace InterpreterPattern.Library
{
	public class WhiteBread : IBread
	{
		public void Interpret(Context context)
		{
			context.Output += "White-Bread";
		}
	}
}