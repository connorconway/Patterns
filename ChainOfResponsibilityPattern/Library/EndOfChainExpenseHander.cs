using System;
using ChainOfResponsibilityPattern.Model;

namespace ChainOfResponsibilityPattern.Library
{
	internal class EndOfChainExpenseHander : IExpenseHandler
	{
		public static EndOfChainExpenseHander Instance { get; } = new EndOfChainExpenseHander();

		public ApprovalResponse Approve(IExpenseReport report) => ApprovalResponse.Denied;

		public void RegisterNext(IExpenseHandler next) => throw new InvalidOperationException("We are already at the end of the chain");
	}
}