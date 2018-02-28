using Patterns.EventAggregator.Library;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class OrderDetail : IOrderView
	{
		public OrderDetail()
		{
			InitializeComponent();
		}

		public void OnOrderSelected(Order o)
		{
			Label.Text = $"Order Detail: {o.OrderNumber}";
		}

		public void OnOrderSaved(Order o)
		{
			Label.Text = $"Order Saved: {o.OrderNumber}";
		}
	}
}
