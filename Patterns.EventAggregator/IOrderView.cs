namespace Patterns.EventAggregator
{
	public interface IOrderView
	{
		void OnOrderSelected(Order order);
		void OnOrderSaved(Order order);
	}
}