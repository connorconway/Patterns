using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Controls;
using Patterns.EventAggregator.Events;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class OrdersListView
	{
		public IEventAggregator EventAggregator { private get; set; }

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
			var order = (Order)OrdersList.SelectedItem;
			EventAggregator.Publish(new OrderSelected{Order = order});
		}
	}
}
