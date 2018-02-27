using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Patterns.EventAggregator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public event EventHandler<OrderEventArgs> OrderCreated;
		public event EventHandler<OrderEventArgs> OrderSaved;

		public ObservableCollection<Order> _orders;

		public MainWindow()
		{
			InitializeComponent();
			AddOrderViews();
			LoadOrders();

			this.New.Click += new RoutedEventHandler(New_Click);
			this.Save.Click += new RoutedEventHandler(Save_Click);
		}

		private void Save_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private void New_Click(object sender, RoutedEventArgs e)
		{
			var order = new Order() {Description = "New Order", OrderNumber = "New Order Number"};
			_orders.Add(order);
		}

		private void AddOrderViews()
		{
			var tabs = this.OrderViews.Items;
			tabs.Add(new TabItem() {Header = "Header", Content = new OrderView()});
			tabs.Add(new TabItem() {Header = "Detail", Content = new OrderDetail()});
			tabs.Add(new TabItem() {Header = "Order History", Content = new OrderHistory()});

			foreach (var tab in tabs)
			{
				var view = (IOrderView) tab.Content;
				OrderCreated += (s, e) => view.OnOrderSelected(e.Order);
				OrderSaved += (s, e) => view.OnOrderSaved(e.Order);
				OrderListView.OrderSelected += (s, e) => view.OnOrderSelected(e.Order);
			}
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
	}
}
