using Patterns.EventAggregator.Events;

namespace Patterns.EventAggregator.Views
{
	public partial class OrderDetail : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
	{
		public OrderDetail(IEventAggregator eventAggregator)
		{
			InitializeComponent();
			eventAggregator.Subscribe(this);
		}

		public void OnEvent(OrderSelected e)
		{
			Label.Text = $"Order Detail: {e.Order.OrderNumber}";
		}

		public void OnEvent(OrderSaved e)
		{
			Label.Text = $"Order Saved: {e.Order.OrderNumber}";
		}
	}
}
