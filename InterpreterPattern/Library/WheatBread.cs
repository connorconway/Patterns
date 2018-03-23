namespace InterpreterPattern.Library
{
	public class WheatBread : IBread
	{
		public void Interpret(Context context)
		{
			context.Output += "Wheat-Bread";
		}
	}
}