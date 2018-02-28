using Patterns.EventAggregator.Events;

namespace Patterns.EventAggregator.Views
{
	public partial class OrderHistory : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
	{
		public OrderHistory(IEventAggregator eventAggregator)
		{
			InitializeComponent();
			eventAggregator.Subscribe(this);
		}

		public void OnEvent(OrderSelected e)
		{
			Label.Text = $"Order History: {e.Order.OrderNumber}";
		}

		public void OnEvent(OrderSaved e)
		{
			Label.Text = $"Order Saved: {e.Order.OrderNumber}";
		}
	}
}
