using ChainOfResponsibilityPattern.Library;
using ChainOfResponsibilityPattern.Model;

namespace ChainOfResponsibilityPattern.Tests
{
	internal interface IExpenseHandler
	{
		ApprovalResponse Approve(IExpenseReport report);
		void RegisterNext(IExpenseHandler next);
	}
}