using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Patterns.EventAggregator
{
	/// <summary>
	/// Interaction logic for OrderView.xaml
	/// </summary>
	public partial class OrderView : UserControl, IOrderView
	{
		public OrderView()
		{
			InitializeComponent();
		}

		public void OnOrderSelected(Order order)
		{
			this.Label.Content = string.Format($"Order: {order.OrderNumber}");
		}

		public void OnOrderSaved(Order order)
		{
			this.Label.Content = string.Format($"Order Saved: {order.OrderNumber}");
		}
	}

	public class Order
	{
		public string OrderNumber { get; set; }
		public string Description { get; set; }
	}
}
