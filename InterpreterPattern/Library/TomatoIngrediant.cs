namespace InterpreterPattern.Library
{
	public class TomatoIngrediant : IIngrediant
	{
		public void Interpret(Context context)
		{
			context.Output += "Tomato";
		}
	}
}