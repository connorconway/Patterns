using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Patterns.EventAggregator.Events;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Views
{
	public partial class MainWindow
	{
		private readonly IEventAggregator _eventAggregator;
		private ObservableCollection<Order> _orders;

		public MainWindow()
		{
			InitializeComponent();
			_eventAggregator = new GenericEventAggregator();
			OrderListView.EventAggregator = _eventAggregator;
			AddOrderViews();
			LoadOrders();

			New.Click += New_Click;
			Save.Click += Save_Click;
		}

		private void AddOrderViews()
		{
			var tabs = OrderViews.Items;
			tabs.Add(new TabItem { Header = "Header", Content = new OrderView(_eventAggregator) });
			tabs.Add(new TabItem { Header = "Detail", Content = new OrderDetail(_eventAggregator) });
			tabs.Add(new TabItem { Header = "Order History", Content = new OrderHistory(_eventAggregator) });
		}

		private void LoadOrders()
		{
			_orders = new ObservableCollection<Order>
			{
				new Order {OrderNumber = "1000", Description = "An Order"},
				new Order {OrderNumber = "2000", Description = "Another Order"},
				new Order {OrderNumber = "3000", Description = "Yet Another Order"}
			};
			OrderListView.SetOrders(_orders);
		}

		private void New_Click(object sender, RoutedEventArgs e)
		{
			var order = new Order { Description = "New Order", OrderNumber = "New ID: 1" };
			_orders.Add(order);
			_eventAggregator.Publish(new OrderSelected {Order = order});
		}

		private void Save_Click(object sender, RoutedEventArgs e)
		{
			var order = (Order)OrderListView.OrdersList.SelectedItem;
			_eventAggregator.Publish(new OrderSaved{Order = order});
		}
	}
}
