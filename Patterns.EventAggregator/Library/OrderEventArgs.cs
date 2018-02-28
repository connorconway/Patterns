using System;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Library
{
	public class OrderEventArgs : EventArgs
	{
		public Order Order { get; set; }
	}
}