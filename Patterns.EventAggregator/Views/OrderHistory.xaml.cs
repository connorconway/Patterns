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
using Patterns.EventAggregator.Library;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator
{
	/// <summary>
	/// Interaction logic for OrderHistory.xaml
	/// </summary>
	public partial class OrderHistory : UserControl, IOrderView
	{
		public OrderHistory()
		{
			InitializeComponent();
		}

		public void OnOrderSelected(Order o)
		{
			this.Label.Text = string.Format("Order History: {0}", o.OrderNumber);
		}

		public void OnOrderSaved(Order o)
		{
			this.Label.Text = string.Format("Order Saved: {0}", o.OrderNumber);
		}
	}
}
