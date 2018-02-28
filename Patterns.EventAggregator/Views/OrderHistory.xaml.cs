using Patterns.EventAggregator.Library;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class OrderHistory : IOrderView
	{
		public OrderHistory()
		{
			InitializeComponent();
		}

		public void OnOrderSelected(Order o)
		{
			Label.Text = $"Order History: {o.OrderNumber}";
		}

		public void OnOrderSaved(Order o)
		{
			Label.Text = $"Order Saved: {o.OrderNumber}";
		}
	}
}
