using System;

namespace MementoPattern.Model
{
	public class SalesProspect
	{
		public double Budget { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }

		// Stores memento

		public Memento SaveMemento()
		{
			Console.WriteLine("\nSaving state --\n");
			return new Memento(Name, Phone, Budget);
		}

		// Restores memento

		public void RestoreMemento(Memento memento)
		{
			Console.WriteLine("\nRestoring state --\n");
			Name = memento.Name;
			Phone = memento.Phone;
			Budget = memento.Budget;
		}
	}

	public class Memento
	{
		public string Name;
		public string Phone;
		public double Budget;

		public Memento(string name, string phone, double budget)
		{
			this.Name = name;
			this.Phone = phone;
			this.Budget = budget;
		}
	}
}