using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Events
{
	public class OrderSelected
	{
		public Order Order { get; set; }
	}
}
