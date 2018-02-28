using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Events
{
	public class OrderSaved
	{
		public Order Order { get; set; }
	}
}
