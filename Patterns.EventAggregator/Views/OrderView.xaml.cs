using Patterns.EventAggregator.Events;

namespace Patterns.EventAggregator.Views
{
	public partial class OrderView : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
	{
		public OrderView(IEventAggregator ea)
		{
			InitializeComponent();
			ea.Subscribe(this);
		}

		public void OnEvent(OrderSelected e)
		{
			Label.Text = $"Order: {e.Order.OrderNumber}";
		}

		public void OnEvent(OrderSaved e)
		{
			Label.Text = $"Order Saved: {e.Order.OrderNumber}";
		}
	}
}