using System;

namespace InterpreterPattern.Library
{
	public class Sandwhich : IExpression
	{
		private readonly IBread _topBread;
		private readonly IBread _bottomBread;
		private readonly CondimentList _topCondiments;
		private readonly CondimentList _bottomCondiments;
		private readonly IngrediantList _ingrediants;

		public Sandwhich(IBread topBread, IBread bottomBread, CondimentList topCondiments, CondimentList bottomCondiments, IngrediantList ingrediants)
		{
			_topBread = topBread;
			_bottomBread = bottomBread;
			_topCondiments = topCondiments;
			_bottomCondiments = bottomCondiments;
			_ingrediants = ingrediants;
		}

		public void Interpret(Context context)
		{
			context.Output += "|";
			_topBread.Interpret(context);
			context.Output += "|";
			context.Output += "<--";
			_topCondiments.Interpret(context);
			context.Output += "-";
			_ingrediants.Interpret(context);
			context.Output += "-";
			_bottomCondiments.Interpret(context);
			context.Output += "-->";
			context.Output += "|";
			_bottomBread.Interpret(context);
			context.Output += "|";
			Console.WriteLine(context.Output);
		}
	}
}