namespace InterpreterPattern.Library
{
	public class LetuceIngrediant : IIngrediant
	{
		public void Interpret(Context context)
		{
			context.Output += "Letuce";
		}
	}
}