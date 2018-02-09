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
			var report = new ExpenseReport(1000);
			var response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Approved, response);
		}

		[Test]
		public void Expense4900ShouldBeApprovedByGoofy()
		{
			var report = new ExpenseReport(4900);
			var response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Approved, response);
		}

		[Test]
		public void Expense5100ShouldBeApprovedByDaisy()
		{
			var report = new ExpenseReport(5100);
			var response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Approved, response);
		}

		[Test]
		public void Expense11000ShouldNotBeApproved()
		{
			var report = new ExpenseReport(11000);
			var response = _initialApprover.Approve(report);
			Assert.AreEqual(ApprovalResponse.Denied, response);
		}
	}
}