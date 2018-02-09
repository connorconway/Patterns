using ChainOfResponsibilityPattern.Model;

namespace ChainOfResponsibilityPattern.Library
{
	public interface IExpenseApprover
	{
		ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
	}
}