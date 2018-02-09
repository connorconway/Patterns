using ChainOfResponsibilityPattern.Model;

namespace ChainOfResponsibilityPattern.Library
{
	internal interface IExpenseHandler
	{
		ApprovalResponse Approve(IExpenseReport report);
		void RegisterNext(IExpenseHandler next);
	}
}