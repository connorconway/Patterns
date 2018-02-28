using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Library
{
	public interface IOrderView
	{
		void OnOrderSelected(Order order);
		void OnOrderSaved(Order order);
	}
}