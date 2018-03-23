using System.Collections.Generic;

namespace InterpreterPattern.Library
{
	public class CondimentList : IExpression
	{
		private readonly List<ICondiment> _condiments;

		public CondimentList(List<ICondiment> condiments)
		{
			_condiments = condiments;
		}

		public void Interpret(Context context)
		{
			_condiments.ForEach(c => c.Interpret(context));
		}
	}
}