namespace ChainOfResponsibilityPattern.Model
{
	public class ExpenseReport : IExpenseReport
	{
		public ExpenseReport(decimal total)
		{
			Total = total;
		}

		public decimal Total { get; private set; }
	}
}