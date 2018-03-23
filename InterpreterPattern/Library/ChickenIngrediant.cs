namespace InterpreterPattern.Library
{
	public class ChickenIngrediant : IIngrediant
	{
		public void Interpret(Context context)
		{
			context.Output += "Chicken";
		}
	}
}