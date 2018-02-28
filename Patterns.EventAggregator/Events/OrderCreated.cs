using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Events
{
	public class OrderCreated
	{
		public Order Order { get; set; }
	}
}
