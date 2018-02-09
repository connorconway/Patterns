using ChainOfResponsibilityPattern.Library;

namespace ChainOfResponsibilityPattern.Model
{
	public class Employee : IExpenseApprover
	{
		public string Name { get; private set; }
		private decimal _approvalLimit;
		
		public Employee(string name, decimal approvalLimit)
		{
			Name = name;
			_approvalLimit = approvalLimit;
		}

		public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
		{
			return expenseReport.Total > _approvalLimit ? ApprovalResponse.BeyondApprovalLimit : ApprovalResponse.Approved;
		}
	}
}