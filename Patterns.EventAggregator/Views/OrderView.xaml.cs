using Patterns.EventAggregator.Library;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class OrderView : IOrderView
	{
		public OrderView()
		{
			InitializeComponent();
		}

		public void OnOrderSelected(Order o)
		{
			Label.Text = $"Order: {o.OrderNumber}";
		}

		public void OnOrderSaved(Order o)
		{
			Label.Text = $"Order Saved: {o.OrderNumber}";
		}
	}
}
