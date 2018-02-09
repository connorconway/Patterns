using System.Collections.Generic;
using ChainOfResponsibilityPattern.Library;
using ChainOfResponsibilityPattern.Model;
using NUnit.Framework;

namespace ChainOfResponsibilityPattern.Tests
{
	[TestFixture]
	public class ExpenseApprovalTest
	{
		private List<Employee> _managers;

		[SetUp]
		public void SetUp()
		{
			_managers = new List<Employee>
			{
				new Employee("Donald", decimal.Zero),
				new Employee("Mickey", new decimal(1000)),
				new Employee("Goofy", new decimal(5000)),
				new Employee("Daisy", new decimal(10000))
			};
		}

		[Test]
		public void Expense1000ShouldBeApprovedByMickey()
		{
			IExpenseReport report = new ExpenseReport(1000);
			var expenseProcessed = false;
			var managerApproved = "";
			foreach (var manager in _managers)
			{
				var response = manager.ApproveExpense(report);
				if (response != ApprovalResponse.BeyondApprovalLimit)
				{
					expenseProcessed = true;
					managerApproved = manager.Name;
					break;
				}
			}

			Assert.IsTrue(expenseProcessed);
			Assert.AreEqual("Mickey", managerApproved);
		}

		[Test]
		public void Expense4900ShouldBeApprovedByGoofy()
		{
			IExpenseReport report = new ExpenseReport(4900);
			var expenseProcessed = false;
			var managerApproved = "";
			foreach (var manager in _managers)
			{
				var response = manager.ApproveExpense(report);
				if (response != ApprovalResponse.BeyondApprovalLimit)
				{
					expenseProcessed = true;
					managerApproved = manager.Name;
					break;
				}
			}

			Assert.IsTrue(expenseProcessed);
			Assert.AreEqual("Goofy", managerApproved);
		}

		[Test]
		public void Expense5100ShouldBeApprovedByDaisy()
		{
			IExpenseReport report = new ExpenseReport(5100);
			var expenseProcessed = false;
			var managerApproved = "";
			foreach (var manager in _managers)
			{
				var response = manager.ApproveExpense(report);
				if (response != ApprovalResponse.BeyondApprovalLimit)
				{
					expenseProcessed = true;
					managerApproved = manager.Name;
					break;
				}
			}

			Assert.IsTrue(expenseProcessed);
			Assert.AreEqual("Daisy", managerApproved);
		}

		[Test]
		public void Expense11000ShouldNotBeApproved()
		{
			IExpenseReport report = new ExpenseReport(11000);
			var expenseProcessed = false;
			foreach (var manager in _managers)
			{
				var response = manager.ApproveExpense(report);
				if (response != ApprovalResponse.BeyondApprovalLimit)
				{
					expenseProcessed = true;
					break;
				}
			}

			Assert.IsFalse(expenseProcessed);
		}
	}
}