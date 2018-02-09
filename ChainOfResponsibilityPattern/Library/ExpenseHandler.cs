using ChainOfResponsibilityPattern.Model;

namespace ChainOfResponsibilityPattern.Library
{
	internal class ExpenseHandler : IExpenseHandler
	{
		private readonly IExpenseApprover _approver;
		private IExpenseHandler _next;

		public ExpenseHandler(IExpenseApprover approver)
		{
			_approver = approver;
			_next = EndOfChainExpenseHander.Instance;
		}

		public ApprovalResponse Approve(IExpenseReport report)
		{
			var response = _approver.ApproveExpense(report);
			return response == ApprovalResponse.BeyondApprovalLimit ? _next.Approve(report) : response;
		}

		public void RegisterNext(IExpenseHandler next)
		{
			_next = next;
		}
	}
}