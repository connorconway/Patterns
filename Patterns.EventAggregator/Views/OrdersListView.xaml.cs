using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Controls;
using Patterns.EventAggregator.Library;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class OrdersListView
	{
		public event EventHandler<OrderEventArgs> OrderSelected;

		public OrdersListView()
		{
			InitializeComponent();
			OrdersList.SelectionChanged += OrdersList_SelectionChanged;
		}

		public void SetOrders(ObservableCollection<Order> orders)
		{
			OrdersList.ItemsSource = orders;
			OrdersList.SelectedIndex = 0;
			orders.CollectionChanged += Orders_CollectionChanged;
		}

		private void Orders_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				OrdersList.SelectedItem = e.NewItems[0];
			}
		}

		private void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var handler = OrderSelected;
			if (handler == null)
				return;

			var order = (Order)OrdersList.SelectedItem;
			OrderSelected?.Invoke(this, new OrderEventArgs {Order = order});
		}
	}
}
