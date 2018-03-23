using System.Collections.Generic;

namespace InterpreterPattern.Library
{
	public class IngrediantList : IExpression
	{
		private readonly List<IIngrediant> _ingrediants;

		public IngrediantList(List<IIngrediant> ingrediants)
		{
			_ingrediants = ingrediants;
		}

		public void Interpret(Context context)
		{
			_ingrediants.ForEach(i => i.Interpret(context));
		}
	}
}