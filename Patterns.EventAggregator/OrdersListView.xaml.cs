using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Controls;

namespace Patterns.EventAggregator
{
	/// <summary>
	/// Interaction logic for OrdersListView.xaml
	/// </summary>
	public partial class OrdersListView : UserControl
	{
		public OrdersListView()
		{
			InitializeComponent();
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
				OrdersList.SelectedItem = e.NewItems[0];
		}
	}
}
