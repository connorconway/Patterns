using ChainOfResponsibilityPattern.Library;
using ChainOfResponsibilityPattern.Model;
using NUnit.Framework;

namespace ChainOfResponsibilityPattern.Tests
{
	[TestFixture]
	public class ExpenseApprovalTest
	{
		private ExpenseHandler _initialApprover;

		[SetUp]
		public void SetUp()
		{
			_initialApprover = new ExpenseHandler(new Employee("Donald", decimal.Zero));
			var mickey = new ExpenseHandler(new Employee("Mickey", new decimal(1000)));
			var goofy = new ExpenseHandler(new Employee("Goofy", new decimal(5000)));
			var daisy = new ExpenseHandler(new Employee("Daisy", new decimal(10000)));

			_initialApprover.RegisterNext(mickey);
			mickey.RegisterNext(goofy);
			goofy.RegisterNext(daisy);
		}

		[Test]
		public void Expense1000ShouldBeApprovedByMickey()
		{
			IExpenseReport report = new ExpenseReport(1000);
			ApprovalResponse response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Approved, response);
		}

		[Test]
		public void Expense4900ShouldBeApprovedByGoofy()
		{
			IExpenseReport report = new ExpenseReport(4900);
			ApprovalResponse response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Approved, response);
		}

		[Test]
		public void Expense5100ShouldBeApprovedByDaisy()
		{
			IExpenseReport report = new ExpenseReport(5100);
			ApprovalResponse response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Approved, response);
		}

		[Test]
		public void Expense11000ShouldNotBeApproved()
		{
			IExpenseReport report = new ExpenseReport(11000);
			ApprovalResponse response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Denied, response);
		}
	}
}